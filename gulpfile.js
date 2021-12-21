'use strict';

var gulp = require('gulp');
var concat = require('gulp-concat');
var cssmin = require('gulp-cssmin');
var uglify = require('gulp-uglify');
var merge = require('merge-stream');
var shelljs = require('shelljs');
var glob = require('glob');
var bundleConfig = require('./bundleconfig.json');

const REGEX = {
    css: /\.css$/,
    js: /\.js$/
};

gulp.task('min:js', async function () {
    merge(getBundles(REGEX.js).map(bundle => {
        return gulp.src(bundle.inputFiles, { base: '.' })
            .pipe(concat(bundle.outputFileName))
            .pipe(uglify())
            .pipe(gulp.dest('.'));
    }))
});

gulp.task('min:css', async function () {
    merge(getBundles(REGEX.css).map(bundle => {
        return gulp.src(bundle.inputFiles, { base: '.' })
            .pipe(concat(bundle.outputFileName))
            .pipe(cssmin())
            .pipe(gulp.dest('.'));
    }))
});

const getBundles = (regexPattern) => {
    return bundleConfig.filter(bundle => {
        return regexPattern.test(bundle.outputFileName);
    });
};

gulp.task('minify', gulp.series(['min:js', 'min:css']));

gulp.task('ship-client-pages', function (done) {
    shelljs.rm('-Rf', './wwwroot/scripts/Pages/**');
    shelljs.cp('-R', './Pages', './wwwroot/scripts/Pages');
    var files = glob.sync('./wwwroot/scripts/Pages/**/*.*');
    files.forEach(function (path) {
        shelljs.mv(path, path + '.txt');
    });
    done();
});