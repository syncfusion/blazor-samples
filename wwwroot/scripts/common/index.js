var isUpdatedDevice = false;
var themeCollection = ['material', 'fabric', 'bootstrap', 'bootstrap4', 'highcontrast'];

const DEFAULT_THEME = 'bootstrap4';

window.sfBlazorSB = {
  dotnetRef: null,
  isDevice: function (dotnetObj) {
    if (dotnetObj) {
      this.dotnetRef = dotnetObj;
    }
    return this.isDeviceMode();
  },
  isDeviceMode: function () {
    //return sf.base.Browser.isDevice && document.body.offsetWidth <= 1024;
    return document.body.offsetWidth <= 1024;
  },
  // Get carousel model for calculating its postion used in the home page.
  getCarouselModel: function () {
    var documentWidth = document.body.offsetWidth;
    var imageElement = document.getElementsByClassName("sf-carousel-item")[0];
    var layoutWidth = (documentWidth - imageElement.offsetWidth) / 2;
    var finalWidth = layoutWidth - imageElement.offsetLeft;
    var leftWidth = documentWidth - imageElement.offsetWidth - (imageElement.offsetLeft * 2);
    var leftPercentage = (leftWidth * 100) / documentWidth;
    var xValue = (finalWidth * 100) / documentWidth;
    var model = {
      LeftValue: 100 - Math.round(leftPercentage),
      XValue: Math.round(xValue),
      IsDevice: this.isDeviceMode()
    };
    var progressElement = document.getElementsByClassName("sf-carousel-progress")[0];
    progressElement.style.marginLeft = xValue + 4 + "%";
    return model;
  },
  // set focus to the SB input components
  inputFocus: function (inputElement) {
    inputElement.focus();
  },
  // remove theme name from body classes
  updateBodyClass: function (themeName) {
    if (themeName != DEFAULT_THEME) {
      document.body.classList.remove(themeName);
      document.body.classList.add(DEFAULT_THEME);
    }
  },
  // set e-bigger class to the body based on mouse/touch selection
  setBiggerSize: function (isTouch) {
    var element = document.getElementsByClassName('sb-content-section');
    if (element.length) {
      if (isTouch) {
        element[0].classList.add('e-bigger');
        localStorage.setItem("sfPreferenceMode", "touch");
      } else {
        element[0].classList.remove('e-bigger');
        localStorage.setItem("sfPreferenceMode", "mouse");
      }
    }
  },
  // returns the preferences mode.
  getPreferenceMode: function () {
    var mode = localStorage.getItem("sfPreferenceMode");
    var isTouchMode = !mode && screen.availWidth >= 2160;
    if (isTouchMode || this.isDeviceMode() || (mode && mode != "mouse")) {
      mode = "touch";
      this.setBiggerSize(true);
    }
    mode = !mode ? "mouse" : mode;
    return mode;
  },
  // wire search popup keyboard events
  wireSearchEvents: function (dotnetRef, inputElement, popupElement) {
    inputElement.onkeydown = function (e) {
      if (!popupElement.classList.contains('sb-hide')) {
        switch (e.keyCode) {
          case 27:
          case 13:
            if (e.keyCode === 13) {
              var liElement = popupElement.querySelector('li.sf-search-hover');
              if (liElement) {
                liElement.click();
              }
            }
            dotnetRef.invokeMethodAsync('HidePopup', true);
            break;
          case 38:
          case 40:
            var liElements = popupElement.querySelectorAll('li.sf-list-li');
            if (!liElements.length) {
              return;
            }
            var prevLi = popupElement.querySelector('li.sf-search-hover');
            if (prevLi) {
              var liElement = e.keyCode === 40 ? prevLi.nextElementSibling : prevLi.previousElementSibling;
              if (liElement && liElement.classList.contains('sf-list-group-li')) {
                liElement = e.keyCode === 40 ? liElement.nextElementSibling : liElement.previousElementSibling;
              }
              if (!liElement) {
                liElement = e.keyCode === 40 ? liElements[0] : liElements[liElements.length - 1];
              }
              prevLi.classList.remove('sf-search-hover');
              liElement.classList.add('sf-search-hover');
            }
            else if (liElements) {
              var liElement = e.keyCode === 40 ? liElements[0] : liElements[liElements.length - 1];
              liElement.classList.add('sf-search-hover');
            }
            dotnetRef.invokeMethodAsync('UpdateKeyboardInteraction');
            break;
        }
      }
    };
  },
  // Start region - diagram methods
  // Diagram - Save the particular diagram
  saveDiagram: function (data) {
    if (window.navigator.msSaveBlob) {
      let blob = new Blob([data], { type: 'data:text/json;charset=utf-8,' });
      window.navigator.msSaveOrOpenBlob(blob, 'Diagram.json');
    } else {
      let dataStr = 'data:text/json;charset=utf-8,' + encodeURIComponent(data);
      let a = document.createElement('a');
      a.href = dataStr;
      a.download = 'Diagram.json';
      document.body.appendChild(a);
      a.click();
      a.remove();
    }
  },
  uploadFilesClick: function () {
    document.getElementById('UploadFiles').click();
  },
  loadFile: function (file) {
    var base64 = file.rawFile.replace("data:application/json;base64,", "");
    var json = atob(base64)
    return json;
  },
  // End region - diagram methods
  saveAsFile: function (filename, bytesBase64) {
    if (window.navigator.msSaveBlob) {
      //Download document in Edge browser
      var data = window.atob(bytesBase64);
      var bytes = new Uint8Array(data.length);
      for (var i = 0; i < data.length;) {
        bytes[i] = data.charCodeAt(i);
      }
      var blob = new Blob([bytes.buffer], { type: "application/octet-stream" });
      window.navigator.msSaveBlob(blob, filename);
    }
    else {
      var link = document.createElement('a');
      link.download = filename;
      link.href = "data:application/octet-stream;base64," + bytesBase64;
      document.body.appendChild(link); // Needed for Firefox
      link.click();
      document.body.removeChild(link);
    }
  }
};

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
  // Add mobile class to the body element for device rendering.
  if (sfBlazorSB.isDeviceMode()) {
    document.body.classList.add("mobile");
  }

  // Add current theme name to the body element.
  var themeName = DEFAULT_THEME;
  if (/theme=/g.test(location.search)) {
    themeName = location.search.replace("?theme=", "");
  }
  document.body.classList.add(themeName);
});

window.onresize = function () {
  var isDevice = sfBlazorSB.isDeviceMode();
  if ((isDevice && !isUpdatedDevice) || (!isDevice && isUpdatedDevice)) {
    isUpdatedDevice = !isUpdatedDevice;
    sfBlazorSB.dotnetRef.invokeMethodAsync("UpdateDeviceMode", isDevice);
  }
};

(function () {
  if (typeof NodeList.prototype.forEach === "function") return false;
  NodeList.prototype.forEach = Array.prototype.forEach;
})();


