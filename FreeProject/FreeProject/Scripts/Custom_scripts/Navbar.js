
/*$(function () {
    $('a.page-scroll').bind('click', function() {
        var $anchor = $(this);
        var newValue = $anchor.attr('href').replace('#', '');
        var url = 'Home/' + newValue;
        $.ajax({
            type: "GET",
            url: url
        });
    });
   
});*/

$(function () {
    $('a.page-scroll').bind('click', function () {
        var $anchor = $(this);
        var newValue = $anchor.attr('href').replace('#', '');
        $('#' + newValue).load('/Home/' + newValue);
    });
    
});