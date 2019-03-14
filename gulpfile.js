require("@syncfusion/ej2-staging");
var gulp = require('gulp');
var shelljs = require('shelljs');
var glob = require('glob');
gulp.task('ship-pages', function (done) {
    shelljs.rm('-Rf', './ej2-blazor-samples/wwwroot/Pages/**');
    shelljs.cp('-R', './ej2-blazor-samples/Pages', './ej2-blazor-samples/wwwroot/Pages');
    var files = glob.sync('./ej2-blazor-samples/wwwroot/Pages/**/*.*');
    files.forEach(function (path) {
        shelljs.mv(path, path + '.txt');
    });
    done();
});