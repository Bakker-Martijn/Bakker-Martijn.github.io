const menu = document.getElementById("menu");
const openNavMenu = document.getElementById('menu-burger');
const closeNavMenu = document.getElementById('close-menu-burger');


const addClass = () => {
    if (menu) menu.classList.add("visible");
}

const removeClass = () => {
    if (menu) menu.classList.remove("visible");
}

openNavMenu.addEventListener('click', () => {
    addClass();
});

closeNavMenu.addEventListener('click', () => {
    removeClass();
});

menu.addEventListener('click', () => {
    removeClass();
});