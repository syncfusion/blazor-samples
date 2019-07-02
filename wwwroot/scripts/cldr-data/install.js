/**
 * Npm module for Unicode CLDR JSON data
 *
 * Copyright 2013 Rafael Xavier de Souza
 * Released under the MIT license
 * https://github.com/rxaviers/cldr-data-npm/blob/master/LICENSE-MIT
 */

"use strict";

var coverage, parentPackage, peerPackages, srcUrl;

var cldrDownloader = require("cldr-data-downloader");
var glob = require("glob").sync;
var path = require("path");
var child_process = require('child_process');

var options = {};

var isNpm3;
try {
  var npmv = child_process.execSync('npm -v').toString('utf8');
  isNpm3 = (npmv.split('.')[0] == '3');
} catch(error) {
  // child_process.execSync is not available on Node v0.10
  // fortunately, we can use ENV variables set by npm do detect its version
  //   npm_config_user_agent: 'npm/2.15.1 node/v0.10.46 darwin x64'
  //   npm_config_user_agent: 'npm/3.10.3 node/v6.3.0 darwin x64'
  // Note that users can override the value of this config option,
  // therefore it's safer to use this method only as a fall-back option.
  if (/^npm\/2\./.test(process.env.npm_config_user_agent)) {
    isNpm3 = false;
  } else {
    // Better safe than sorry.
    isNpm3 = true;
  }
}

try {
  parentPackage = require("../../package.json");
} catch(error) {}

try {
  peerPackages = glob("../*/package.json").map(function(file) {
    try {
      return require(path.resolve(file));
    } catch(error) {
      return {};
    }
  });
} catch(error) {
  console.error(
    "Warning: Something weird happened checking whether this is a " +
    "peer dependency.", error.message
  );
  peerPackages = [];
}

if (!isNpm3 && parentPackage &&
      !(parentPackage.dependencies && parentPackage.dependencies["cldr-data"]) &&
      !(parentPackage.devDependencies && parentPackage.devDependencies["cldr-data"]) &&
      peerPackages.some(function(peerPackage) {
        return peerPackage.peerDependencies &&
          peerPackage.peerDependencies["cldr-data"];
      })) {
  console.error(
    "Warning: Skipping to download CLDR data, because `cldr-data` is a " +
    "peer dependency. If you want it to be downloaded, make sure it's " +
    "listed under `dependencies` or `devDependencies` of the `package.json`" +
    "of your application."
  );
  return process.exit(0);
}

if (process.env.CLDR_URL) {
  console.warn("CLDR_URL is deprecated, use CLDR_DATA_URLS_JSON instead.")
  srcUrl = srcUrl.replace(
    "http://www.unicode.org/Public/cldr",
    process.env.CLDR_URL.replace(/\/$/, "")
  );

} else {
  if (process.env.CLDR_DATA_URLS_JSON) {
    srcUrl = process.env.CLDR_DATA_URLS_JSON;
  } else if (parentPackage && parentPackage["cldr-data-urls-json"]) {
    srcUrl = parentPackage["cldr-data-urls-json"];
  } else {
    srcUrl = path.join(__dirname, "./urls.json");
  }
}

if (process.env.CLDR_COVERAGE) {
  coverage = process.env.CLDR_COVERAGE;
} else if (parentPackage && parentPackage["cldr-data-coverage"] && (
      (parentPackage.dependencies && parentPackage.dependencies["cldr-data"]) ||
      (parentPackage.devDependencies && parentPackage.devDependencies["cldr-data"])
      )) {
  coverage = parentPackage["cldr-data-coverage"];
}

if (process.env.CLDR_DATA_URLS_FILTER) {
  options.filterRe = process.env.CLDR_DATA_URLS_FILTER;
} else if (parentPackage && parentPackage["cldr-data-urls-filter"]) {
  options.filterRe = parentPackage["cldr-data-urls-filter"];
}

if (coverage) {
  options.srcUrlKey = coverage;
}

cldrDownloader(
  srcUrl,
  __dirname,
  options,
  function(error) {
    if (error) {
      if (/E_ALREADY_INSTALLED/.test(error.code)) {
        error.message = error.message.replace(/Use `options.*/, "Use -f to " +
          "override.");
        return console.log(error.message);
      } else {
        console.error("Whops", error.message);
        process.exit(1);
      }
    }
  }
);
