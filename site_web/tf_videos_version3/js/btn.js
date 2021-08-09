var btn = document.querySelector('.toogle_btn');
var nav = document.querySelector('.bar_retract');

btn.onclick = function(){
    nav.classList.toggle('bar_retract_close');
}