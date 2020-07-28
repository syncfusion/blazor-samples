function initSearch() {
    initFunction();
    var searchDataAjax = new ej.base.Ajax("./scripts/home/blazor-search.json", "GET", true);
    searchDataAjax.send().then((result) => {
        var searchJson = JSON.parse(result);
        elasticlunr.clearStopWords();
        var dataSource = [];
        var fields = {
            groupBy: "doc.component",
            value: "doc.url",
            text: "doc.name"
        };
        var searchInstance = elasticlunr.Index.load(searchJson);
        var searchBox = new ej.dropdowns.AutoComplete({
            dataSource: dataSource,
            filtering: (e) => {
                if (e.text && e.text.length < 3) {
                    return;
                }
                var val = searchInstance.search(e.text, {
                    fields: {
                        component: { boost: 1 },
                        name: { boost: 2 }
                    },
                    expand: true,
                    boolean: "AND"
                });
                var query = new ej.data.Query().take(10).select("doc");
                var fields = searchBox.fields;
                e.updateData(val, query, fields);
            },
            placeholder: "Search components or features",
            noRecordsTemplate:
                '<div class="search-no-record">We’re sorry. We cannot find any matches for your search term.</div>',
            fields: fields,
            popupHeight: "auto",
            suggestionCount: 10,
            highlight: true,
            select: (e) => {
                location.href += e.itemData.doc.url + '?theme=bootstrap4';
            }
        });
        window.searchBox = searchBox;
        searchBox.appendTo("#search-box");
        document.getElementById('searching').classList.remove('bh-hide');
        var mobsearchBox = new ej.dropdowns.AutoComplete({
            dataSource: dataSource,
            filtering: (e) => {
                if (e.text && e.text.length < 3) {
                    return;
                }
                var val = searchInstance.search(e.text, {
                    fields: {
                        component: { boost: 1 },
                        name: { boost: 2 }
                    },
                    expand: true,
                    boolean: "AND"
                });
                var query = new ej.data.Query().take(10).select("doc");
                var fields = mobsearchBox.fields;
                e.updateData(val, query, fields);
            },
            placeholder: "Search components or features",
            noRecordsTemplate:
                '<div class="search-no-record">We’re sorry. We cannot find any matches for your search term.</div>',
            fields: fields,
            popupHeight: "auto",
            suggestionCount: 10,
            highlight: true,
            select: (e) => {
                location.href += e.itemData.doc.url + '?theme=bootstrap4';
            }
        });
        window.mobsearchBox = mobsearchBox;
        mobsearchBox.appendTo("#mob-search-box");

        document.getElementById("mob-search").classList.add("mb-search");
    });
}


function hideSearchDesktop() {
    document.getElementById("mob-search").classList.remove("bh-hide");
    document.getElementById("mob-search").classList.add("sb-icons", "mb-search");
}

function mobilefocus() {
    document.getElementById("mob-search").classList.remove("sb-icons", "mb-search");
    document.getElementById("mob-search").classList.add("bh-hide");
}

function hideSearch() {
    document.getElementById("mbSearch").classList.add("bh-hide");
    document.getElementsByClassName('header-logo')[0].style.display = "block";
    document.getElementsByClassName('head-text')[0].style.visibility = "visible";
    document.getElementById("mob-search").classList.add("sb-icons", "mb-search");
    document.getElementById("mob-search").classList.remove("bh-hide");

}

var carouselFunction;
var carouselContainerDiv;
var prevSlideBtn;
var nextSlideBtn;
var slideWidth = 992;
var progressLevel = 0;
var progressContainer;
var progressBar;
var progressFunction;

function initCarousel() {
    carouselContainerDiv = document.querySelector('.sf-blazor-home .sf-image-carousel .ic-container');
    var carouselWrapper = carouselContainerDiv.parentElement;
    progressContainer = carouselWrapper.querySelector('.ic-progress');
    progressBar = carouselWrapper.querySelector('.ic-progress .ic-progress-bar');
    prevSlideBtn = carouselWrapper.querySelector('button.ic-prev');
    nextSlideBtn = carouselWrapper.querySelector('button.ic-next');
    setCarousel();
    initProgressBar();
    setSlideTimer();
}

function initProgressBar() {
    progressFunction = setInterval(() => {
        if (progressLevel === 100) {
            progressLevel = -1;
        }
        progressBar.style.width = ++progressLevel + "%";
    }, 50);
}

