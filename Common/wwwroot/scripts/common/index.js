var isScrolled = false; 
var isUpdatedDevice = false;
var isTouchEnabled = false;
const DEFAULT_THEME = 'tailwind3';
var dotnetTooltipRef;
var currentURL;
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
  isScreenWide: function () {
        return screen.availWidth >= 2160;
    },
    containsTouchModeClass: function () {
        return document.body.classList.contains('e-bigger');
    },
    addTouchModeClass: function () {
         document.body.classList.add('e-bigger');
    },
    removeTouchModeClass: function () {
        document.body.classList.remove('e-bigger');
    },
    jsReload: function () {
        window.location.reload();
    },
    // To get and set value in local storage for localization
    getValue: function (key) {
        return localStorage[key]
    },

    setValue: function (key, value) {
        localStorage[key] = value;
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
            var item = document.getElementsByClassName('sf-search-hover');
            if (item.length > 0) {
                item[0].scrollIntoView({ behavior: "smooth", block: "nearest" });
            }
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

function isSelectorFromPoint(left, top, selector) {
    var targetElement = document.elementFromPoint(left, top);
    if (targetElement != null) {
        var closest = targetElement.closest("." + selector) ? true : false;
        return closest;
    }
    return false;
}

var resizevalue = true;
function callResizeEvent() {
    resizevalue = false;
    //Due to facing issue with DocumentEditor component resizing on sidebar collapse/expand, enclosed the dispatch event within setTimeout.
    setTimeout(() => { window.dispatchEvent(new Event('resize')); resizevalue = true; }, 300);
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

//card component expand card sample function for focuing element
function setFocusToElement(element) {
  element.focus();
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
            else if (ele.classList.contains('e-toolbar')) {
              ele = ele.querySelector('.e-toolbar-items .e-toolbar-item .e-tbar-btn');
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
            else if (ele.classList.contains('e-uploader')) {
              ele = ele.parentElement.parentElement.firstChild;
            }
            else if (ele.classList.contains('e-treeview')) {
                ele = ele.querySelector("li");
            }
        }
        focusElement(ele);
    }
});

