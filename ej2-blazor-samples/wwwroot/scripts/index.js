var a = "";
var flag = true;
var themeCollection = ['material', 'fabric', 'bootstrap', 'bootstrap4', 'highcontrast'];
var isMobile = window.matchMedia('(max-width:550px)').matches;
function viewSwitch() {
  var controlTree = ej.base.select("#controlTree");
  var controlList = ej.base.select("#controlSamples");

  if (controlTree.classList.contains("trans-left")) {
    controlTree.classList.remove("trans-left");
    controlList.classList.add("trans-right");
  } else {
    controlTree.classList.add("trans-left");
    controlList.classList.remove("trans-right");
  }
}

function loadTheme(theme) {
  var body = document.body;
  if (body.classList.length > 0) {
    for (var themeItem in themeCollection) {
      body.classList.remove(themeCollection[themeItem]);
    }
  }
  body.classList.add(theme);
}

function getTheme() {
  var menu = (document.querySelector(
    "#theme-menu"
  ).ej2_instances[0].beforeOpen = function (arg) {
    var theme = "Material";
    if (/theme=/g.test(location.search)) {
      theme = location.search.replace("?theme=", "");
      theme = toInitCap(theme);
    }

    var themeEle = arg.element.querySelector("[aria-label='" + theme + "']");
    if (themeEle) {
      themeEle.classList.add("sb-icon-icon-selection");
      if (!themeEle.classList.contains("sb-icons")) {
        themeEle.classList.add("sb-icons");
      }
    }
  });
  //loadTheme(location.search.replace("?theme=", ""));
}

function toInitCap(str) {
  return str.charAt(0).toUpperCase() + str.substr(1);
}

function switchTheme(args) {
  var previous = document.querySelector(".sb-icon-icon-selection");
  if (previous) {
    previous.classList.remove("sb-icon-icon-selection");
  }
  var curTheme = document
    .getElementById("menuitem_0-menu-popup")
    .querySelector(".e-selected");
  curTheme.classList.add("sb-icon-icon-selection");
  if (!curTheme.classList.contains("sb-icons"))
    curTheme.classList.add("sb-icons");
  if (/theme=/g.test(location.href)) {
    window.location.href = location.href.replace(
      /theme=.*/g,
      "theme=" + (curTheme.innerText.replace(" ", "")).replace("V", "").toLowerCase()
    );
  } else {
    window.location.href =
      location.href + "?theme=" + (curTheme.innerText.replace(" ", "")).replace("V", "").toLowerCase();
  }
  //loadTheme(curTheme.innerText.toLowerCase());
}
function refreshTab(code) {
  setTimeout(function () {
    document.querySelector("#sb-source-tab").ej2_instances[0].refresh();
    document.querySelector("#code").innerHTML = code;
    hljs.highlightBlock(document.querySelector("#code"), { language: "cshtml" });
    document.querySelector("#right-pane").scrollTo(0, 0);
  }, 300);
}

function updateDescription(content) {
  document.querySelector("#content-tab").ej2_instances[0].select(0);
  var a = "";
  if (content.length) {
    for (var i = 0; i < content.length; i++) {
      a += "<p>" + content[i] + "</p>";
    }
  }
  document.querySelector(".description-section").innerHTML = a;
}

void function persistURL(navUrl){
  var pURL = (window.location.href).match(/theme=.*/g)[0];
 // return (window.location.href).replace(window.location.pathname, "/" + navUrl.url);
  return "?" + pURL;
}

function destroyControl() {
  document.querySelectorAll("#control-content .e-control").forEach(function (e) {
    try {
      e.ej2_instances[0].destroy();
    }
    catch (e) { }
  });
}

function tickTheme() {
  var previous = document.querySelector(".sb-icon-icon-selection");
  if (previous) {
    previous.classList.remove("sb-icon-icon-selection");
  }
  var curTheme = document.getElementById("menuitem_0-menu-popup").querySelector(".e-selected");
  curTheme.classList.add("sb-icon-icon-selection");
  if (!curTheme.classList.contains("sb-icons"))
    curTheme.classList.add("sb-icons");
  if (/theme=/g.test(location.href)) {
    window.location.href = location.href.replace(
      /theme=.*/g,
      "theme=" + (curTheme.innerText.replace(" ", "")).replace("V", "").toLowerCase()
    );
  } else {
    window.location.href =
      location.href + "?theme=" + (curTheme.innerText.replace(" ", "")).replace("V", "").toLowerCase();
  }
}

function updateActionDescription(content) {
  var a = "";
  if (content.length) {
    for (var i = 0; i < content.length; i++) {
      a += "<p>" + content[i] + "</p>";
    }
  }
  document.querySelector(".sb-action-description").innerHTML = a;
}
function updateBreadCrumb(controlName, path) {
  var content_div = "<div class='bread-ctext'>";
  var close_div = "</div>";
  var sperator_div =
    "<div class='category-seperator sb-icons sb-icon-Next seperator'></div>";
  document
    .getElementById("component-name")
    .querySelector("h1").innerText = controlName;

  path = path.map(function (v, i) {
    if (v === null) {
      return "";
    }
    return (i !== 0 ? sperator_div : "") + content_div + v + close_div;
  });
  document
    .getElementById("sample-bread-crumb")
    .querySelector(".sb-bread-crumb-text").innerHTML = path.join("");
}

function getParameterByName(name, url) {
  if (!url) url = window.location.href;
  name = name.replace(/[\[\]]/g, "\\$&");
  var regex = new RegExp("[?&]" + name + "(=([^&#]*)|&|#|$)"),
    results = regex.exec(url);
  if (!results) return "material";
  if (!results[2]) return "";
  return decodeURIComponent(results[2].replace(/\+/g, " "));
}

function callResizeEvent() {
  window.dispatchEvent(new Event('resize'));
}

window.addEventListener('load', function () {
  if (ej.base.Browser.isDevice) { document.body.classList.add("mobile"); }
  var theme = "Material";
  if (/theme=/g.test(location.search)) {
    theme = location.search.replace("?theme=", "");
  }
  loadTheme(theme);
});

document.addEventListener('click', function (event) {
  if (ej.base.Browser.isDevice) {
    var pan = document.querySelector('#left-sidebar').ej2_instances[0];
    var ele = document.querySelector('#left-sidebar');
    if (pan.closeOnDocumentClick != true) {
      ele = document.querySelector('#left-sidebar');
      var val = ele.getAttribute('style');
      ele.setAttribute('style', val + ';position:fixed');
      pan.closeOnDocumentClick = true;
    }
    if (isMobile) {
      var hide = '.e-list-item, .e-list-text';
      if (event.target.matches(hide)) {
        if (ele.classList.contains("e-open")) {
          ele.classList.remove("e-open");
          ele.classList.add("e-close");
        }
      }
    }
  }
});