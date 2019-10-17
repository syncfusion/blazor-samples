var a = "";
var ik = 0;
var flag = true;
var currentTheme = 'material';
var themeCollection = ['material', 'fabric', 'bootstrap', 'bootstrap4', 'highcontrast'];
var isMobile = window.matchMedia('(max-width:550px)').matches;
var previous;
function viewSwitch(list) {
    var componentsList = ej.base.select("#components-tree");
    var controlList = ej.base.select("#controlSamples");
    if (list === "sb-hide") {
        controlList.classList.add("sb-hide");
        if(componentsList.classList.contains("sb-hide")){
        componentsList.classList.remove("sb-hide");
        }
    } else {
        controlList.classList.remove("sb-hide");
        componentsList.classList.add("sb-hide");
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
    previous = document.querySelector(".sb-icon-icon-selection");
    if (previous) {
      previous.classList.remove("sb-icon-icon-selection");
    }
    var curTheme = document.getElementById("menuitem_0-ej2menu-theme-menu-popup").querySelector(".e-selected");
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
};

function tickTheme() {
  var previous = document.querySelector(".sb-icon-icon-selection");
  if (previous) {
    previous.classList.remove("sb-icon-icon-selection");
  }
  var curTheme = document.getElementById("menuitem_0-ej2menu-theme-menu-popup").querySelector(".e-selected");
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
currentTheme = curTheme.innerText;
}

function persistTheme(){
if(/theme=/g.test(location.href)){
currentTheme = location.search.split("=")[1]
 }
}

function mobileThemePersist(){
persistTheme();
var mobDrop = document.querySelector("#mobileTheme");
if(currentTheme === "highcontrast"){
   mobDrop.value = "High Contrast"
} else if(currentTheme === "bootstrap4"){
   mobDrop.value = "Bootstrap V4"
} else {
   mobDrop.value = currentTheme.charAt(0).toUpperCase() + currentTheme.slice(1);
 }
}

function persistURL(navUrl) {
  history.pushState("", "", navUrl + "?theme=" + currentTheme);
}

function homeButtonClick() {
    document.getElementById('sb-home').click();
}

function refreshTab(code, s, id) {
  setTimeout(function () {
      if (s.sourceFiles.length !== 0) {
        document.querySelector("#" + id[ik]).innerHTML = code[ik];
      if (s.sourceFiles[ik].fileName.split(".")[1] === "cs") {
        hljs.highlightBlock(document.querySelector("#" + id[ik]), { language: "cs" });
      } else {
        hljs.highlightBlock(document.querySelector("#" + id[ik]), { language: "cshtml" });
      }
    } else {
      document.querySelector("#code").innerHTML = code;
      hljs.highlightBlock(document.querySelector("#code"), { language: "cshtml" });
    }
    document.querySelector("#right-pane").scrollTo(0, 0);
  }, 100);
}

function tabClicked(arg, sourceResponse) {
  if (arg.selectedIndex !== 0) {
    var codeBlock = document.querySelector("#sb-source-tab" + " " + "#" + arg.selectedContent.id + " " + "pre");
    var tabHeader = document.querySelector("#sb-source-tab" + " " + ".e-tab-header" + " " + "#" + arg.selectedItem.id + " " + ".e-tab-text").innerText;
    document.querySelector("#" + codeBlock.id).innerHTML = sourceResponse[arg.selectedIndex];
    if (tabHeader.split(".")[1] === "cs") {
      hljs.highlightBlock(codeBlock, { language: "cs" });
    } else {
      hljs.highlightBlock(codeBlock, { language: "cshtml" });
    }
  }
  else {
      hljs.highlightBlock(codeBlock, { language: "cshtml" });
  }
  document.querySelector("#right-pane").scrollTo(0, 0);
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
  document.querySelector("#content-tab").ej2_instances[0].select(0);
}

function updateActionDescription(content) {
  var a = "";
  if (content.length) {
    for (var i = 0; i < content.length; i++) {
      a += content[i];
    }
  }
    document.querySelector(".sb-action-description").innerHTML = "<p>" + a + "</p>";
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
  //window.dispatchEvent(new Event('resize'));
    window.resizeTo(
        window.screen.availWidth,
        window.screen.availHeight
    );

}

function mobileSideBarVisibility() {
  document.querySelector('#right-sidebar').setAttribute('style', 'visibility:visible;')
}

function mobileThemeChange(args){
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
        } else if(eleRight.classList.contains("e-open")){
          eleRight.classList.remove("e-open");
          eleRight.classList.add("e-close");
        }
      }
    }
  }
});