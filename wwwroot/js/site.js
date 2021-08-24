// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

let modal1 = document.getElementById('respuesta1');
let modal2 = document.getElementById('respuesta2');

let pista1 = document.getElementById('pista1');
let pista2 = document.getElementById('pista2');

let closeButton1 = document.getElementById('close1');
let closeButton2 = document.getElementById('close2');

pista1.onclick = () => {
    modal1.style.setProperty("display", "block")
}

pista2.onclick = () => {
    modal2.style.setProperty("display", "block")
}

closeButton1.onclick = () => {
    modal1.style.setProperty("display", "none")
}

closeButton2.onclick = () => {
    modal2.style.setProperty("display", "none")
}