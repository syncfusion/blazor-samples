'use strict';

var gulp = require('gulp');
var fs = require('fs');
var path = require('path');
var concat = require('gulp-concat');
var exec = require('gulp-exec');
var uglify = require('gulp-uglify');
var merge = require('merge-stream');
var bundleConfig = require('./bundleconfig.json');

const REGEX = {
    css: /\.css$/,
    js: /\.js$/
};

gulp.task('min:js', async function () {
    merge(getBundles(REGEX.js).map(bundle => {
        var resolvedInputFiles = bundle.inputFiles.map(inputFile => path.resolve(inputFile));
        return gulp.src(resolvedInputFiles)
            .pipe(concat(bundle.outputFileName))
            .pipe(uglify())
            .pipe(gulp.dest('.'));
    }))
});

gulp.task('min:css', async function () {
    merge(getBundles(REGEX.css).map(bundle => {
        return gulp.src(bundle.inputFiles, { base: '.' })
            .pipe(concat(bundle.outputFileName))
            .pipe(gulp.dest('.'))
            .pipe(exec("csso "+ bundle.outputFileName + " --output " + bundle.outputFileName));
    }))
});

const getBundles = (regexPattern) => {
    return bundleConfig.filter(bundle => {
        return regexPattern.test(bundle.outputFileName);
    });
};

gulp.task('minify', gulp.parallel('min:js', 'min:css'));

//To refer minified importResources file in production environment
gulp.task('update-refs', function (done) {
    var indexFile = fs.readFileSync('../Blazor-WASM-Demos/wwwroot/index.html', 'utf8');
    var MinReferedIndex = indexFile.replace('importResources.js', 'importResources.min.js');
    var serviceWorkerMin = MinReferedIndex.replace('service-worker.js', 'service-worker.min.js');
    fs.writeFileSync('../Blazor-WASM-Demos/wwwroot/index.html', serviceWorkerMin, 'utf8');
    done();
})

gulp.task('update-ref-server', function (done) {
    var indexFile = fs.readFileSync('../Blazor-Server-Demos/Components/App.razor', 'utf8');
    var MinReferedIndexValue = indexFile.replace('importResources.js', 'importResources.min.js');
    fs.writeFileSync('../Blazor-Server-Demos/Components/App.razor', MinReferedIndexValue, 'utf8');
    done();
})

gulp.task('update-ref-webapp', function (done) {
    var indexFile = fs.readFileSync('../Blazor-WebApp-Demos/Blazor_WebApp_Demos/Components/App.razor', 'utf8');
    var MinReferedIndexValue = indexFile.replace('importResources.js', 'importResources.min.js');
    fs.writeFileSync('../Blazor-WebApp-Demos/Blazor_WebApp_Demos/Components/App.razor', MinReferedIndexValue, 'utf8');
    done();
})
