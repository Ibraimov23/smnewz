
function remove(action, id, child, newresult) {
    var result = '.result';
    $.ajax({
        type: "POST",
        url: `/admin/${action}`,
        data: { id: id, child: child },
        datatype: "html",
        success: function (data) {
            if (newresult == true) result = '.result1'; else result;
            $(result).replaceWith($(result, data));
        },
        error: function (xhr) {
            console.log(xhr.responseText)
        }
    });
}
function filter(name) {
    $.ajax({
        type: "POST",
        url: `/`,
        data: { category: name },
        datatype: "html",
        success: function (data) {
            $('.page-index3__resultsItems').replaceWith($('.page-index3__resultsItems', data));
        },
        error: function (xhr) {
            console.log(xhr.responseText)
        }
    });
}
function subscript(param) {
    document.querySelector('.subscribe-main').style.display = param;
}
function navmobile() {
    $('.header__nav-mobile,.header__nav-mobile,.header__hamburger_button').toggleClass('active');
}
function search() {
    let value = document.getElementById('search').value
    $.ajax({
        type: "POST",
        url: "/archive",
        data: { search: value },
        datatype: "html",
        success: function (data) {
            $('.page-index3__items').replaceWith($('.page-index3__items', data));
        }
    });
}