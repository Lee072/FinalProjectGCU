// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

const { Checkbox } = require("../../../../../node_modules/@mui/material/index");

// Write your JavaScript code.
function darkModeToggle() {
    var element = document.body;
    element.classList.toggle("dark-mode");
    element.classList.toggle("navbar-dark");
    element.classList.toggle("headers-dark");
}




// get the div element
const myDiv = document.querySelector('#myDiv');

// add a click event listener to the div
    myDiv.addEventListener('click', function () {
    // specify the action to take when the div is clicked
    console.log('Div was clicked!');
});