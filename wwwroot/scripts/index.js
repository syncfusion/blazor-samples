var prevAction;
var openedPopup;
var themeCollection = ['material', 'fabric', 'bootstrap', 'bootstrap4', 'highcontrast'];

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

function renderPreferences() {
  var settingElement = sf.base.select('.sb-setting-btn');
  var interval = setInterval(function () {
    if (sf.popups && sf.popups.Popup) {
      clearInterval(interval);
      settingsPopup = new sf.popups.Popup(document.getElementById('settings-popup'), {
        offsetY: 5,
        relateTo: settingElement,
        position: { X: 'right', Y: 'bottom' },
        collision: { X: 'flip', Y: 'flip' }
      });
      settingsPopup.hide();
      bindEvents();
      setMouseOrTouch();
    }
  }, 0);
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

function sbHeaderClick(action) {
  var curPopup;
  var settingElement = sf.base.select('.sb-setting-btn');
  if (openedPopup) {
    openedPopup.hide(new sf.base.Animation({ name: 'FadeOut', duration: 300, delay: 0 }));
  }
  if (settingElement && action === 'toggleSettings') {
    settingElement.classList.toggle('active');
    setPressedAttribute(settingElement);
    curPopup = settingsPopup;
  }
  if (settingElement && action === 'closePopup') {
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

function setMouseOrTouch() {
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

function setThemeSelection(themeName) {
  var element = document.getElementById(themeName);
  if (element != null) {
    element.classList.add('sb-icon-icon-selection', 'sb-icons');
  }
}

window.addEventListener('load', function () {
  var isDevice = /android|webos|iphone|ipad|ipod|blackberry|iemobile|opera mini|mobile/i.test(navigator.userAgent);
  if (isDevice) {
    document.body.classList.add("mobile");
  }
  var theme = "bootstrap4";
  if (/theme=/g.test(location.search)) {
    theme = location.search.replace("?theme=", "");
  }
  loadTheme(theme);
});

(function () {
  if (typeof NodeList.prototype.forEach === "function") return false;
  NodeList.prototype.forEach = Array.prototype.forEach;
})();