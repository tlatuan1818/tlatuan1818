var swiper = new Swiper('.swiper-container', {

    slidesPerView: 2,
    spaceBetween: 15,
    breakpoints: {
        1000: {
            slidesPerView: 5
        },
        600: {
            slidesPerView: 3
        }
    },
    //// If we need pagination
    //pagination: {
    //    el: '.swiper-pagination',
    //    clickable: true
    //},
    
    scrollbar: {
        el: '.swiper-scrollbar',
        hide: false,
        dragSize: 'auto',
        dragClass: 'swiper-scrollbar-drag',
        draggable: true
    },

});
var slider = new Swiper('.js-slider-item', {
    autoplay: {
       delay: 3000
    },
    pagination: {
        el: '.swiper-pagination',
        type:'progressbar',
        progressbarFillClass: 'swiper-pagination-progressbar-fill',
        progressbarOpposite: false,
        progressbarOppositeClass: 'swiper-pagination-progressbar-opposite'

    },
    navigation: {
        nextEl: '.swiper-button-next',
        prevEl: '.swiper-button-prev',
    },
});


var brands = new Swiper('.brands', {
    slidesPerView: 2,
    spaceBetween: 15,
    autoplay: {
        delay: 3000,
    },
    breakpoints: {
        769: {
            slidesPerView: 5
        },
        501: {
            slidesPerView: 3
        }
    },
    
});

 

       
var topgrid = new Swiper('.top-grid', {
    spaceBetween: 20,
    slidesPerView: 1,
    virtualTranslate: false,
    breakpoints: {
        599: {
            slidesPerView: 3,
            virtualTranslate: true
        }
    }
});

var primer = new Swiper('.js-premier-league', {
    spaceBetween: 20,
    slidesPerView: 1,
    virtualTranslate: false,
    breakpoints: {
        599: {
            slidesPerView: 6,
            virtualTranslate: true
        }
    }
}
);

var euro = new Swiper('.js-euroleague', {
    spaceBetween: 20,
    slidesPerView: 1,
    virtualTranslate: false,
    breakpoints: {
        599: {
            slidesPerView: 4,
            virtualTranslate: true
        }
    }
});

var colour = new Swiper('.colour-box', {
    slidesPerView: 1,
    spaceBetween: 20,
    breakpoints: {
        360: {
            slidesPerView: 2
        },
        599: {
            slidesPerView: 3,
        },
        769: {
            slidesPerView: 5,
        }
    },
    navigation: {
        nextEl: '.swiper-button-next',
        prevEl: '.swiper-button-prev',
    },
});

var nxs = new Swiper('.teamwear-swiper-container', {
    slidesPerView: 1,
    spaceBetween: 20,
    breakpoints: {
        400: {
            slidesPerView: 2
        },
        599: {
            slidesPerView: 3,
        },
        1001: {
            slidesPerView: 5,
        }
    },
    navigation: {
        nextEl: '.swiper-button-next',
        prevEl: '.swiper-button-prev',
    },
});

$(document).ready(function () {
    if ($(window).width() > 960) {
        $('.news-container .swiper-button-next').css("display", "none");
        $('.news-container .swiper-button-prev').css("display", "none");
        $('.news-container .news-flex .news-flex_items').css({
            "order": "3",
            "width": "calc((100% / 4) - 30px)",
            "margin-right": "0px"
        });
        $('.news-container .news-flex .news-flex_items:nth-child(1)').css({
            "order": "1",
            "width": "calc((100% / 2) - 20px)"
        });
        $('.news-container .news-flex .news-flex_items:nth-child(2)').css({
            "order": "2",
            "width": "calc((100% / 2) - 20px)"
        });
    }
    else if ($(window).width() > 663) {
        $('.news-container').removeClass('news-slider swiper-initialized swiper-horizontal swiper-pointer-events');
        $('.news-container .news-flex').removeClass('swiper-wrapper');
        $('.news-container .news-flex').css({
            "transform": "none",
            " transition-duration": "0ms"
        });
        $('.news-container .news-flex .news-flex_items').removeClass('swiper-slide');
        $('.news-container .news-flex .news-flex_items').css({
            "width": "calc((100% / 3) - 10px)",
            "margin-right": "0px"
        });
    }
    else {
        $('.news-container').addClass('news-slider');
        $('.news-container .news-flex').addClass('swiper-wrapper');
        $('.news-container .news-flex .news-flex_items').addClass('swiper-slide');
        $('.news-container .swiper-button-next').css("display", "flex");
        $('.news-container .swiper-button-prev').css("display", "flex");
        var news = new Swiper('.news-slider', {
            slidesPerView: 1,
            spaceBetween: 20,
            breakpoints: {
                400: {
                    slidesPerView: 2
                },

            },
            navigation: {
                nextEl: '.swiper-button-next',
                prevEl: '.swiper-button-prev',
            },
        });
    }

    $(window).resize(function () {
      
        if ($(window).width() > 960) {
            $('.news-container .news-flex .news-flex_items').css({
                "order": "3",
                "width": "calc((100% / 4) - 30px)",
                "margin-right": "0px"
            });
            $('.news-container .news-flex .news-flex_items:nth-child(1)').css({
                "order": "1",
                "width": "calc((100% / 2) - 20px)"
            });
            $('.news-container .news-flex .news-flex_items:nth-child(2)').css({
                "order": "2",
                "width": "calc((100% / 2) - 20px)"
            });
         
           
            
        }
        else if ($(window).width() > 663) {
            $('.news-container').removeClass('news-slider swiper-initialized swiper-horizontal swiper-pointer-events');
            $('.news-container .news-flex').removeClass('swiper-wrapper');
            $('.news-container .news-flex').css({
                "transform": "none",
                " transition-duration":"0ms"
            });
            $('.news-container .news-flex .news-flex_items').removeClass('swiper-slide');
            $('.news-container .news-flex .news-flex_items').css({
                "width": "calc((100% / 3) - 10px)",
                "margin-right": "0px"
            });
        }
        else {
            
            $('.news-container').addClass('news-slider');
            $('.news-container .news-flex').addClass('swiper-wrapper');
            $('.news-container .news-flex .news-flex_items').addClass('swiper-slide');
            $('.news-container .swiper-button-next').css("display", "flex");
            $('.news-container .swiper-button-prev').css("display", "flex");
            var news = new Swiper('.news-slider', {
                slidesPerView: 1,
                spaceBetween: 20,
                breakpoints: {
                    400: {
                        slidesPerView: 2
                    },
                  
                },
                navigation: {
                    nextEl: '.swiper-button-next',
                    prevEl: '.swiper-button-prev',
                },
            });
        }
    });
   
    
});

var newsdeltal = new Swiper('.js-masonry-slider', {
    cssMode: true,
    navigation: {
        nextEl: '.swiper-button-next',
        prevEl: '.swiper-button-prev',
    },
    mousewheel: true,
    keyboard: true,
});


var newsdeltailother = new Swiper('.js-masonry-slider-4', {
    slidesPerView: 5,
    spaceBetween: 15,

    pagination: {
        el: '.swiper-pagination',
    },
    navigation: {
        nextEl: '.swiper-button-next',
        prevEl: '.swiper-button-prev',
    }

});
