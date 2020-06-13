
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
}

// Ratings with stars
function Rate(event) {


    var thumb = document.getElementById(event.target.id);
    thumb.style.color = "green"

    var input = document.getElementById("rating");
    input.value = event.target.id
    console.log(input.value)
}