window.addEventListener('load', function () {

    const Theme_integrity = {
        "material3" : "sha384-P6zhSzNCSpZ2fXYaBw41sRJS5i8ys9cnDOw3IM5xai8auKFvd1Bvm4+5J4V/mGQ0",
        "material3-dark": "sha384-VdDAFg30AEKCAIKlBkxZ4nozm4TAEBBdE4D1o+ufQdnS8/bvGYyPSxdNr5z7xnRV",
        "fluent": "sha384-GITa1XWIFWoZpomL5pP/L49KnvRv4zQxKtpYtJJurL1Qbsv1K74t4ICuipaB++IE",
        "fluent-dark":"sha384-xvQFD2gPmxm3XCXDUCxH9+PTBnWa+Jg8XEO5/Uj0NxxdZZHPV9Un/lqTr3MFyeiK",
        "fluent2": "sha384-wwx/wkfkugAYS1p8AhlzxJp2DaI/bM9AzJEMJpssRdDdEjW0GJmugo+9pQsfSFtH",
        "fluent2-dark": "sha384-9xEB+TijTR0r72TJpLiDEJ2jWx8xz9G+q6UyZfZ5Jbg4mwkTgzKeuuHupjZXAYnS",
        "bootstrap5.3": "sha384-M3uzTXLjbiGvxr/+Jv/qf1AbJX6eXpAwMP5UV8MO4o2uTjawmhzDYTzrjaNY359N",
        "bootstrap5.3-dark": "sha384-7Jcz2KF5x0EoMuiuOM62Aq2GWBRyHwJkNem3/+srKEZ3RhbfqJjE7DzGcckaow31",
        "tailwind": "sha384-2PClT36mZOJJANif7K+S0PyJekY4a18sFJGvuJCLEECF+rYD7XEcL0lN2ld87T4d",
        "tailwind-dark": "sha384-9sAG0Yq8wu0SZbfmNIqH3DR+ImK0k3m2a0pFsIvazG+XvWMud2kxlFw5fJn2KS1C",
        "highcontrast": "sha384-p80ERM5BibxvsqrOzZqL7StKRqxeXQCBNKhmQY4Ua5/GhrA1iO6dX1Bllc4GVLiF",
        "fluent2-highcontrast": "sha384-PjhVi53JYUezDd+ffataBbXMeXqEN+V0twJEppXce4/aNy+5msLkyQQjMWvJ7Fg+"
    };


  //To replace theme in Link Tag for WASM and MAUI
    let ThemeEle = document.getElementById('theme');
    if (ThemeEle) {
        let url = window.location.href.split("?theme=");
        let theme = new URL(window.location.href).searchParams.get("theme"); 
        theme = theme === "bootstrap5" ? "bootstrap5.3" : theme === "bootstrap5-dark" ? "bootstrap5.3-dark" :theme;
            if (url.length > 1) {
                if (ThemeEle.href.indexOf("cdn.syncfusion.com") !== -1) {
                    ThemeEle.removeAttribute('integrity');
                    ThemeEle.href = 'https://cdn.syncfusion.com/blazor/27.1.48/styles/' + theme + '.css';
                   ThemeEle.setAttribute('integrity', Theme_integrity[theme]);
                }
                else {
                    ThemeEle.href = '_content/Syncfusion.Blazor.Themes/' + theme + '.css';
                }

            }
    }

  // Add mobile class to the body element for device rendering.
  if (sfBlazorSB.isDeviceMode()) {
    document.body.classList.add("mobile");
    }

  // Add current theme name to the body element.
  var themeName = DEFAULT_THEME;
  if (/theme=/g.test(location.search)) {
    themeName = location.search.replace("?theme=", "");
    }
    themeName = themeName === "bootstrap5" ? "bootstrap5.3" : themeName === "bootstrap5-dark" ? "bootstrap5.3-dark" : themeName;
    var sfPreferenceMode = localStorage.getItem("sfPreferenceMode");
    document.body.classList.add(themeName);
    if (sfPreferenceMode === "touch") {
        document.body.classList.add("e-bigger");
    }
    // Call the function to update button text on page load
   
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
    document.getElementsByClassName('e-pv-sidebar-toolbar-splitter')[0].style.width = '0px';
    viewer.thumbnailView.openThumbnailPane(true);
};

function beforeApplyFormat() {
  var currentRange = sfBlazor.instances["mentionFormatIntegration"].getRange();
  var node = sfBlazor.instances["mentionFormatIntegration"].formatter.editorManager.nodeSelection.getNodeCollection(currentRange)[0];
  var startPoint = currentRange.startOffset;
  while (sfBlazor.instances["mentionFormatIntegration"].formatter.editorManager.nodeSelection.getRange(document).toString().indexOf("/") == -1)
  {
      sfBlazor.instances["mentionFormatIntegration"].formatter.editorManager.nodeSelection.setSelectionText(document, node, node, startPoint, currentRange.endOffset)
      startPoint--;
  }
 // sfBlazor.instances["mentionFormatIntegration"].formatter.editorManager.nodeSelection.setSelectionText(document, node, node, range1.startOffset - 1, range1.endOffset);
  var slashRange = sfBlazor.instances["mentionFormatIntegration"].getRange();
  var slashNode = sfBlazor.instances["mentionFormatIntegration"].formatter.editorManager.nodeCutter.GetSpliceNode(slashRange, node);
  var previouNode = slashNode.previousSibling;
const brTag = document.createElement('br');
    if ( slashNode.parentElement && slashNode.parentElement.innerHTML.length === 1) {
        slashNode.parentElement.appendChild(brTag);
    }
  slashNode.parentNode.removeChild(slashNode);
  var selection = sfBlazor.instances["mentionFormatIntegration"].formatter.editorManager.nodeSelection.save(slashRange, document);
  if (previouNode) {
      selection.setCursorPoint(document, previouNode, previouNode.textContent.length);
  }
}

function onInsertEmotSlashRemove() {
    beforeApplyFormat(null, false);
}



function loadPdf2Script() {
    return new Promise(function (resolve, reject) {
        let script = document.createElement('script');
        script.src = "_content/Syncfusion.Blazor.SfPdfViewer/scripts/syncfusion-blazor-sfpdfviewer.min.js";
        script.onload = function () {
            resolve(); // Resolve the promise when the script has loaded successfully
        };
        script.onerror = function (error) {
            reject(error); // Reject the promise if there's an error loading the script
        };
        document.getElementsByClassName('dynamic-resources')[0].appendChild(script);
    });
}


function loadWordScript() {
    return new Promise(function (resolve, reject) {
        let script = document.createElement('script');
        script.src = "_content/Syncfusion.Blazor.WordProcessor/scripts/syncfusion-blazor-documenteditor.min.js";
        script.onload = function () {
            resolve(); // Resolve the promise when the script has loaded successfully
        };
        script.onerror = function (error) {
            reject(error); // Reject the promise if there's an error loading the script
        };
        document.getElementsByClassName('dynamic-resources')[0].appendChild(script);
    });
}

function created() {
  document.getElementById('pdfviewer_open').addEventListener('click', function () {
      document.querySelector('.e-upload-browse-btn').click()
  })
}

function changeFocus() {
        const activeElement = document.activeElement;
        if (activeElement) {
            activeElement.blur();
        }
        var pdfViewerContainer = document.getElementById('pdfviewer_section');
        if (pdfViewerContainer) {
            pdfViewerContainer.focus();
        }
}

function createdBrowsebutton() {
    document.getElementById('browseButton').addEventListener('click', function () {
        document.querySelector('.e-upload-browse-btn').click()
    })
}

function onSelect(args) {
    let extensions = ['doc', 'docx', 'rtf', 'docm', 'dotm', 'dotx', 'dot', 'xls', 'xlsx', 'pptx', 'pptm', 'potx', 'potm', 'jpeg', 'png', 'bmp', 'pdf'];
    var progressRef = document.getElementById("progress-container");
    progressRef.value = 0;
    let progressBarContainer = document.getElementById("progressbarContainer");
    let progressBar = document.getElementById("linearProgressBar");
    let progressMessage = document.getElementById("uploadedMessage");
    let fileSizeValidation = document.getElementById("fileSizeValidation");
    document.getElementById("fileDetails").style.display = "block";
    document.getElementById("FailedMessage").style.display = "none";
    progressBarContainer.style.display = "block";
    progressBar.style.display = "flex";
    progressMessage.style.display = "none";
    fileSizeValidation.style.display = "none";
    document.getElementById("pdfviewer").style.display = "block";
    var validFiles = args.filesData;
    if (validFiles.length === 0) {
        progressBarContainer.style.display = "block";
        progressBar.style.display = "none";
        progressMessage.style.display = "block";       
        args.cancel = true;
        return true;
    }
    if (!extensions.includes(validFiles[0].type)) {
        document.getElementById("FailedMessage").style.display = "block";
        document.getElementById("fileDetails").style.display = "none";
        document.getElementById("pdfviewer").style.display = "none";
        document.getElementById("uploadedMessage").style.display = "none";        
        progressBar.style.display = "none";
        progressMessage.style.display = "none";
        args.cancel = true;
        return true;
    }
    if (validFiles[0].type != "pdf" && validFiles[0].size > 4000000) {
        fileSizeValidation.style.display = "block";
        document.getElementById("fileDetails").style.display = "none";
        document.getElementById("pdfviewer").style.display = "none";
        document.getElementById("uploadedMessage").style.display = "none";        
        progressBar.style.display = "none";
        progressMessage.style.display = "none";
        args.cancel = true;
        return true;
    }      
    document.getElementById("fileName").innerHTML = args.filesData[0].name;
    let size = document.getElementById("fileSize");
    if ((args.filesData[0].size.toString()).length <= 6) {
        size.innerHTML = ((args.filesData[0].size / 1024).toFixed(1)).toString() + " KB";
    } else {
        let kbsize = args.filesData[0].size / 1024;
        size.innerHTML = ((kbsize / 1024).toFixed(1)).toString() + " MB";
    }
    return false;
}

function showMessage() {
   
    setTimeout(() => {
        document.getElementById("linearProgressBar").style.display = "none";
        document.getElementById("uploadedMessage").style.display = "block";        
    }, 1000);

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
function openPalette() {
    var paletteSpace = document.getElementById("palette-space");
    if (!paletteSpace.classList.contains("sb-mobile-palette-open")) {
        paletteSpace.classList.add("sb-mobile-palette-open");
    } else {
        paletteSpace.classList.remove("sb-mobile-palette-open");
    }
}

window.addEventListener("resize", detectLayoutChange);
function detectLayoutChange() {
    var isMobileLayout = window.matchMedia("(max-width:550px)").matches;
    var paletteSpace = document.getElementById("palette-space");
    if (!isMobileLayout) {
        if (paletteSpace && paletteSpace.classList.contains("sb-mobile-palette-open")) {
            paletteSpace.classList.remove("sb-mobile-palette-open");
        }
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
function ScrollToSelected() {
  const selectedDiv = document.querySelector('.sf-list .sf-list-li-active');
    if (selectedDiv) {
        selectedDiv.scrollIntoView({ block: 'nearest' });
  }
  const selectedComponent = document.querySelector('.sf-tree-parent .sf-tree-active');
  if (selectedComponent) {
      selectedComponent.scrollIntoView({ block: 'nearest' });
  }
}

var updatedURL;
var currentURL;

function updateThemeURL() {
    const themeParameter = "tailwind3";
    currentURL = window.location.href;
    if (!currentURL.includes("?")) {
        // URL does not contain a query string
        // Add the theme parameter with "?" prefix
        currentURL=`${currentURL}?theme=${themeParameter}`;
    }
    //  var currentURL = window.location.href;
    if (currentURL.includes("?")) {
        var urlParts = currentURL.split("?");
        var baseUrl = urlParts[0];
        var queryString = urlParts[1];
        var params = new URLSearchParams(queryString);

        if (params.has("theme")) {
            var themeValue = params.get("theme");
            var themeParts = themeValue.split("-");

            // Extracting the theme name without the "-dark" suffix
            var themeName = themeParts[0]; 
            if (themeName !== "highcontrast") {
                // Check if the URL already contains "-dark"
                if (!currentURL.includes("-dark")) {
                    // Append "-dark" to the current URL
                    // Append "-dark" to the current URL
                    updatedURL = currentURL + "-dark";
                } else if (currentURL.includes("-dark")) {
                    // Remove "-dark" from the current URL
                    updatedURL = currentURL.replace("-dark", "");
                }
            } else {
                //console.log("Theme is already fluent, no update needed");
            }
        } else {
            //console.log("No theme parameter found in the URL");
        }
    } else {
        //console.log("No query parameter found in the URL");
    }
   // Return the updated URL or current URL if no update is needed
    return updatedURL;
}

function navigateToPage() {
    var updatedURL = updateThemeURL();
    if (updatedURL) {
      // Replace the current URL without reloading the page
        window.location.href = updatedURL;
    }

}

function updateButtonTheme() {
    var currentURL = window.location.href;
    if (currentURL.includes("-dark")) {
        document.getElementById("buttoncolor").style.color = "#FFFFFF";
        document.getElementById("darkThemeIcon").style.display = "none";
        document.getElementById("lightThemeIcon").style.display = "inline-block";
        document.getElementById("themeSwitch").textContent = "Light";
        document.getElementById("themeSwitch").style.marginLeft = "4px";
    } else {
        document.getElementById("buttoncolor").style.color = "#000";
        document.getElementById("lightThemeIcon").style.display = "none";
        document.getElementById("darkThemeIcon").style.display = "inline-block";
        document.getElementById("themeSwitch").textContent = "Dark";
        document.getElementById("themeSwitch").style.marginLeft = "2px";
    }
    highContrast();
}
window.addEventListener('DOMContentLoaded', updateButtonTheme);
function highContrast() {
    // Check if the URL ends with "highcontrast"
    if (window.location.href.endsWith("highcontrast")) {
        // Get the div element by its id
        var themeSwitchDiv = document.getElementById("themeSwitchDiv");
        // Hide the div by setting its display property to "none"
        themeSwitchDiv.style.display = "none";
    }
}

function closeTooltipPopup(methodName) {
    const scrollableDiv = document.getElementById("right-pane");
     function scrollHandler() {
        if (currentURL !== window.location.href) {
            scrollableDiv.removeEventListener("scroll", scrollHandler);
            dotnetTooltipRef = null;
        }
        if (dotnetTooltipRef) {
            dotnetTooltipRef.invokeMethodAsync(methodName);
        }
    };
    scrollableDiv.addEventListener("scroll",scrollHandler);
}

function getInstance(tooltipInstance) {
    currentURL = window.location.href;
    dotnetTooltipRef = tooltipInstance;
}

function disposeDotnetTooltipRef() {
    dotnetTooltipRef = null;
}

var visiblevalue = false;
function toggleSidebarVisibility() {
    var sidebar = document.querySelector('.sf-sidebar');
    var Is_sidebar_expand = ((document.querySelector('.sf-sidebar-right-pane-expand') !== undefined) && (document.querySelector('.sf-sidebar-right-pane-expand') !== null));
    // Toggle sidebar visibility based on window width
    if (Is_sidebar_expand  && sidebar && resizevalue && window.innerWidth < 1026) {
        visiblevalue = true;
        sidebar.classList.remove('sf-visible');
        sidebar.classList.add('sf-hidden');
    }
    else if (!Is_sidebar_expand  && sidebar && visiblevalue &&resizevalue && window.innerWidth >= 1026) {
        visiblevalue = false;
        sidebar.classList.remove('sf-hidden');
        sidebar.classList.add('sf-visible');
    }
}

window.addEventListener('resize', toggleSidebarVisibility);
document.addEventListener('DOMContentLoaded', function () {
    var sidebar = document.querySelector('.sb-toggle-left');
    if (sidebar && sidebar.classList.contains('sf-hidden')) {
        sidebar.addEventListener('click', function () {
            sidebar.classList.remove('sf-hidden');
            sidebar.classList.add('sf-visible');
        });
    }
    else if (sidebar && sidebar.classList.contains('sf-visible')) {
        sidebar.addEventListener('click', function () {
            sidebar.classList.add('sf-hidden');
            sidebar.classList.remove('sf-visible');
        });
    }
});

document.addEventListener('keydown', function (e) {
    if (e.keyCode === 27) {
        var preference_popup = document.querySelector(".sf-preferences-popup");
        var theme_popup = document.querySelector(".sf-dropdown-popup");
        if (!preference_popup.classList.contains("sb-hide")) {
            preference_popup.classList.add("sb-hide");
        } 
        if (!theme_popup.classList.contains("sb-hide")) {
            theme_popup.classList.add("sb-hide");
        }
    }
});

// AIPdf viewer scripts
function isMobileDevice(isRtl) {
    //Check if the device is mobile
    var isMobile = this.sfBlazor.isDevice(isRtl)
    var sampleContent = document.querySelector('.sample-content')
    if (isMobile) {
        var sampleContentRect = sampleContent.getBoundingClientRect();
        var sampleContentMinWidth = 425;
        if (sampleContentRect && ((sampleContentRect.width) > sampleContentMinWidth)) {
            return false;
        } else {
            return true;
        }
    }
    return isMobile;
}

function checkClickedDiv() {
    //Check the clicked div is the child of ViewerContainer
    var activeElement = document.activeElement;
    var viewerContainer = document.querySelector('.e-pv-viewer-container');
    return viewerContainer.contains(activeElement);
}
function created() {
    document.getElementById('pdfviewer_open').addEventListener('click', function () {
        document.querySelector('.e-upload-browse-btn').click()
    })
}

function mapSearchValue(viewerId) {
    var customSearchInput = document.getElementById('textbox');
    var pdfViewerSearchInput = document.getElementById(viewerId + '_search_input');

    if (customSearchInput !== null && pdfViewerSearchInput !== null) {
        customSearchInput.addEventListener('input', () => {
            pdfViewerSearchInput.value = customSearchInput.value;
        });
    }
}

//SmartRedact scripts - AIPdfviewer

function created() {
    document.getElementById('pdfviewer_open').addEventListener('click', function () {
        document.querySelector('.e-upload-browse-btn').click()
    })
}
function isMobileDevice(isRtl) {
    //Check if the device is mobile
    var isMobile = this.sfBlazor.isDevice(isRtl)
    var sampleContent = document.querySelector('.sample-content')
    if (isMobile) {
        var sampleContentRect = sampleContent.getBoundingClientRect();
        var sampleContentMinWidth = 425;
        if (sampleContentRect && ((sampleContentRect.width) > sampleContentMinWidth)) {
            return false;
        } else {
            return true;
        }
    }
    return isMobile;
}
function checkClickedDiv() {
    //Check the clicked div is the child of ViewerContainer
    var activeElement = document.activeElement;
    var viewerContainer = document.querySelector('.e-pv-viewer-container');
    return viewerContainer.contains(activeElement);
}

//Summarizer scripts - AIPdfviewer
function goToPage(referenceNumber) {
    if (window.dotNetObject) {

        if (typeof referenceNumber === 'string') {
            const match = referenceNumber.match(/\d+/);
            referenceNumber = parseInt(match[0], 10);
        }
        window.dotNetObject.invokeMethodAsync('GoToPage', referenceNumber)
            .then(() => {
                console.log('GoToPage called successfully.');
            })
            .catch(error => {
                console.error('Error calling GoToPage:', error);
            });

    } else {
        console.error('dotNetObject is not defined.');
    }
}
function isMobileDevice(isRtl) {
    //Check if the device is mobile
    var isMobile = this.sfBlazor.isDevice(isRtl)
    return isMobile;
}
window.initializeJSInterop = function (dotNetObject) {
    // Store the reference globally or in your desired scope
    window.dotNetObject = dotNetObject;
}

    //Smart Ai Diagram scripts start 

function getDiagramFileName(dialogName) {
    if (dialogName === 'export')
        return document.getElementById('diagramName').innerHTML.toString();
    if (dialogName === 'save')
        return document.getElementById('saveFileName').value.toString();
    else
        return document.getElementById('diagramName').innerHTML.toString();
}
function importDescription(formatName) {
    if (formatName === 'CSV') {
        document.getElementById('descriptionText1').innerHTML = "Make sure that each column of the table has a header";
        document.getElementById('descriptionText2').innerHTML = "Each employee should have a reporting person (except the top most employee of the organization), and it should be indicated by any field from the data source.";

    }
    else if (formatName == 'XML') {
        document.getElementById('descriptionText1').innerHTML = "Make sure that XML document has a unique root element and start-tags have matching end-tags.";
        document.getElementById('descriptionText2').innerHTML = "All XML elements will be considered employees and will act as a reporting person for its child XML elements.";

    }
    else {
        document.getElementById('descriptionText1').innerHTML = "Make sure that you have defined a valid JSON format.";
        document.getElementById('descriptionText2').innerHTML = "Each employee should have a reporting person (except the top most employee of the organization), and it should be indicated by any field from the data source.";
    }

}

function getWindowHeight() {
    const viewportHeight = window.innerHeight - 75;
    return viewportHeight;
}
importData = function (object) {
    var orgDataSource = []; var columnsList = []
    orgDataSource = JSON.parse(object);
    var dada = orgDataSource[0];
    for (var prop in dada) { columnsList.push(prop) }
    return columnsList
};

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
function loadFile(file) {
    var base64 = file.rawFile.replace("data:application/json;base64,", "");
    var json = atob(base64)
    return json;
}

function downloadFile(data, filename) {
    let dataString = 'data:text/json;charset=utf-8,' + encodeURIComponent(data);
    let anchorElement = document.createElement('a');
    anchorElement.href = dataString;
    anchorElement.download = filename + '.json';
    document.body.appendChild(anchorElement);
    anchorElement.click();
    anchorElement.remove();
}
UtilityMethods_hideElements = function (elementType, diagramType) {
    var diagramContainer = document.getElementsByClassName('diagrambuilder-container')[0];
    if (diagramContainer.classList.contains(elementType)) {
        if (!(diagramType === 'mindmap-diagram')) {
            diagramContainer.classList.remove(elementType);
        }
    }
    else {
        diagramContainer.classList.add(elementType);
    }
    if (diagramType) {
        diagramContainer.classList.remove(elementType);
    }
    window.dispatchEvent(new Event('resize'));
    const windowHeight = getWindowHeight();
    return windowHeight;
};
function hideMenubar() {
    UtilityMethods_hideElements('hide-menubar');
}

click = function () {
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

function getElementFromPoint(x, y) {
    return document.elementFromPoint(x, y);
}
UtilityMethods_native = function (object) {
    var selectedItems = JSON.parse(object);
    console.log(selectedItems);
};
function pageSizeUpdate() {
    window.dispatchEvent(new Event('resize'));
}

window.downloadPdf = function downloadPdf(base64String, fileName) {
    var sliceSize = 512;
    var byteCharacters = atob(base64String);
    var byteArrays = [];

    for (var offset = 0; offset < byteCharacters.length; offset += sliceSize) {
        var slice = byteCharacters.slice(offset, offset + sliceSize);
        var byteNumbers = new Array(slice.length);

        for (var i = 0; i < slice.length; i++) {
            byteNumbers[i] = slice.charCodeAt(i);
        }

        var byteArray = new Uint8Array(byteNumbers);
        byteArrays.push(byteArray);
    }

    var blob = new Blob(byteArrays, {
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
function getViewportBounds() {
    var bounds = document.getElementsByClassName('e-control e-diagram e-lib e-droppable e-tooltip')[0].getBoundingClientRect();
    return { width: bounds.width, height: bounds.height };

}
window.preventTabDefault = function (textareaId, dotnetRef) {
    const textarea = document.getElementById(textareaId);
    if (textarea)
        textarea.addEventListener('keydown', function (e) {
            const spaceSize = 5;
            const spaces = ' '.repeat(spaceSize);
            const tabCharacter = '\t';
            const isTab = this.value.includes(tabCharacter);
            if (e.key === 'Tab') {
                e.preventDefault();
                const start = this.selectionStart;
                const value = this.value;

                // Find the current line starting position
                const lineStart = value.lastIndexOf('\n', start - 1) + 1;
                const lineEnd = value.indexOf('\n', start);
                const lineContent = value.substring(lineStart, lineEnd === -1 ? value.length : lineEnd);

                if (e.shiftKey) {
                    // Removing indentation
                    if (lineContent.startsWith(isTab ? tabCharacter : spaces)) {
                        const removeLength = isTab ? 1 : spaces.length;
                        this.value = value.substring(0, lineStart) + value.substring(lineStart + removeLength);
                        this.selectionStart = this.selectionEnd = start - removeLength;
                    }
                } else {
                    // Adding indentation
                    const indent = isTab ? tabCharacter : spaces;
                    this.value = value.substring(0, lineStart) + indent + value.substring(lineStart);
                    this.selectionStart = this.selectionEnd = start + indent.length;
                }
                dotnetRef.invokeMethodAsync('UpdateTextValue', this.value);
            }
            else if (e.key === 'Enter') {
                e.preventDefault();
                const start = this.selectionStart;
                const end = this.selectionEnd;

                // Getting current line's indentation
                const currentLineStart = this.value.lastIndexOf('\n', start - 1) + 1;
                const currentLineIndentation = this.value.substring(currentLineStart, start).match(/^\s*/)[0];

                // Insert a newline followed by the current line's indentation
                const newText = '\n' + currentLineIndentation;
                this.value = this.value.substring(0, start) + newText + this.value.substring(end);

                // Updating cursor position
                this.selectionStart = this.selectionEnd = start + newText.length;
                dotnetRef.invokeMethodAsync('UpdateTextValue', this.value);
            } else if (e.key === 'Backspace') {
                const start = this.selectionStart;
                const end = this.selectionEnd;
                const currentLineStart = this.value.lastIndexOf('\n', start - 1) + 1;
                const currentLineIndentation = this.value.substring(currentLineStart, start);

                if (currentLineIndentation.endsWith(spaces)) {
                    e.preventDefault();
                    // Removing indentation level
                    this.value = this.value.substring(0, start - spaceSize) + this.value.substring(end);
                    this.selectionStart = this.selectionEnd = start - spaceSize;
                    dotnetRef.invokeMethodAsync('UpdateTextValue', this.value);
                }
            }
        });
}

//Diagram scripts end 

// Document Editor Scripts start

window.setDialogDivHeight = (element) => {
    var qusElement = document.getElementById('e-de-qus-pane');
    var ansElement = document.getElementById('e-de-editableDiv');
    if (element === 'Generate' && ansElement) {
        ansElement.style.height = '100px';
    } else if (qusElement && ansElement) {
        qusElement.style.height = '75px';
        ansElement.style.height = '75px';
    }
}
window.getTextContent = () => {
    var element = document.getElementById('e-de-editableDiv');
    if (element) {
        return element.textContent ? element.textContent.trim() : '';
    }
};
window.getHtmlContent = () => {
    var element = document.getElementById('e-de-editableDiv');
    if (element) {
        return element.innerHTML;
    }
};
window.setTextContent = (text) => {
    var element = document.getElementById('e-de-editableDiv');
    if (element) {
        element.textContent = text;
    }
};
window.setHtmlContent = (html) => {
    var element = document.getElementById('e-de-editableDiv');
    if (element) {
        element.innerHTML = html;
    }
};
 window.clearDivContent = () => {
    var element = document.getElementById('e-de-editableDiv');
    if (element) {
        element.innerHTML = '';
    }
};
window.setPlaceholder = (placeholderText) => {
    var element = document.getElementById('e-de-editableDiv');
    if (element && element.innerText.trim() === '') {
        element.innerText = placeholderText;
        element.classList.add('placeHoldr');
    }
};
window.removePlaceholder = (placeholderText) => {
    var element = document.getElementById('e-de-editableDiv');
    if (element) {
        if (element.innerText === placeholderText) {
            element.innerText = '';
            element.classList.remove('placeHoldr'); 
        }
    }
};

// Smart Editor AI Sample in Document Editor
window.showElements = (ids) => {
    ids.forEach(id => {
        const element = document.getElementById(id);
        if (element) {
            element.style.display = 'block';
        }
    });
}
window.hideElements = (ids) => {
    ids.forEach(id => {
        const element = document.getElementById(id);
        if (element) {
            element.style.display = 'none';
        }
    });
}
// Smart Editor sample script ends

// Summarization Sample script starts
window.getDivHeight = (elementId) => {
    var element = document.getElementById(elementId);
    if (element) {
        return (element.clientHeight).toString() + 'px';
    }
    return '150%';
}

window.copyToClipboard = function (content) {
    const type = "text/html";
    const blob = new Blob([content], { type });
    const data = [new ClipboardItem({ [type]: blob })];
    navigator.clipboard.write(data);
}
// Summarization sample script ends

window.getDivHeight = (elementId) => {
    var element = document.getElementById(elementId);
    if (element) {
        return (element.clientHeight).toString() + 'px';
    }
    return '150%';
}

window.copyToClipboard = function (content) {
    const type = "text/html";
    const blob = new Blob([content], { type });
    const data = [new ClipboardItem({ [type]: blob })];
    navigator.clipboard.write(data);
}
// Summarization sample script ends
// Document Editor Script Ends

// Rich Text Editor AI sample script starts

function copyToClipboard(text) {
    const tempElement = document.createElement('div');
    tempElement.innerHTML = text;
    document.body.appendChild(tempElement);

    // Select the content of the temporary element
    const range = document.createRange();
    range.selectNodeContents(tempElement);
    const selection = window.getSelection();
    selection.removeAllRanges();
    selection.addRange(range);

    // Execute the copy command
    try {
        const successful = document.execCommand('copy');
        if (successful) {
            console.log('HTML copied to clipboard!');
        } else {
            console.log('Failed to copy HTML.');
        }
    } catch (err) {
        console.error('Error copying HTML to clipboard: ', err);
    }

    // Clean up by removing the temporary element
    document.body.removeChild(tempElement);
    selection.removeAllRanges();
}

// Rich Text Editor sample script ends

// Scheduler AI samples script starts

window.copyToClipboard = function (text) {
    var textarea = document.createElement("textarea");
    textarea.value = text;
    document.body.appendChild(textarea);
    textarea.select();
    document.execCommand('copy');
    document.body.removeChild(textarea);
}

window.clickButton = function (buttonClass) {
    document.querySelector("." + buttonClass).click();
}

// Scheduler AI sample script ends
