let removeAlertTimeout;
let removeDisplayTimeout;

$("#addToCartBtn").click(function () {
    const bookId = $(this).data("book-id");

    $.ajax({
        url: '/Cart/AddToCart',
        type: 'POST',
        data: { id: bookId },
        success: function (response) {
 
            clearTimeout(removeAlertTimeout);

            const divEl = $(".pop-up");
        
            if (!divEl.hasClass("opacity-0")) {
                $("#btn-close").trigger("click");
                clearTimeout(removeDisplayTimeout);

                setTimeout(() => {
                    divEl.removeClass("opacity-0");
                }, 125);

            } else {
                divEl.removeClass("d-none");
                setTimeout(() => {
                    divEl.removeClass("opacity-0");
                }, 10)
            }

            removeAlertTimeout = setTimeout(() => {
                $("#btn-close").trigger("click");
            }, 2500)

            updateCartCount(response.itemsCount);
        }
    })
})

$("#btn-close").click((e) => {
    e.target.parentElement.parentElement.classList.add("opacity-0");

    removeDisplayTimeout = setTimeout(() => {
        e.target.parentElement.parentElement.classList.add("d-none");
    }, 200)
})

function updateCartCount(count) {
    $("#cartCount").text(count);
    $("#cartCountLogged").text(count);
}