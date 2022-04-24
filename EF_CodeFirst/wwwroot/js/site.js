$(function () {
    var page = sessionStorage.getItem('page');
    var navbar = document.querySelectorAll('li');
    if (page == null) {
        $(navbar[0]).addClass('active');
    } else {
        navbar.forEach((item, index) => {
            if (item.children[0].href == page) {
                $(item).addClass('active').siblings().removeClass('active');
            }
        });
    }
})
$(document).on('click', 'ul li', function () {
    var x = this.children[0].href;
    sessionStorage.setItem('page', x);
})
