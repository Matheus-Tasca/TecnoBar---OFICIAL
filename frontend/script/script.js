// Novo Script
document.addEventListener('DOMContentLoaded', function () {
    const owlCarousel = document.querySelector('.owl-carousel');
    if (owlCarousel) { // Verifica si se encontró un elemento con la clase "owl-carousel"
        // Configura el carrusel utilizando el método Owl Carousel
        const owl = $(owlCarousel);
        owl.owlCarousel({
            loop: true,
            margin: 10,
            nav: true,
            responsive: {
                0: {
                    items: 1
                }
            }
        });
    }
    
    
});

const email = document.querySelector('#email1')
const senha = document.querySelector('#password1')
const btnEntrar = document.querySelector("#entrar")

const login = () =>{
    let email1 = email.value
    let senha1 = senha.value
    if(email1 === "master" && senha1 === "12345678"){
        alert("LOGIN REALIZADO, BEM VINDO")
        window.location.href = "InicioDashboard.html"
    }
    else if(email1 == "")
        alert('Preencha o campo email para realizar login!')
    else if(senha1 == "")
        alert('Preencha o campo senha para realizar login!')
    else{
        alert('Verifique se suas credenciais estão corretas e tente novamente!')
        email.value = ""
        senha.value = ""
    }
}
btnEntrar.addEventListener("click",function(){
    login()
})
senha.addEventListener('keyup',(e)=>{
    if(e.code === 'Enter')
    login()
})

// const btnMostrarLogin = document.querySelector(".btnNavbar")
// const btnEscondeLogin = document.querySelector(".esconderLoginBtn")
// const btnLogin = document.querySelector(".btnLogin")
// const popLogin = document.querySelector("#popUp")
// const campoUsername = document.querySelector(".inputUsername")
// const campoPassword = document.querySelector(".inputSenha")
// const mensagemLogin = document.querySelector("#msg")
// const nomeInputContato = document.querySelector("#nomeInputContato")
// const emailInputContato = document.querySelector("#emailInputContato")
// const messageInputContato = document.querySelector("#messageInputContato")
// const btnSubmiteContato = document.querySelector(".btnSubmiteContato")

// btnMostrarLogin.addEventListener('click',function(){
//     popLogin.showModal();
// })

// btnEscondeLogin.addEventListener('click', function (){
//     popLogin.close();
// })

// const login = () => {
//     let user = campoUsername.value
//     let pass = campoPassword.value
//     if ((user === "master") && (pass === "12345678")){
//         alert("LOGIN REALIZADO, BEM VINDO")
//         window.location.href = "InicioDashboard.html"
//      } else{
//          mensagemLogin.innerHTML = "ERRO - SENHA OU USUÁRIO INVÁLIDOS"
//          mensagemLogin.style.color = 'red';
//      }
//      console.log(campoUsername.value)
//      console.log(campoPassword.value)
// }

// btnLogin.addEventListener('click',(e)=>{
//     e.preventDefault()
//     login()
// })
// campoPassword.addEventListener('keyup',(e)=>{
//     if(e.code === 'Enter')
//         login()
// })

// btnSubmiteContato.addEventListener('click',()=>{
//     if(nomeInputContato.value == "" || emailInputContato.value == "" || messageInputContato.value == ""){
//         alert("Preencha todos os campos de contato!")
//     }
//     else{
//         alert("Dados enviados com suceso !")
//         nomeInputContato.value = "";
//         emailInputContato.value = "";
//         messageInputContato.value = "";
//     }
// })