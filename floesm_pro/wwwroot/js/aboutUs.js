// section2 js

$(document).ready(function () {
    //parallax scroll





    $.fn.isOnScreen = function () {

        var win = $(window);

        var viewport = {
            top: win.scrollTop(),
            left: win.scrollLeft()
        };
        viewport.right = viewport.left + win.width();
        viewport.bottom = viewport.top + win.height();

        var bounds = this.offset();
        bounds.right = bounds.left + this.outerWidth();
        bounds.bottom = bounds.top + this.outerHeight();

        return (!(viewport.right < bounds.left || viewport.left > bounds.right || viewport.bottom < bounds.top || viewport.top > bounds.bottom));

    };

    $(document).ready(function () {
        $(window).scroll(function () {
            $(".text-color").each(function (i) {
                if ($(this).isOnScreen()) {
                    $(this).css({
                        // "animation-delay": "1s",
                        // "animation": "textAnimation 2.5s linear forwards"
                    });
                } else {
                    $(this).css({
                        // "animation-delay": "1s",
                        // "animation": "textAnimationBackwards linear 2.5s forwards"
                    });
                }
            });
        });
    });
    var $window = $(window),
        part_3 = $('.aboutUs-main-container'),
        text_2014 = part_3.find('#2014'),
        text_2015 = part_3.find('#2015');
    rect = part_3[0].getBoundingClientRect();

    function revealText() {
        var scrollTop = $window.scrollTop();
        var windowHeight = $window[0].innerHeight;

        if (scrollTop + windowHeight > rect.top) {
            // var percentVisible = (scrollTop - (rect.top - windowHeight)) / rect.height;
            var position = (scrollTop - $(text_2014).offset().top) - 10;
            var position1 = (scrollTop - $(text_2015).offset().top) - 40;

            text_2014.css('transform', 'translateX(-' + position + 'px)');
            text_2015.css('transform', 'translateX(' + position1 + 'px)');
        }
    }

    $window.on('scroll', revealText);

});

// Parallax2
let st = window.scrollY;
const squares = document.getElementsByClassName('square');

// this is just for fun
function getRandomColor() {
    var letters = '0123456789ABCDEF';
    var color = '#';
    for (var i = 0; i < 6; i++) {
        color += letters[Math.floor(Math.random() * 16)];
    }
    return color;
}

function translateSquare(sq_el) {
    const dx = 0;
    const dy = -st;
    const dz = parseInt(sq_el.dataset.distance, 10) || 1;
    const ttt = $('.containers').offset().top - st - 30

    sq_el.style.transform = 'translate3d(' + dx + 'px, ' + ttt + 'px,' + dz + 'px)';
}

function translateSquares() {
    Array.from(squares).map(sq => translateSquare(sq))
}

function initSquare(sq_el) {
    sq_el.style.backgroundColor = getRandomColor();
    sq_el.style.visibility = "visible";
    sq_el.style.opacity = 1;
}

function initSquares() {
    Array.from(squares).map(sq => initSquare(sq)).map(sq => translateSquares(sq));
}

document.addEventListener('scroll', (evt) => {
    st = window.scrollY;

    // this does the actual translation
    translateSquares();
});

initSquares();