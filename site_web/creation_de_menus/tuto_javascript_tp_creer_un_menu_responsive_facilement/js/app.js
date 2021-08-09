var btn = document.querySelector('.toogle_btn');
var nav = document.querySelector('.nav');

btn.onclick = function(){
    nav.classList.toggle('nav_open');
}