var isScrolled = false;
var isUpdatedDevice = false;
var isTouchEnabled = false;
const DEFAULT_THEME = 'fluent';

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
  isTablet: function () {
      return document.body.offsetWidth > 767 && document.body.offsetWidth <= 1024;
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
  renderShowCase: function () {
    if (!isScrolled && document.documentElement.scrollTop > 0) {
      isScrolled = true;
    }
  },
  // set e-bigger class to the body based on mouse/touch selection
  setBiggerSize: function (isTouch, isTouchReload) {
      if (isTouch) {
        document.body.classList.add('e-bigger');
          localStorage.setItem("sfPreferenceMode", "touch");
          if (isTouchReload) {
              isTouchEnabled = true;
              window.location.reload();
          }
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
      this.setBiggerSize(true, false);
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
  //Due to facing issue with DocumentEditor component resizing on sidebar collapse/expand, enclosed the dispatch event within setTimeout.
  setTimeout(() => { window.dispatchEvent(new Event('resize')); }, 300);
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
function changeSelector() {
    var element = document.getElementsByClassName("e-diagram-resize-handle");
    for (var i = 0; i < element.length; i++) {
        element[i].classList.remove('e-default-resize-style');
        element[i].classList.remove('e-resize-style');
        element[i].classList.remove('e-empty');
        element[i].classList.add('e-diagram-resize-handle', 'e-custom-resize-style');
    }
    var element2 = document.getElementsByTagName("Circle");
    element2.length = 1;
    var element1 = document.getElementsByClassName("e-diagram-border");
    for (var i = 0; i < element1.length; i++) {
        element1[i].classList.remove('e-default-border-style');
        element1[i].classList.remove('e-border-style');
        element1[i].classList.add('e-diagram-border', 'e-custom-border-style');
    }
    var element2 = document.getElementsByClassName("e-diagram-rotate-handle");
    element2[0].classList.add('e-diagram-rotate-handle', 'e-rotate');
    var element3 = document.getElementsByClassName("e-diagram-pivot-line");
    element3[0].classList.add('e-diagram-pivot-line', 'e-rotate');
}
function changeSelectorVisio() {
    var element = document.getElementsByClassName("e-diagram-resize-handle");
    for (var i = 0; i < element.length; i++) {
        element[i].classList.remove('e-custom-resize-style');
        element[i].classList.remove('e-resize-style');
        element[i].classList.remove('e-empty');
        element[i].classList.add('e-diagram-resize-handle', 'e-default-resize-style');
    }
    var element1 = document.getElementsByClassName("e-diagram-border");
    for (var i = 0; i < element1.length; i++) {
        element1[i].classList.remove('e-custom-border-style');
        element1[i].classList.remove('e-border-style');
        element1[i].classList.add('e-diagram-border', 'e-default-border-style');
    }
    var element2 = document.getElementsByClassName("e-diagram-rotate-handle");
    element2[0].classList.remove('e-rotate');
    var element3 = document.getElementsByClassName("e-diagram-pivot-line");
    element3[0].classList.remove('e-rotate');

}
function changeSelectorDefault() {
    var element = document.getElementsByClassName("e-diagram-resize-handle");
    for (var i = 0; i < element.length; i++) {
        element[i].classList.remove('e-custom-resize-style');
        element[i].classList.remove('e-default-resize-style');
        element[i].classList.add('e-diagram-resize-handle', 'e-resize-style');
    }

    var element1 = document.getElementsByClassName("e-diagram-border");
    for (var i = 0; i < element1.length; i++) {
        element1[i].classList.remove('e-custom-border-style');
        element1[i].classList.remove('e-default-border-style');
        element1[i].classList.add('e-diagram-border', 'e-border-style');
    }
    var element2 = document.getElementsByClassName("e-diagram-rotate-handle");
    element2[0].classList.add('e-diagram-rotate-handle', 'e-rotate');
    var element3 = document.getElementsByClassName("e-diagram-pivot-line");
    element3[0].classList.add('e-diagram-pivot-line', 'e-rotate');
}
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

function uploadClick() {
    document.querySelector('.e-file-select-wrap button').click();
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
            else if (ele.classList.contains('e-chip-list')) {
                ele = ele.querySelector('.e-chip');
            }
            else if (ele.classList.contains('e-colorpicker')) {
              ele = ele.parentElement.querySelector('.e-split-btn');
            }
            else if (ele.classList.contains('e-listbox')) {
                ele = ele.parentElement;
            }
            else if (ele.classList.contains('e-filemanager')) {
                ele = ele.querySelector('.e-toolbar-item:not(.e-hidden)').children[0];
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
      sfBlazorSB.dotnetRef.invokeMethodAsync("UpdateDeviceMode", isDevice, sfBlazorSB.isTablet());
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
    if (!isTouchEnabled) {
        localStorage.removeItem("sfPreferenceMode");
    }
};

(function () {
  if (typeof NodeList.prototype.forEach === "function") return false;
  NodeList.prototype.forEach = Array.prototype.forEach;
})();

// PowerPoint Viewer Demo Scripts
window.openUploader = function () {
    document.getElementById('UploadFiles').click();
};
window.enableSpinner = function () {
    var waitingPopUp = document.getElementById('waiting-popup')
    waitingPopUp.style.display = 'block';
};
window.disableSpinner = function () {
    var waitingPopUp = document.getElementById('waiting-popup')
    waitingPopUp.style.display = 'none';
};
window.openThumbnailPane = (viewerId) => {
    var viewer = window.sfBlazor.getCompInstance(viewerId);
    viewer.viewerBase.navigationPane.isThumbnail = false;
    viewer.thumbnailView.openThumbnailPane();
};

function beforeApplyFormat(id, isBlocked) {
      var range1 = sfBlazor.instances["mentionFormatIntegration"].getRange();
      var node = sfBlazor.instances["mentionFormatIntegration"].formatter.editorManager.nodeSelection.getNodeCollection(range1)[0];
      var blockNewLine = !(node.parentElement.innerHTML.replace(/&nbsp;|<br>/g, '').trim() == '/' || node.textContent.trim().indexOf('/')==0);
      var blockNode;
      var startNode = node;
      if (blockNewLine && isBlocked) {
          while (startNode != sfBlazor.instances[id].inputElement) {
              blockNode = startNode;
              startNode = startNode.parentElement;
          }
      }
      var startPoint = range1.startOffset;
      while (sfBlazor.instances["mentionFormatIntegration"].formatter.editorManager.nodeSelection.getRange(document).toString().indexOf("/") == -1)
      {
          sfBlazor.instances["mentionFormatIntegration"].formatter.editorManager.nodeSelection.setSelectionText(document, node, node, startPoint, range1.endOffset)
          startPoint--;
      }
     // sfBlazor.instances["mentionFormatIntegration"].formatter.editorManager.nodeSelection.setSelectionText(document, node, node, range1.startOffset - 1, range1.endOffset);
      var range2 = sfBlazor.instances["mentionFormatIntegration"].getRange();
      var node2 = sfBlazor.instances["mentionFormatIntegration"].formatter.editorManager.nodeCutter.GetSpliceNode(range2, node);
      var previouNode = node2.previousSibling;
      node2.parentNode.removeChild(node2);
      var selection = sfBlazor.instances["mentionFormatIntegration"].formatter.editorManager.nodeSelection.save(range2, document);
      if (blockNewLine && isBlocked) {
          var defaultTag = document.createElement('p');
          defaultTag.innerHTML = '</br>';
          blockNode.parentNode.insertBefore(defaultTag, blockNode.nextSibling);
          selection.setCursorPoint(document, blockNode.nextSibling, 0);
      }
      else if (previouNode) {
          selection.setCursorPoint(document, previouNode, previouNode.textContent.length);
      }
  }

function onInsertEmotSlashRemove() {
    beforeApplyFormat(null, false);
}

function loadPdfScript() {
    return new Promise(function () {
        var script = document.createElement('script');
        script.src = "_content/Syncfusion.Blazor.PdfViewer/scripts/syncfusion-blazor-pdfviewer.min.js";
        document.getElementById('dynamic-resources').appendChild(script);
    });
}

function loadWordScript() {
    return new Promise(function () {
        var script = document.createElement('script');
        script.src = "_content/Syncfusion.Blazor.WordProcessor/scripts/syncfusion-blazor-documenteditor.min.js";
        document.getElementById('dynamic-resources').appendChild(script);
    });
}

function created() {
  document.getElementById('pdfviewer_open').addEventListener('click', function () {
      document.querySelector('.e-upload-browse-btn').click()
  })
}

//For diagram component
function CommonKeyboardCommands_newDiagram() {
    var origin = window.location.origin;
    if (!origin) {
        origin = window.location.protocol + '//'
            + window.location.hostname
            + (window.location.port ? ':' + window.location.port : '');
    }
    window.open(origin + window.location.pathname);
};
function getDiagramFileName(dialogName) {
    if (dialogName === 'export')
        return document.getElementById('diagramName').innerHTML.toString();
    if (dialogName === 'save')
        return document.getElementById('diagramName').value.toString();
    else
        return document.getElementById('diagramName').innerHTML.toString();
}

function downloadPdf(base64String, fileName) {
    var sliceSize = 512;
    var byteCharacters = atob(base64String);
    var byteArrays = []; for (var offset = 0; offset < byteCharacters.length; offset += sliceSize) {
        var slice = byteCharacters.slice(offset, offset + sliceSize);
        var byteNumbers = new Array(slice.length); for (var i = 0; i < slice.length; i++) {
            byteNumbers[i] = slice.charCodeAt(i);
        } var byteArray = new Uint8Array(byteNumbers);
        byteArrays.push(byteArray);
    } var blob = new Blob(byteArrays, {
        type: 'application/pdf'
    });
    var blobUrl = window.URL.createObjectURL(blob);
    this.triggerDownload("PDF", fileName, blobUrl);
}
triggerDownload: function triggerDownload(type, fileName, url) {
    var anchorElement = document.createElement('a');
    anchorElement.download = fileName + '.' + type.toLocaleLowerCase();
    anchorElement.href = url;
    anchorElement.click();
}

function saveDiagram(data, filename) {
    if (window.navigator.msSaveBlob) {
        let blob = new Blob([data], { type: 'data:text/json;charset=utf-8,' });
        window.navigator.msSaveOrOpenBlob(blob, filename + '.json');
    } else {
        let dataStr = 'data:text/json;charset=utf-8,' + encodeURIComponent(data);
        let a = document.createElement('a');
        a.href = dataStr;
        a.download = filename + '.json';
        document.body.appendChild(a);
        a.click();
        a.remove();
    }
}
UtilityMethods_hideElements = function (elementType, diagramType) {
    var diagramContainer = document.getElementsByClassName('diagrambuilder-container')[0];
    if (diagramContainer.classList.contains(elementType)) {
        if (!(diagramType === 'mindmap-diagram' || diagramType === 'orgchart-diagram')) {
            diagramContainer.classList.remove(elementType);
        }
    }
    else {
        diagramContainer.classList.add(elementType);
    }
};
function hideMenubar() {
    UtilityMethods_hideElements('hide-menubar');
}
function getHyperLinkValueFromDocument(id, attribute) {
    return document.getElementById(id).value;
}
function click() {
    document.getElementById('UploadFiles').click();
}
function hideElements(elementType) {
    var diagramContainer = document.getElementsByClassName('diagrambuilder-container')[0];
    if (diagramContainer.classList.contains(elementType)) {
        diagramContainer.classList.remove(elementType);
    } else {
        diagramContainer.classList.add(elementType);
    }
}
//function click() {
//    document.getElementById('defaultfileupload').click();
//}
function loadFile(file) {
    var base64 = file.rawFile.replace("data:application/json;base64,", "");
    var json = atob(base64)
    return json;
}
function loadDiagram(event) {
    return event.target.result.toString();
}
