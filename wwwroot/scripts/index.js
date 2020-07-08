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
var openedPopup;
var prevAction;
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

function setScrollTop() {
  var list = document.querySelector('#sample-list');
  var selectedItem = list.querySelector('.e-list-item.e-active');
  if (selectedItem) {
    var scrollView = (selectedItem.offsetTop + selectedItem.offsetHeight) - list.scrollTop;
    if (scrollView < 0 || scrollView > list.offsetHeight) {
        list.scrollTop = selectedItem.offsetTop + selectedItem.offsetHeight / 2
    }
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
  rendersbPopup();
  SetMouseorTouch();
  //loadTheme(location.search.replace("?theme=", ""));
}

function rendersbPopup() {
  var settingElement = sf.base.select('.sb-setting-btn');
  settingsPopup = new sf.popups.Popup(document.getElementById('settings-popup'), {
    offsetY: 5,
    relateTo: settingElement,
    position: { X: 'right', Y: 'bottom' },
    collision: { X: 'flip', Y: 'flip' }
  });
  settingsPopup.hide();
  bindEvents();
}

function bindEvents() {
  var settingElement = sf.base.select('.sb-setting-btn');
  var setResponsiveElement = sf.base.select('.setting-responsive');
  document.addEventListener('click', sbHeaderClick.bind(this, 'closePopup'));
  settingElement.addEventListener('click', function (e) {
    e.preventDefault();
    e.stopPropagation();
    sbHeaderClick('toggleSettings');
  });
  document.getElementById('settings-popup').addEventListener('click', function (e) {
    e.preventDefault();
    e.stopPropagation();
  });
  setResponsiveElement.addEventListener('click', changeMouseOrTouch);
}

function sbHeaderClick(action, preventSearch) {
  var curPopup;
  var settingElement = sf.base.select('.sb-setting-btn');
  if (openedPopup) {
    openedPopup.hide(new sf.base.Animation({ name: 'FadeOut', duration: 300, delay: 0 }));
  }
  if (action === 'toggleSettings') {
    settingElement.classList.toggle('active');
    setPressedAttribute(settingElement);
    curPopup = settingsPopup;
  }
  if (action === 'closePopup') {
    settingElement.classList.remove('active');
  }
  if (curPopup && curPopup !== openedPopup) {
    curPopup.show(new sf.base.Animation({ name: 'FadeIn', duration: 400, delay: 0 }));
    openedPopup = curPopup;
  } else {
    openedPopup = null;
  }
  prevAction = action;
}

function setPressedAttribute(ele) {
  var status = ele.classList.contains('active');
  ele.setAttribute('aria-pressed', status ? 'true' : 'false');
}

function SetMouseorTouch() {
  var ele = localStorage.getItem('blazor-switch');
  if (ele != null) {
    document.getElementById(ele).classList.add('active');
    if (ele === 'touch')
      document.body.classList.add('e-bigger');
  }
  else {
    document.querySelector('.sb-responsive-items').classList.add('active');
  }
}


function toInitCap(str) {
  return str.charAt(0).toUpperCase() + str.substr(1);
}

function changeMouseOrTouch(e) {
  var ele = sf.base.closest(e.target, '.sb-responsive-items');
  var str = ele.id;
  var setResponsiveElement = sf.base.select('.setting-responsive');
  var activeEle = setResponsiveElement.querySelector('.active');
  if (activeEle) {
    activeEle.classList.remove('active');
  }
  setResponsiveElement.querySelector('#' + str).classList.add('active');

  localStorage.setItem('blazor-switch', str);
  location.reload();

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
  var highlightCodeInterval = setInterval(highlightSource, 0);

  function highlightSource() {
    var tabs = document.querySelector(".sb-src-code");
    if (tabs) {
      tabs.innerHTML = code;
      if (!filename) {
        tabs.classList.remove('cs');
        tabs.classList.add('blazor');
        hljs.highlightBlock(tabs);
      }
      else if (filename.split(".")[1] === "cs") {
        tabs.classList.remove('blazor');
        tabs.classList.add('cs');
        hljs.highlightBlock(tabs);
      } else {
        tabs.classList.remove('cs');
        tabs.classList.add('blazor');
        hljs.highlightBlock(tabs);
      }
      clearInterval(highlightCodeInterval);
    }
    document.querySelector("#right-pane").scrollTop = 0;
  }
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