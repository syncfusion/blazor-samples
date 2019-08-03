
var currentPageBox
var matchCase = false;
var filename;
function localeFunction() {
    ej.base.L10n.load({
        'ar-AE': {
            'PdfViewer': {
                'PdfViewer': 'قوات الدفاع الشعبي المشاهد',
                'Cancel': 'إلغاء',
                'Download file': 'تحميل الملف',
                'Download': 'تحميل',
                'Enter Password': 'هذا المستند محمي بكلمة مرور. يرجى إدخال كلمة مرور.',
                'File Corrupted': 'ملف تالف',
                'File Corrupted Content': 'الملف تالف ولا يمكن فتحه.',
                'Fit Page': 'لائق بدنيا الصفحة',
                'Fit Width': 'لائق بدنيا عرض',
                'Automatic': 'تلقائي',
                'Go To First Page': 'عرض الصفحة الأولى',
                'Invalid Password': 'كلمة سر خاطئة. حاول مرة اخرى.',
                'Next Page': 'عرض الصفحة التالية',
                'OK': 'حسنا',
                'Open': 'فتح الملف',
                'Page Number': 'رقم الصفحة الحالية',
                'Previous Page': 'عرض الصفحة السابقة',
                'Go To Last Page': 'عرض الصفحة الأخيرة',
                'Zoom': 'تكبير',
                'Zoom In': 'تكبير في',
                'Zoom Out': 'تكبير خارج',
                'Page Thumbnails': 'مصغرات الصفحة',
                'Bookmarks': 'المرجعية',
                'Print': 'اطبع الملف',
                'Password Protected': 'كلمة المرور مطلوبة',
                'Copy': 'نسخ',
                'Text Selection': 'أداة اختيار النص',
                'Panning': 'وضع عموم',
                'Text Search': 'بحث عن نص',
                'Find in document': 'ابحث في المستند',
                'Match case': 'حالة مباراة',
                'Apply': 'تطبيق',
                'GoToPage': 'انتقل إلى صفحة',
                // tslint:disable-next-line:max-line-length
                'No matches': 'انتهى العارض من البحث في المستند. لم يتم العثور على مزيد من التطابقات',
                'No Text Found': 'لم يتم العثور على نص',
                // tslint:disable-next-line:max-line-length
                'Server error': 'خدمة الانترنت لا يستمع. يعتمد قوات الدفاع الشعبي المشاهد على خدمة الويب لجميع ميزاته. يرجى بدء خدمة الويب للمتابعة.',
                'Undo': 'فك',
                'Redo': 'فعل ثانية',
                'Annotation': 'إضافة أو تعديل التعليقات التوضيحية',
                'Highlight': 'تسليط الضوء على النص',
                'Underline': 'تسطير النص',
                'Strikethrough': 'نص يتوسطه خط',
                'Delete': 'حذف التعليق التوضيحي',
                'Opacity': 'غموض',
                'Color edit': 'غير اللون',
                'Opacity edit': 'تغيير التعتيم',
                'highlight': 'تسليط الضوء',
                'underline': 'أكد',
                'strikethrough': 'يتوسطه',

                'Open text': 'افتح',
                'First text': 'الصفحة الأولى',
                'Previous text': 'الصفحة السابقة',
                'Next text': 'الصفحة التالية',
                'Last text': 'آخر صفحة',
                'Zoom in text': 'تكبير',
                'Zoom out text': 'تصغير',
                'Selection text': 'اختيار',
                'Pan text': 'مقلاة',
                'Print text': 'طباعة',
                'Seach text': 'بحث',
                'Annotation Edit text': 'تحرير التعليق التوضيحي'

            }
        }
    });
}
function openPage() {
    document.getElementById('fileUpload').click();
}
function readFile(evt) {
    var upoadedFiles = evt.target.files;
    var uploadedFile = upoadedFiles[0];
    filename = upoadedFiles[0].name;
    var reader = new FileReader();
    reader.readAsDataURL(uploadedFile);
    reader.onload = function () {
        var obj = document.getElementById('pdfviewer').ej2_instances[0];
        var uploadedFileUrl = this.result;
        obj.load(uploadedFileUrl, null);
        obj.fileName = filename;
        currentPageBox = document.getElementById('currentPage');
        currentPageBox.value = '1';
        var pageCount = document.getElementById('totalPage');
        pageCount.textContent = 'of ' + obj.pageCount;
    }
}
function pageChanged() {
    var pdfViewer = document.getElementById('pdfviewer').ej2_instances[0];
    document.getElementById('currentPage').value = pdfViewer.currentPageNumber;
    updatePageNavigation();
}
function onCurrentPageBoxKeypress(event) {
    var pdfViewer = document.getElementById('pdfviewer').ej2_instances[0];
    var currentPageBox = document.getElementById('currentPage');
    if ((event.which < 48 || event.which > 57) && event.which !== 8 && event.which !== 13) {
        event.preventDefault();
        return false;
    }
    else {
        var currentPageNumber = parseInt(currentPageBox.value);
        if (event.which === 13) {
            if (currentPageNumber > 0 && currentPageNumber <= viewer.pageCount) {
                pdfViewer.navigation.goToPage(currentPageNumber);
            }
            else {
                currentPageBox.value = viewer.currentPageNumber.toString();
            }
        }
        return true;
    }
}
function initialLoad() {
    currentPageBox = document.getElementById('currentPage');
    currentPageBox.value = '1';
    document.getElementById('fileUpload').addEventListener('change', readFile, false);
    document.getElementById('openPage').addEventListener('click', openPage);
    currentPageBox.addEventListener('keypress', () => {
        var pdfViewer = document.getElementById('pdfviewer').ej2_instances[0];
        var currentPage = document.getElementById('currentPage');
        if ((event.which < 48 || event.which > 57) && event.which !== 8 && event.which !== 13) {
            event.preventDefault();
            return false;
        } else {
            var currentPageNumber = parseInt((currentPage).value);
            if (event.which === 13) {
                if (currentPageNumber > 0 && currentPageNumber <= pdfViewer.pageCount) {
                    pdfViewer.navigation.goToPage(currentPageNumber);
                } else {
                    (currentPage).value = pdfViewer.currentPageNumber.toString();
                }
            }
            return true;
        }
    });
}
function currentPageClicked() {
    var currentPage = document.getElementById('currentPage');
    (currentPage).select();
}
function documentLoaded() {
    document.getElementById('nextPage').addEventListener('click', nextClicked);
    document.getElementById('previousPage').addEventListener('click', previousClicked);
    document.getElementById('nextPage').addEventListener('click', nextClicked);
    document.getElementById('print').addEventListener('click', printClicked);
    document.getElementById('Download').addEventListener('click', downloadClicked);
    document.getElementById('fitPage').addEventListener('click', pageFitClicked);
    document.getElementById('zoomIn').addEventListener('click', zoomInClicked);
    document.getElementById('zoomOut').addEventListener('click', zoomOutClicked);
    var pdfViewer = document.getElementById('pdfviewer').ej2_instances[0];
    var pageCount = document.getElementById('totalPage');
    pageCount.textContent = 'of ' + pdfViewer.pageCount;
    updatePageNavigation();
}
function updatePageNavigation() {
    var toolbarObj = document.getElementById('topToolbar').ej2_instances[0];
    var pdfViewer = document.getElementById('pdfviewer').ej2_instances[0];
    if (pdfViewer.currentPageNumber === 1) {
        toolbarObj.enableItems(document.getElementById('previousPage'), false);
        toolbarObj.enableItems(document.getElementById('nextPage'), true);
    } else if (pdfViewer.currentPageNumber === pdfViewer.pageCount) {
        toolbarObj.enableItems(document.getElementById('previousPage'), true);
        toolbarObj.enableItems(document.getElementById('nextPage'), false);
    } else {
        toolbarObj.enableItems(document.getElementById('previousPage'), true);
        toolbarObj.enableItems(document.getElementById('nextPage'), true);
    }
}
function previousClicked() {
    var pdfViewer = document.getElementById('pdfviewer').ej2_instances[0];
    pdfViewer.navigation.goToPreviousPage();
}
function nextClicked() {
    var pdfViewer = document.getElementById('pdfviewer').ej2_instances[0];
    pdfViewer.navigation.goToNextPage();
}
function printClicked() {
    var pdfViewer = document.getElementById('pdfviewer').ej2_instances[0];
    pdfViewer.print.print();
}
function downloadClicked() {
    var pdfViewer = document.getElementById('pdfviewer').ej2_instances[0];
    pdfViewer.download();
}
function pageFitClicked() {
    var pdfViewer = document.getElementById('pdfviewer').ej2_instances[0];
    pdfViewer.magnification.fitToPage();
}
function zoomInClicked() {
    var pdfViewer = document.getElementById('pdfviewer').ej2_instances[0];
    pdfViewer.magnification.zoomIn();
}
function zoomOutClicked() {
    var pdfViewer = document.getElementById('pdfviewer').ej2_instances[0];
    pdfViewer.magnification.zoomOut();
}