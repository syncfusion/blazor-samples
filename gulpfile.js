require("@syncfusion/ej2-staging");
const { clean, restore, build } = require('gulp-dotnet-cli');
const shelljs = require('shelljs');
const fs = require('fs');
const gulp = require('gulp');
const glob = require('glob');
const path = require('path');
const table = require('table');
const SCRIPTS = ['js'];
const STYLES = ['css'];
const IMAGES = ['png', 'svg', 'gif', 'emf', 'tif', 'bmp'];
const FOLDERS = ['scripts', 'styles', 'images', 'data'];
const FONTS = ['ttf', 'woff', 'woff2', 'eot', 'svg'];

const REGEX = /[A-Z]|_|\s/g;
const DATA = SCRIPTS.concat(STYLES, IMAGES, FONTS, ['jpg']);
const ASSET_PATH = './Common/wwwroot/';
const ServerProjectPath = './Blazor Server Demos/BlazorServerDemos_NET5.csproj';
const ServerNugetPath = './Blazor Server Demos/NuGet.config';
const WasmProjectPath = './Blazor WASM Demos/Server/BlazorWasmDemos_NET5.Server.csproj';
const WasmNugetPath = './Blazor WASM Demos/Server/NuGet.config';
const ServerProjectPath_NET6 = './Blazor Server Demos/BlazorServerDemos_NET6.csproj';
const WasmProjectPath_NET6 = './Blazor WASM Demos/Server/BlazorWasmDemos_NET6.Server.csproj';

var hasErrors;
var rootFolder;
var folders = [];
var fileNames = [];
var dataFiles = [];
var styleFiles = [];
var imageFiles = [];
var scriptFiles = [];
var rootFolders = [];

gulp.task('static-assets', (done) => {
    var files = glob.sync(`${ASSET_PATH}**`);
    var parentFolder;
    files.forEach((filePath) => {
        var stat = fs.lstatSync(filePath);
        var baseName = path.basename(filePath);
        if (stat.isDirectory()) {
            parentFolder = baseName;
            var splitted = filePath.split('/');
            // Check root folder names
            if (splitted.length === 4) {
                rootFolder = baseName;
                if (FOLDERS.indexOf(baseName) === -1) {
                    rootFolders.push(baseName);
                }
            }
            // Check folder naming standards
            if (checkFileName(baseName)) {
                folders.push(getFilePath(filePath));
            }
        } else {
            if (filePath.endsWith('styles/favicon.ico')) {
                return;
            }
            var extName = path.extname(baseName).split('.')[1];
            // Check file naming standard
            if (checkFileName(baseName)) {
                fileNames.push(getFilePath(filePath));
            }
            // Check script files naming standard
            if (SCRIPTS.indexOf(extName) !== -1 && rootFolder !== 'scripts') {
                scriptFiles.push(getFilePath(filePath))
            }
            // Check styles files naming standard
            if (STYLES.indexOf(extName) !== -1 && rootFolder !== 'styles') {
                styleFiles.push(getFilePath(filePath))
            }
            // Check image files naming standard
            var isFontFile = FONTS.indexOf(extName) !== -1 && parentFolder === 'fonts' && rootFolder === 'styles';
            if (!isFontFile && ((IMAGES.indexOf(extName) !== -1 && rootFolder !== 'images') || (rootFolder === 'images' && extName === 'jpg'))) {
                imageFiles.push(getFilePath(filePath))
            }
            // Check data files naming standard
            if (DATA.indexOf(extName) === -1 && rootFolder !== 'data') {
                dataFiles.push(getFilePath(filePath))
            }
        }
    });
    generateReport(done);
});

