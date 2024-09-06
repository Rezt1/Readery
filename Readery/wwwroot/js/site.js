let timeout;

$(document).ready(function () {
    $("#addToCartBtn").click(function () {
        const bookId = $(this).data("book-id");

        $.ajax({
            url: '/Cart/AddToCart',
            type: 'POST',
            data: { id: bookId },
            success: function (response) {
                clearTimeout(timeout);

                const divEl = $("#body-header > div");

                if (divEl.hasClass("opacity-100")) {
                    $("#btn-close").trigger("click");

                    setTimeout(() => {
                        divEl.addClass("opacity-100");
                    }, 125);

                } else {
                    divEl.removeClass("opacity-0");
                    divEl.addClass("opacity-100");
                }

                timeout = setTimeout(() => {
                    $("#btn-close").trigger("click");
                }, 2500)

                UpdateCartCount(response.itemsCount);
            }
        })
    })

    $("#btn-close").click((e) => {
        e.target.parentElement.parentElement.classList.remove("opacity-100");
        e.target.parentElement.parentElement.classList.add("opacity-0");
    })

})

$(document).ready(() => {
    $.ajax({
        url: '/Cart/GetCartCount',
        type: 'GET',
        success: (response) => {
            UpdateCartCount(response.count);
        }
    })
})

function UpdateCartCount(count) {
    $("#cartCount").text(count);
    $("#cartCountLogged").text(count);
}