var btnMostrarLogin = document.querySelector(".btnNavbar")
var btnEscondeLogin = document.querySelector(".esconderLoginBtn")
var btnLogin = document.querySelector(".btnLogin")
const popLogin = document.querySelector("#popUp")


btnMostrarLogin.addEventListener('click',function(){
    popLogin.showModal();
})
/*btnMostrarLogin.addEventListener('click',function mostrarLogin(){
    var loginTela = document.querySelector(".loginPopUpContainer")
    loginTela.classList.add("mostrar");
})
*/
btnEscondeLogin.addEventListener('click', function (){
    popLogin.close();
})

btnLogin.addEventListener('click', function realizarLogin(){
    var campoUsername = document.querySelector(".inputUsername")
    var campoPassword = document.querySelector(".inputSenha")
    var mensagemLogin = document.querySelector("#msg")

    campoUsernameValue = campoUsername.value;
    campoPasswordValue = campoPassword.value;
    if ((campoUsernameValue === "master") && (campoPasswordValue === "12345678")){
       alert("LOGIN REALIZADO, BEM VINDO")
       window.location.href = "inicio_dashboard_web/InicioDashboard.html"
    } else{
        mensagemLogin.innerHTML = "ERRO - SENHA OU USUÁRIO INVÁLIDOS"
        mensagemLogin.style.color = 'red';
    }
})