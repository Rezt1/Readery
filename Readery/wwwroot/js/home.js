$(document).ready(function () {
    if (sessionStorage.getItem("order")) {
        $("#overlay").removeClass("d-none");
        $("#pop-up-third").removeClass("d-none");

        sessionStorage.removeItem("order");
    }

    $("#close-ok").click(() => {
        $("#overlay").fadeOut();
        $("#pop-up-third").fadeOut(200, "swing");
    })
})