function setProgressMargin() {
    var docWidth = document.body.offsetWidth;
    var progressMargin = ((docWidth - slideWidth) / 2) + 86 + ((docWidth < 901) ? 83 : 0) + ((docWidth < 741) ? 25 : 0) +
        ((docWidth < 681) ? 17 : 0) + ((docWidth < 641) ? 40 : 0) + ((docWidth < 581) ? 25 : 0) + ((docWidth < 491) ? 24 : 0) +
        ((docWidth < 416) ? 8 : 0) + ((docWidth < 376) ? 16 : 0) + ((docWidth < 361) ? 30 : 0) + ((docWidth < 321) ? 14 : 0);
    progressContainer.style.marginLeft = progressMargin + 'px';
}

function setSlideTimer() {
    carouselFunction = setInterval(() => {
        nextSlide();
    }, 5000);
}

function clearSliderTimer() {
    clearInterval(carouselFunction);
}

function setSlideBtnMargin() {
    var btnMargin = ((document.body.offsetWidth - slideWidth) / 2) - 112;
    btnMargin = (btnMargin > 0) ? btnMargin : 0;
    prevSlideBtn.style.marginLeft = btnMargin + 'px';
    nextSlideBtn.style.marginRight = btnMargin + 'px';
}

function setCarousel() {
    setProgressMargin();
    setSlideBtnMargin();
    var currentSlide = carouselContainerDiv.querySelector('.ic-current');

    var slideIndex = Array.prototype.indexOf.call(carouselContainerDiv.children, currentSlide);
    var transformValue = (slideWidth * slideIndex) - ((document.body.offsetWidth - slideWidth) / 2);

    carouselContainerDiv.style.transform = `translate3d(-${transformValue}px, 0px, 0px)`;
}

function prevSlide() {
    clearSliderTimer();
    var currentSlide = carouselContainerDiv.querySelector('.ic-current');

    var slideIndex = Array.prototype.indexOf.call(carouselContainerDiv.children, currentSlide);
    var noSlides = carouselContainerDiv.childElementCount;
    var prevSlideIndex = (slideIndex === 1) ? (noSlides - 2) : (--slideIndex);
    var prevSlide = carouselContainerDiv.children[prevSlideIndex];

    var transformValue = (slideWidth * prevSlideIndex) - ((document.body.offsetWidth - slideWidth) / 2);

    currentSlide.classList.remove('ic-current');
    prevSlide.classList.add('ic-current');
    carouselContainerDiv.style.transform = `translate3d(-${transformValue}px, 0px, 0px)`;
    setSlideTimer();
    progressLevel = 0;
}

function nextSlide() {
    clearSliderTimer();
    var currentSlide = carouselContainerDiv.querySelector('.ic-current');

    var slideIndex = Array.prototype.indexOf.call(carouselContainerDiv.children, currentSlide);
    var noSlides = carouselContainerDiv.childElementCount;
    var nextSlideIndex = (noSlides - slideIndex === 2) ? 1 : (++slideIndex);
    var nextSlide = carouselContainerDiv.children[nextSlideIndex];

    var transformValue = (slideWidth * nextSlideIndex) - ((document.body.offsetWidth - slideWidth) / 2);

    currentSlide.classList.remove('ic-current');
    nextSlide.classList.add('ic-current');
    carouselContainerDiv.style.transform = `translate3d(-${transformValue}px, 0px, 0px)`;
    setSlideTimer();
    progressLevel = 0;
}

function initFunction() {
    document.getElementById('mob-search')
        .addEventListener('click', function () {
            document.getElementById('mbSearch').classList.remove('bh-hide');
            document.getElementsByClassName('header-logo')[0].style.display = "none";
            document.getElementsByClassName('head-text')[0].style.visibility = "hidden";
            document.getElementById('mob-search-box').select();
            document.getElementsByClassName('e-input-group e-control-wrapper e-ddl')[0].classList.add('e-input-focus');

        });
    document.getElementById('searching').addEventListener('click', function () {
        document.getElementById("mob-search").classList.remove("mb-search");
        document.getElementById("mob-search").classList.add("bh-hide");
    });

    window.onresize = function () {
        setProgressMargin();
        setSlideBtnMargin();
        setCarousel();
        if (window.searchBox && window.searchBox.isPopupOpen) {
            window.searchBox.hidePopup();
        }
        if (window.mobsearchBox && window.mobsearchBox.isPopupOpen) {
            window.mobsearchBox.hidePopup();
        }
    };
    if (ej.base.Browser.isDevice) {
        document.getElementById("search-box").onfocus = (e) => {
            e.target.scrollIntoView();
        };
    }
}