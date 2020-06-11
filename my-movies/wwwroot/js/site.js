
// Slider lib use
$(document).ready(function () {
    $('.multiple-items').slick({
        infinite: true,
        slidesToShow: 6,
        slidesToScroll: 1,
        responsive: [
            {
                breakpoint: 1024,
                settings: {
                    slidesToShow: 3,
                    slidesToScroll: 3,
                    infinite: true,
                    dots: true
                }
            },
            {
                breakpoint: 600,
                settings: {
                    slidesToShow: 2,
                    slidesToScroll: 2
                }
            },
            {
                breakpoint: 480,
                settings: {
                    slidesToShow: 1,
                    slidesToScroll: 1
                }
            }
            // You can unslick at a given breakpoint now by adding:
            // settings: "unslick"
            // instead of a settings object
        ]
    });
})

// Toggle sidebar
var sidebar = document.getElementById("sidebar");
sidebar.style.left = "-300px";
function ToggleSidebar() {
    if (sidebar.style.left == "-300px") {
        sidebar.style.left = "0px";
    } else if (sidebar.style.left == "0px") {
        sidebar.style.left = "-300px";
    }
    console.log(sidebar.style.left.toString());
}

// Ratings with stars
function Rate(event) {
    console.log(event.target.id);
    var heart = document.getElementById(event.target.id);
    console.log(heart.previousSibling);
    var container = document.getElementById("heartContainer");
    console.log(container.children);
    for (var i = 0; i < event.target.id; i++) {
        container.children[i].style.color = "red";
    }
}
