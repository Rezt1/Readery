let removeAlertTimeout;
let hideAlertTextTimeout;

$("#addToCartBtn").click(function () {
    const bookId = $(this).data("book-id");

    $.ajax({
        url: '/Cart/AddToCart',
        type: 'POST',
        data: { id: bookId },
        success: function (response) {
            clearTimeout(hideAlertTextTimeout);
            showAlertText();
            clearTimeout(removeAlertTimeout);

            const divEl = $("#body-header > div");

            if (divEl.hasClass("opacity-100")) {
                $("#btn-close").trigger("click");

                setTimeout(() => {
                    clearTimeout(hideAlertTextTimeout);
                    showAlertText();
                    divEl.addClass("opacity-100");
                }, 125);

            } else {
                divEl.removeClass("opacity-0");
                divEl.addClass("opacity-100");
            }

            removeAlertTimeout = setTimeout(() => {
                $("#btn-close").trigger("click");
            }, 2500)

            updateCartCount(response.itemsCount);
        }
    })
})

$("#btn-close").click((e) => {
    e.target.parentElement.parentElement.classList.remove("opacity-100");
    e.target.parentElement.parentElement.classList.add("opacity-0");

    hideAlertTextTimeout = setTimeout(hideAlertText, 150);
})

$(document).ready(() => {
    $.ajax({
        url: '/Cart/GetCartCount',
        type: 'GET',
        success: (response) => {
            updateCartCount(response.count);
        }
    })
})

function updateCartCount(count) {
    $("#cartCount").text(count);
    $("#cartCountLogged").text(count);
}

function showAlertText() {
    const pEl = $("#body-header > div > div > p");
    const btnEl = $("#body-header > div > div > button");

    pEl.removeClass("visually-hidden");
    btnEl.removeClass("visually-hidden")
}

function hideAlertText() {
    const pEl = $("#body-header > div > div > p");
    const btnEl = $("#body-header > div > div > button");

    pEl.addClass("visually-hidden");
    btnEl.addClass("visually-hidden");
}

$("form > .item").change(function() {
    $(this).closest("form").submit();
})