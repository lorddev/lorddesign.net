
var settings = { current: 1 };

function doSlide(num, page) {
    if (num == settings.current) {
        return;
    }

    $('footer').hide();
    var options = { };
    var optionsOpen = { };
    if (num < settings.current) {
        options.left = '1300px';
        optionsOpen.display = 'block';
        optionsOpen.left = '-1300px';
    } else {
        options.left = '-1300px';
        optionsOpen.left = '1300px';
        optionsOpen.display = 'block';
    }

    // Make sure the new page doesn't match the target
    open = $(page);
    open.css({ position: 'absolute' });
    open.css(optionsOpen);
    open.addClass('container');
    open.removeClass('container-fluid');

    // When sliding out, just use class.
    var target = $(".container-fluid.sixty");
    target.addClass('container');
    target.removeClass('container-fluid');
    target.css({ position: 'absolute' });

    target.animate(options, 'slow', function() {
        target.hide();
    });

    open.animate({ 'left': '0' }, 'slow', function() {
        open.addClass('container-fluid');
        open.removeClass('container');
        open.css({ position: 'relative' });
        $('footer').show('slow');
    });

    settings.current = num;

}

$(function() {
    $('li > a').click(toggle);
});

function toggle() {
    var target = $(this).closest('li');
    if (target.hasClass('active')) {
        return;
    }

    $('li').removeClass('active');
    target.addClass('active');
}

$(function() {
    //alert(window.location.hash);
    switch (window.location.hash) {
    case "#about":
        doSlide(2, "#p-tech");
        break;
    case "#contact":
        doSlide(3, "#p-contact");
        break;
    default:
        return;
    }

    doHighlight(window.location.hash);

    function doHighlight(hash) {
        var target = $("a[href$=" + hash + "]").closest('li');
        if (target.hasClass('active')) {
            return;
        }

        $('li').removeClass('active');
        target.addClass('active');
    }

    $('.brand').click(function() {
        doSlide(1, '#p-hero');
        doHighlight('#');
    });
});