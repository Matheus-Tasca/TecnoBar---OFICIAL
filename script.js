var btnMostrarLogin = document.querySelector(".btnNavbar")
var btnEscondeLogin = document.querySelector(".esconderLoginBtn")
var btnLogin = document.querySelector(".btnLogin")
btnMostrarLogin.addEventListener('click',function mostrarLogin(){
    var body = document.querySelector("*")
    var loginTela = document.querySelector(".loginPopUpContainer")
    loginTela.classList.add("mostrar");
    body.style.backgroundColor= "blue";
})

btnEscondeLogin.addEventListener('click', function esconderLogin(){
    var loginTela = document.querySelector(".loginPopUpContainer")
    loginTela.classList.remove("mostrar");
})

btnLogin.addEventListener('click', function realizarLogin(){
    var campoUsername = document.querySelector(".inputUsername")
    var campoPassword = document.querySelector(".inputSenha")
    var mensagemLogin = document.querySelector("#msg")

    campoUsernameValue = campoUsername.value;
    campoPasswordValue = campoPassword.value;
    if ((campoUsernameValue === "master") && (campoPasswordValue === "12345678")){
       alert("LOGIN REALIZADO")
    } else{
        mensagemLogin.innerHTML = "ERRO - SENHA OU USUÁRIO INVÁLIDOS"
        mensagemLogin.style.color = 'red';
    }
})