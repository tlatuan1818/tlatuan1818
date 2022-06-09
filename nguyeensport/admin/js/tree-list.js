
$(document).ready(function () {
    const a = document.querySelectorAll('.js-tree');
    const aa = document.querySelectorAll('.tree-list-section--global');

    a.forEach((tab, index) => {

        tab.addEventListener("click", function () {
            if (aa[index].classList == "tree-list-section--global open-tree") {
                aa[index].classList.remove('open-tree');
            }
            else {
                aa[index].classList.add('open-tree');
            }
        });
    });

});

$(document).ready(function () {
    const a = document.querySelectorAll('.tree-list-column');
    for (var i = 0; i < a.length; i++) {
        a[i].addEventListener("click", myFun, false);
    }

    function myFun(e) {
        if (this.classList == "tree-list-column open-tree-content") {
            this.classList.remove('open-tree-content');
        }
        else {
            this.classList.add('open-tree-content');
        }
        e.stopPropagation();
    }

});