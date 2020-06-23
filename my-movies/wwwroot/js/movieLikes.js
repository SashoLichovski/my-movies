﻿
function AddLike(movieId) {
    axios.post('/Like/LikeMovie', {
        movieId: movieId
    })
        .then(function (response) {

            if (document.getElementById("addDislikeBtn").classList.contains("hideBtn")) {
                SwitchButtons("addDislikeBtn", "dislikedBtn");
                ChangeLikeCount("dislikesCount", "decrease")
            }

            SwitchButtons("likedBtn", "addLikeBtn");

            ChangeLikeCount("likesCount", "increase");

        })
        .catch(function (error) {
            console.log(error);
        });
}

function AddDislike(movieId) {
    axios.post('/Like/DislikeMovie', {
        movieId: movieId
    })
        .then(function (response) {
            if (document.getElementById("addLikeBtn").classList.contains("hideBtn")) {
                SwitchButtons("addLikeBtn", "likedBtn");
                ChangeLikeCount("likesCount", "decrease")
            }

            SwitchButtons("dislikedBtn", "addDislikeBtn");

            ChangeLikeCount("dislikesCount", "increase");

        })
        .catch(function (error) {
            console.log(error);
        });
}

function SwitchButtons(showBtnId, hideBtnId) {
    var addLikeBtn = document.getElementById(hideBtnId);
    var likedBtn = document.getElementById(showBtnId);

    addLikeBtn.classList.add("hideBtn");
    likedBtn.classList.remove("hideBtn");
}

function ChangeLikeCount(countId, increaseOrDecrease) {
    if (increaseOrDecrease == "increase") {
        var countElement = document.getElementById(countId);
        var count = parseInt(countElement.innerHTML);
        countElement.innerHTML = count + 1;
    } else if (increaseOrDecrease == "decrease") {
        var countElement = document.getElementById(countId);
        var count = parseInt(countElement.innerHTML);
        countElement.innerHTML = count - 1;
    }
}