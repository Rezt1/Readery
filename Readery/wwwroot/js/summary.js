$(document).ready(function () {
    if (sessionStorage.getItem("main")) {
        $(".pop-up-second").removeClass("d-none");
        $(".pop-up-second").removeClass("opacity-0");
        sessionStorage.removeItem("main");

        setTimeout(function () {
            $(".pop-up-second").addClass("opacity-0");
        }, 2000)

        setTimeout(function () {
            $(".pop-up-second").addClass("d-none");
        }, 2150)
    }
})