const hamburguer = document.querySelector(".hamburguer");
const Navmenu = document.querySelector(".nav-menu");

hamburguer.addEventListener("click", ()  =>{
    hamburguer.classList.toggle("active");
    Navmenu.classList.toggle("active");
})