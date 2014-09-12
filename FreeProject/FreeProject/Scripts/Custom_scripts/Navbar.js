
$(function () {
    $('a.page-scroll').bind('click', function() {
        var $anchor = $(this);
        var newValue = $anchor.attr('href').replace('#', '');
        var url = 'Home/' + newValue;
        $.ajax({
            type: "GET",
            url: url
        });
    });
   
});