/*=======================================================
						PageTop	
=======================================================*/
//$(document).ready(function () {
//	$("#pageTop").hide();
//	$(function () {
//		$(window).scroll(function () {
//			if ($(this).scrollTop() > 100) {
//				$('#pageTop').fadeIn();
//			} else {
//				$('#pageTop').fadeOut();
//			}
//		});

//		$('#pageTop').click(function () {
//			$('body,html').animate({
//				scrollTop: 0
//			}, 800);
//			return false;
//		});
//	});
//});

/*=======================================================
		Change Img From Pc To Sp OR Screen Rentina
=======================================================*/
jQuery(document).ready(function ($) {
	var elem = $(this);
	var imgSrc = $("img", elem).map(function () {
		return $(this).attr("src");
	});

	function changeImages() {
		var winWimg = $(window).width();
		for (var i = 0; i < imgSrc.length; i++) {
			var newImgSrc = imgSrc[i].substring(0, imgSrc[i].length - 4),
				getExp = imgSrc[i].slice(-3),
				newImg = newImgSrc + "_sp";
			if (getExp == "jpg") {
				newImg = newImg + "." + getExp;
			} else if (getExp == "gif") {
				newImg = newImg + "." + getExp;
			} else if (getExp == "png") {
				newImg = newImg + "." + getExp;
			}
			else if (getExp == "svg") {
				newImg = newImg + "." + getExp;
			}

			if (winWimg <= 768) {
				$("img.img768", elem).each(function () {
					$(this).attr("src", $(this).attr("src").replace(imgSrc[i], newImg));
				});
			} else {
				$("img.img768", elem).each(function () {
					$(this).attr("src", $(this).attr("src").replace(newImg, imgSrc[i]));
				});
			}

			if (window.devicePixelRatio > 1 || winWimg <= 768) {
				$("img.img2x", elem).each(function () {
					$(this).attr("src", $(this).attr("src").replace(imgSrc[i], newImg));
				});
			}

		}
	}
	changeImages();
	$(window).resize(function () {
		changeImages();
	});
});

/*==========================
 *      Navigation Menu
 * ==========================*/

$(document).ready(function () {
    var btnMenu = document.querySelector(".js-open-menu");
    var MenuItems = document.querySelector(".navigation");
    var btnMenuClose = document.querySelector(".js-close-menu");
    btnMenu.addEventListener("click", function () {
        if (MenuItems.className == "navigation") {
            MenuItems.classList.add("open-menu");
        }
    });
    btnMenuClose.addEventListener("click", function () {
        if (MenuItems.className == "navigation open-menu") {
            MenuItems.classList.remove("open-menu");
        }
    });

    var btnMenu1 = document.querySelector(".js-menu");
    btnMenu1.addEventListener("click", function () {
        if (MenuItems.className == "navigation") {
            MenuItems.classList.add("open-menu");
        }
    });

});


$(document).ready(function () {
    const a = document.querySelectorAll('#MenuItems  .nav-list__item');
    const aa = document.querySelectorAll('#MenuItems  .sub-nav-list-section--global');

    a.forEach((tab, index) => {

        tab.addEventListener("click", function () {
            if (aa[index].classList == "sub-nav-list-section--global open-nav") {
                aa[index].classList.remove('open-nav');
            }
            else {
                aa[index].classList.add('open-nav');
            }
        });
    });

});

$(document).ready(function () {
    const a = document.querySelectorAll('.global-sub-nav-column');
    for (var i = 0; i < a.length; i++) {
        a[i].addEventListener("click", myFun, false);
    }

    function myFun(e) {
        if (this.classList == "global-sub-nav-column global-sub-nav-column--parent open-sub-nav") {
            this.classList.remove('open-sub-nav');
        }
        else {
            this.classList.add('open-sub-nav');
        }
        e.stopPropagation();
    }

});

/*
 *
 * Search
 * 
 * */
$(document).ready(function () {
   
        var btnSearch = document.querySelector(".js-open-search");
        var SearchItems = document.querySelector(".search-container");
        var btnSearchClose = document.querySelector(".search-title");
        btnSearch.addEventListener("click", function () {
            if (SearchItems.className == "search-container") {
                SearchItems.classList.add('open-search');
            }
            else {
                SearchItems.classList.remove('open-search');
            }
        });
        btnSearchClose.addEventListener("click", function () {
            if (SearchItems.className == "search-container open-search") {
                SearchItems.classList.remove('open-search');
            }
        });

    var btnSearch1 = document.querySelector(".js-search");
    btnSearch1.addEventListener("click", function () {
        if (SearchItems.className == "search-container") {
            SearchItems.classList.add('open-search');
        }
        else {
            SearchItems.classList.remove('open-search');
        }
    });
});


$(document).ready(function () {
    var btnCart = document.querySelector(".js-open-cart");
    var Slideoutbasket = document.querySelector(".slide-menu");
    var btnCartClose = document.querySelector(".slide-menu__close");
    btnCart.addEventListener("click", function () {
        if (Slideoutbasket.className == "slide-menu slide-menu--right slide-menu--with-background") {
            Slideoutbasket.classList.add("open-cart");
        }
    });
    btnCartClose.addEventListener("click", function () {
        if (Slideoutbasket.className == "slide-menu slide-menu--right slide-menu--with-background open-cart") {
            Slideoutbasket.classList.remove("open-cart");
        }
    });
    var btnCart1 = document.querySelector(".js-cart");
    btnCart1.addEventListener("click", function () {
        if (Slideoutbasket.className == "slide-menu slide-menu--right slide-menu--with-background") {
            Slideoutbasket.classList.add("open-cart");
        }
    });
});



/*
 Account
 */
$(document).ready(function () {
    $("#openform").click(function () {
        $("#js-formaccount").slideToggle();
    });

    $("#openform1").click(function () {
        $("#js-formaccount").slideToggle();
    });

});

/*
   Footer 
 */

$(document).ready(function () {
    const b = document.querySelectorAll('.responsive-accordion  .responsive-accordion__title');
    const bb = document.querySelectorAll('.responsive-accordion  .responsive-accordion__content');

    b.forEach((tab, index) => {

        tab.addEventListener("click", function () {
            if (bb[index].classList == "responsive-accordion__content js-responsive-accordion") {
                bb[index].classList.remove('js-responsive-accordion');
            }
            else {
                bb[index].classList.add('js-responsive-accordion');
            }
        });
    });

});