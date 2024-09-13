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