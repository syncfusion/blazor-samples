var showcaseRef;
var isScrolled = false;
var isUpdatedDevice = false;
var themeCollection = ['bootstrap5', 'bootstrap5-dark', 'tailwind', 'tailwind-dark', 'material', 'bootstrap4', 'bootstrap', 'bootstrap-dark', 'fabric', 'fabric-dark', 'highcontrast'];

const DEFAULT_THEME = 'bootstrap5';

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
  updateShowCaseRef: function (dotnetRef) {
    showcaseRef = dotnetRef;
    this.renderShowCase();
  },
  renderShowCase: function () {
    if (!isScrolled && document.documentElement.scrollTop > 0 && showcaseRef != null) {
      isScrolled = true;
      showcaseRef.invokeMethodAsync('RenderShowCase');
    }
  },
  // Refresh showcase position
  refreshShowCase: function () {
    var element = document.querySelector('.sf-showcase-bg.appointment-planner');
    setTimeout(function () {
      element.style.left = "0%";
      element.parentElement.classList.remove("sf-showcase-transition");
      element.parentElement.style.transform = "translateX(0%)";
      setTimeout(function () {
        element.parentElement.classList.add("sf-showcase-transition");
      }, 100);
    }, 950);
  },
  // set e-bigger class to the body based on mouse/touch selection
  setBiggerSize: function (isTouch) {
      if (isTouch) {
        document.body.classList.add('e-bigger');
        localStorage.setItem("sfPreferenceMode", "touch");
      } else {
          document.body.classList.remove('e-bigger');
        localStorage.setItem("sfPreferenceMode", "mouse");
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
  // Load resources dynamically 
  loadResources: function (resources) {
    for (var i = 0; i < resources.length; i++) {
      var resource;
      if (resources[i].endsWith('.css')) {
        resource = document.createElement('link');
        resource.setAttribute('href', resources[i]);
        resource.setAttribute('rel', 'stylesheet');
      }
      else {
        resource = document.createElement('script');
        resource.setAttribute('src', resources[i]);
        resource.setAttribute('async', true);
      }
      document.getElementsByClassName('dynamic-resources')[0].appendChild(resource);
    }
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
            else {
              this.value = "";
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

function OnDragStopCall(dragEventArgs) {
  var targetElement = document.elementFromPoint(dragEventArgs.left, dragEventArgs.top);
  var listEle = targetElement.closest(".e-droppable");
  if (listEle && listEle.classList.contains("custom-list")) {
      var id = dragEventArgs.draggedNodeData.id;
      var text = dragEventArgs.draggedNodeData.text;
      return { Id: id, Text: text };
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

window.preventSpaceKey = () => {
  var element = document.getElementsByClassName("control-section chip-container")[0];
  if (element != null) {
      element.addEventListener("keydown", function (e) {
          if (e.target && e.target.classList.contains("e-chip") && e.keyCode == 32) {
              e.preventDefault();
          }
      });
  }
};

function focusElement(ele) {
    if (ele) {
        ele.focus();
    }
}

//tooltip keyboard navigation sample function for focuing input
function focusInput(id) {
    setTimeout(function () {
        document.getElementById(id).focus();
    }, 500);
}

document.addEventListener("keydown", function (e) {
    if (e.altKey === true && e.keyCode === 74) {
        var ele = document.querySelector('.sb-demo-section .e-control');
        if (ele) {
            if (ele.classList.contains('e-tab')) {
                ele = ele.querySelector('.e-toolbar-item .e-tab-wrap');
                ele.tabIndex = 0;
            }
            else if (ele.classList.contains('e-accordion')) {
                ele = ele.querySelector('.e-acrdn-header');
            }
            else if (ele.classList.contains('e-dropdownlist')) {
                ele = ele.parentElement;
            }
        }
        focusElement(ele);
    }
});

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

window.onscroll = function () {
  var scroll = document.documentElement.scrollTop;
  var headerElement = document.querySelector('.sf-header');
  if (headerElement) {
    headerElement = scroll > 0 ? headerElement.classList.add('active') : headerElement.classList.contains('active') ? headerElement.classList.remove('active') : headerElement;
  }
  sfBlazorSB.renderShowCase();
};

window.onbeforeunload = function () {
  localStorage.removeItem("sfPreferenceMode");
};

(function () {
  if (typeof NodeList.prototype.forEach === "function") return false;
  NodeList.prototype.forEach = Array.prototype.forEach;
})();


