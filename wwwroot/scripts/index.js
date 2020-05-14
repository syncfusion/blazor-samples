var a = "";
var ik = 0;
var flag = true;
var currentTheme = 'bootstrap4';
var themeCollection = ['material', 'fabric', 'bootstrap', 'bootstrap4', 'highcontrast'];
var isMobile = window.matchMedia('(max-width:550px)').matches;
var previous;
var Title;
var ControlName;
var FileName;
var Descript;
function viewSwitch(list) {
  var componentsList = sf.base.select("#components-tree");
  var controlList = sf.base.select("#controlSamples");
  if (list === "sb-hide") {
    controlList.classList.add("sb-hide");
    if (componentsList.classList.contains("sb-hide")) {
      componentsList.classList.remove("sb-hide");
    }
  } else {
    controlList.classList.remove("sb-hide");
    componentsList.classList.add("sb-hide");
  }
}

// function titleDescription(control, sample) {    
//     document.getElementsByTagName('title')[0].innerHTML = control;    
//     Title = control;
//     Descript = sample;
// }

function ScrollOption() {
  var list = document.querySelector('#sample-list');
  var ToScrollTo = list.querySelector('.e-list-item.e-active');
  list.scrollTop = ToScrollTo.offsetTop - 50;
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

function titleDescription(control, filename) {
  //Controlname = control.split('/')[1];
  //Filename = filename.substring(0, filename.indexOf('.razor'));
  Title = "Blazor " + control + " " + filename + " Example - Syncfusion Demos";
  document.getElementsByTagName('title')[0].innerHTML = Title;
  Descript = "This example demonstrates the " + filename + " in Blazor " + control + " Component. Explore here for more details.";
  document.querySelector('meta[name="description"]').setAttribute("content", Descript);
}

function hideSpinner() {
  var loader = document.querySelector(".sb-loading");
  loader.classList.add("sb-hide");
  loader.classList.remove("sb-trans");
  var bodyOverlay = document.querySelector(".sb-body-overlay");
  bodyOverlay.classList.add("sb-hide");
  bodyOverlay.classList.remove("sb-trans");
}

function getTheme() {
  var menu = (document.querySelector(
    "#theme-menu"
  ).ej2_instances[0].beforeOpen = function (arg) {
    var theme = "bootstrap4";
    if (/theme=/g.test(location.search)) {
      theme = location.search.replace("?theme=", "");
      // theme = toInitCap(theme);
    }

    var themeEle = arg.element.querySelector("#" + theme);
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

function switchTheme(url) {
  window.location.href = url;

  var themeName = getParameterByName("theme");
  if (sf && themeName === 'material') {
    sf.base.enableRipple(true);
  }
}


function persistTheme() {
  if (/theme=/g.test(location.href)) {
    currentTheme = location.search.split("=")[1];
    return currentTheme;
  }
}


function mobileThemePersist() {
  persistTheme();
  var mobDrop = document.querySelector("#mobileTheme");
  if (currentTheme === "highcontrast") {
    mobDrop.value = "High Contrast"
  } else if (currentTheme === "bootstrap4") {
    mobDrop.value = "Bootstrap V4"
  } else {
    mobDrop.value = currentTheme.charAt(0).toUpperCase() + currentTheme.slice(1);
  }
}

function persistURL(navUrl) {
  //history.pushState("", "", navUrl + "?theme=" + currentTheme);
}

function homeButtonClick() {
  document.getElementById('sb-home').click();
}

function refreshTab(code, filename) {
  setTimeout(function () {
        var tabs = document.querySelector(".sb-src-code");
        if (tabs) {
            tabs.innerHTML = code;
            if (!filename) {
                hljs.highlightBlock(tabs, { language: "cshtml" });
            }
            else if (filename.split(".")[1] === "cs") {
                hljs.highlightBlock(tabs, { language: "cs" });
            } else {
                hljs.highlightBlock(tabs, { language: "cshtml" });
            }
        }
        document.querySelector("#right-pane").scrollTop = 0;
    }, 100);
}


function updateDescription(content) {
  var a = "";
  if (content.length) {
    for (var i = 0; i < content.length; i++) {
      a += content[i];
    }
  }
  document.querySelector(".description-section").innerHTML = "<p>" + a + "</p>";
}

function destroyControl() {
  document.querySelectorAll("#control-content .e-control").forEach(function (e) {
    try {
      e.ej2_instances[0].destroy();
    }
    catch (e) { }
  });
  //document.querySelector("#content-tab").ej2_instances[0].selectedItem = 0;
  var tab = document.querySelector("#content-tab").ej2_instances[0];
  if (tab.selectedItem != 0) {
    tab.selectedItem = 0;
    tab.setActive(tab.selectedItem);
  }
}

function updateActionDescription(content) {
  var a = "";
  if (content.length) {
    for (var i = 0; i < content.length; i++) {
      a += content[i];
    }
  }
  document.querySelector(".sb-action-description").innerHTML = a;
}



function sanitizeHTML(s) {
  var d = document.createElement('div');
  d.appendChild(document.createTextNode(s));
  return d.innerHTML;
}

function getParameterByName(name, url) {
  if (!url) url = window.location.href;
  name = name.replace(/[\[\]]/g, "\\$&");
  var regex = new RegExp("[?&]" + name + "(=([^&#]*)|&|#|$)"),
    results = regex.exec(url);
  if (!results) return "bootstrap4";
  if (!results[2]) return "";
  return decodeURIComponent(results[2].replace(/\+/g, " "));
}

function callResizeEvent() {
  //window.dispatchEvent(new Event('resize'));
  window.resizeTo(
    window.screen.availWidth,
    window.screen.availHeight
  );

}

function mobileSideBarVisibility() {
  document.querySelector('#right-sidebar').setAttribute('style', 'visibility:visible;')
}

function mobileThemeChange(args) {
  if (/theme=/g.test(location.href)) {
    window.location.href = location.href.replace(
      /theme=.*/g,
      "theme=" + (args.replace(" ", "")).replace("V", "").toLowerCase()
    );
  } else {
    window.location.href =
      location.href + "?theme=" + (args.replace(" ", "")).replace("V", "").toLowerCase();
  }
}

function isDevice() {
  return /android|webos|iphone|ipad|ipod|blackberry|iemobile|opera mini|mobile/i.test(navigator.userAgent);
}

window.addEventListener('load', function () {
  if (isDevice()) { document.body.classList.add("mobile"); }
  var theme = "bootstrap4";
  if (/theme=/g.test(location.search)) {
    theme = location.search.replace("?theme=", "");
  }
  loadTheme(theme);
  //titleDescription(Title);
  //addMetaDescription(Descript);
});

document.addEventListener('click', function (event) {
  if (isDevice()) {
    var pan = document.querySelector('#left-sidebar').ej2_instances[0];
    var panRight = document.querySelector('#right-sidebar').ej2_instances[0];
    var ele = document.querySelector('#left-sidebar');
    var eleRight = document.querySelector('#right-sidebar');
    if (pan.closeOnDocumentClick != true) {
      ele = document.querySelector('#left-sidebar');
      var val = ele.getAttribute('style');
      ele.setAttribute('style', val + ';position:fixed');
      pan.closeOnDocumentClick = true;
    }
    if (panRight.closeOnDocumentClick != true) {
      ele = document.querySelector('#right-sidebar');
      var val = ele.getAttribute('style');
      ele.setAttribute('style', val + ';position:fixed');
      panRight.closeOnDocumentClick = true;
    }
    if (isMobile) {
      var hide = '.e-list-item, .e-list-text';
      if (event.target.matches(hide)) {
        if (ele.classList.contains("e-open")) {
          ele.classList.remove("e-open");
          ele.classList.add("e-close");
        } else if (eleRight.classList.contains("e-open")) {
          eleRight.classList.remove("e-open");
          eleRight.classList.add("e-close");
        }
      }
    }
  }
});

(function () {
  if (typeof NodeList.prototype.forEach === "function") return false;
  NodeList.prototype.forEach = Array.prototype.forEach;
})();