gulp.task('warnings', (done) => {
    var reportPath = __dirname + '/warnings.log';
    console.log(reportPath);
    if (fs.existsSync(reportPath)) {
        var reportLog = fs.readFileSync(reportPath, 'utf8');
        var warnings = reportLog.match(/(.*?) warning (.*)/g);
        if (!warnings) {
            console.log("!!! No Warning Throws !!!")
            done();
        }
        else {
            console.log('\nTotal Warnings: ' + warnings.length + '\n\n');
            var tableData = [];
            for (var i = 0; i < warnings.length; i++) {
                try {
                    var fileName = warnings[i].match(/(.*)\)\: |(.*) \: /)[0].replace(':', '').trim();
                    var warningCode = warnings[i].match(/\: \warning (.*)\: (\'[a-zA-Z]|[a-zA-Z])/)[1];
                    if (warningCode.indexOf(':') !== -1) {
                        warningCode = warningCode.split(':')[0];
                    }
                    var descRegex = new RegExp(`${warningCode}: (.*)`);
                    var description = warnings[i].match(descRegex)[1].replace(/\[(.*)\]/, '').trim();
                    tableData.push([fileName, warningCode, description]);
                }
                catch (e) {
                    console.log('\n' + warnings[i] + '\n');
                    console.log('\n' + e + '\n');
                }
            }
            var config = {
                columns: {
                    0: {
                        width: 50
                    },
                    1: {
                        width: 10
                    },
                    2: {
                        width: 150
                    }
                }
            };
            tableOutput = table.table(tableData, config);
            console.log(tableOutput);

            done();
            process.exit(1);
        }
    }
    else {
        console.log("Report file not found");
        done();
    }
});

const SITEMAP_TEMPLATE = `<?xml version="1.0" encoding="UTF-8"?>
<urlset xmlns="http://www.sitemaps.org/schemas/sitemap/0.9">{{URLS}}
</urlset>`;

const SITE_URL = `
    <url>
        <loc>{{:DemoPath}}</loc>
        <lastmod>{{:Date}}</lastmod>
    </url>`;

const LOCAL_SITE_URL = `
    <url>
        <type>{{:Type}}</type>
        <loc>{{:DemoPath}}</loc>
        <lastmod>{{:Date}}</lastmod>
    </url>`;

gulp.task('sitemap-generate', function (done) {
    var siteMapFile = SITEMAP_TEMPLATE;
    var combinedUrl = '';
    var date = new Date().toISOString().substring(0, 10);
    var path = 'https://blazor.syncfusion.com/demos/';
    var files = glob.sync('./Common/Pages/**/SampleList.cs', { ignore: ['./Common/Pages/SampleList.cs'] });
    for (var i = 0; i < files.length; i++) {
        var file = fs.readFileSync(files[i], 'utf8');
        var samples = file.match(/new Sample[\s\S]+};/g)[0];
        var splittedSample = samples.split('new Sample');
        for (var j = 1; j < splittedSample.length; j++) {
            var commentedSample = splittedSample[j].match(/\/\/(.*)Url.*=.*"(.*)"/);
            var sampleUrl = splittedSample[j].match(/Url.*=.*"(.*)"/);
            var sampleType = splittedSample[j].match(/Type.*=.*SampleType.*/);
            if (commentedSample) {
                continue;
            } else {
                var urls = SITE_URL;
                if (process.argv[4] === 'local-sitemap' && sampleType && sampleType[0].indexOf('SampleType.New') !== -1) {
                    urls = LOCAL_SITE_URL;
                    urls = urls.replace(/{{:Type}}/g, 'new');
                }
                urls = urls.replace(/{{:DemoPath}}/g, path + (sampleUrl[0].replace(/Url.*=/, '').replace(/"/g, '')).trim().toLowerCase() + '/');
                urls = urls.replace(/{{:Date}}/g, date);
                combinedUrl += urls;
            }
        }
    }
    siteMapFile = siteMapFile.replace(/{{URLS}}/g, combinedUrl);
    if (process.argv[4] === 'local-sitemap') {
        fs.writeFileSync('./BlazorServerApp/wwwroot/sitemap-demos.xml', siteMapFile, 'UTF8');
    } else {
        fs.writeFileSync('./sitemap-demos.xml', siteMapFile, 'UTF8');
    }
    done();
});

var checkFileName = (fileName) => {
    return REGEX.test(fileName);
};

var getFilePath = (filePath) => {
    return filePath.split(ASSET_PATH)[1];
};

var generateReport = (done) => {
    logConsole(rootFolders, 'ROOT FOLDERS');
    logConsole(folders, 'FOLDER NAMES');
    logConsole(fileNames, 'FILE NAMES');
    logConsole(scriptFiles, 'SCRIPT FILES');
    logConsole(styleFiles, 'STYLE FILES');
    logConsole(imageFiles, 'IMAGE FILES');
    logConsole(dataFiles, 'DATA FILES');
    if (hasErrors) {
        console.log('\n\n\n******* Check the below guideline confluence to resolve this issues *******\n');
        console.log('https://syncfusion.sharepoint.com/sites/Blazor/SitePages/Blazor%20SB%20static%20assets%20standards.aspx\n');
        done();
        process.exit(1);
    } else {
        done();
    }
};

var logConsole = (fileReport, type) => {
    if (fileReport.length) {
        hasErrors = true;
        console.log(`\n!!! The below ${type} (${fileReport.length}) having static assets standard issues !!!\n`);
        fileReport.forEach((item) => {
            console.log(item);
        });
    }
};

gulp.task('server-build', () => {
    var target = process.argv[4];
    var projectName = target === 'net6' ? ServerProjectPath_NET6 : ServerProjectPath;
    cleanProject();
    Clean(projectName);
    Restore(projectName, ServerNugetPath);
    return gulp.src([projectName], { read: false })
        .pipe(build({ configuration: 'Release', echo: true, msbuildArgs: ["/flp:Logfile=warnings.log;Verbosity=Minimal"] })
    );
});

gulp.task('wasm-build', () => {
    var target = process.argv[4];
    var projectName = target === 'net6' ? WasmProjectPath_NET6 : WasmProjectPath;
    cleanProject();
    Clean(projectName);
    Restore(projectName, WasmNugetPath);
    return gulp.src([projectName], { read: false })
        .pipe(build({ configuration: 'Release', echo: true, msbuildArgs: ["/flp:Verbosity=Minimal"] })
    );
});

function Clean(projectPath) {
    gulp.src([projectPath], { read: false }).pipe(clean());
}

function Restore(projectPath, nugetPath) {
    gulp.src([projectPath], { read: false }).pipe(restore({ configfile: nugetPath, echo: true, verbosity: 'Minimal' }));
}

gulp.task('publish', (done) => {
    var sample = process.argv[4];
    var projectPath;var outputPath;
    if (sample.indexOf('-net6') !== -1) {
        projectPath = sample === 'server-net6' ? ServerProjectPath_NET6 : WasmProjectPath_NET6;
        outputPath = sample === 'server-net6' ? 'BlazorServerApp_NET6' : 'BlazorWasmApp_NET6';
    } else {
        projectPath = sample === 'server' ? ServerProjectPath : WasmProjectPath;
        outputPath = sample === 'server' ? 'BlazorServerApp' : 'BlazorWasmApp';
    }
    cleanProject();
    var staging = (/^(release\/)/g.test('release/') || /^(hotfix\/)/g.test(process.env.BRANCH_NAME)) ? '' : '/p:STAGING=true';
    var result = shelljs.exec(`dotnet publish "${projectPath}" ${staging} -c Release --self-contained true -r win-x86 -o ${outputPath}`);
    if (result.code !== 0) {
        done();
        process.exit(1);
    }
    done();
});

var cleanProject = () => {
    var files = glob.sync('**/{bin,obj}/', {ignore: 'node_modules/**'});
    shelljs.rm('-rf', files);
};
