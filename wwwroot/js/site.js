// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
$('.switch').click(() => {
    $([".light [class*='-light']", ".dark [class*='-dark']"]).each((i, ele) => {
        $(ele).toggleClass('bg-light bg-dark')
        $(ele).toggleClass('text-light text-dark')
        $(ele).toggleClass('navbar-light navbar-dark')
        $(ele).toggleClass('div-light div-dark')
    })
    // toggle body class selector
    $('body').toggleClass('light dark')
})
