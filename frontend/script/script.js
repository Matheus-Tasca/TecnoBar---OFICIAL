const btnMostrarLogin = document.querySelector(".btnNavbar")
const btnEscondeLogin = document.querySelector(".esconderLoginBtn")
const btnLogin = document.querySelector(".btnLogin")
const popLogin = document.querySelector("#popUp")
const campoUsername = document.querySelector(".inputUsername")
const campoPassword = document.querySelector(".inputSenha")
const mensagemLogin = document.querySelector("#msg")
const nomeInputContato = document.querySelector("#nomeInputContato")
const emailInputContato = document.querySelector("#emailInputContato")
const messageInputContato = document.querySelector("#messageInputContato")
const btnSubmiteContato = document.querySelector(".btnSubmiteContato")

btnMostrarLogin.addEventListener('click',function(){
    popLogin.showModal();
})

btnEscondeLogin.addEventListener('click', function (){
    popLogin.close();
})

const login = () => {
    let user = campoUsername.value
    let pass = campoPassword.value
    if ((user === "master") && (pass === "12345678")){
        alert("LOGIN REALIZADO, BEM VINDO")
        window.location.href = "InicioDashboard.html"
     } else{
         mensagemLogin.innerHTML = "ERRO - SENHA OU USUÁRIO INVÁLIDOS"
         mensagemLogin.style.color = 'red';
     }
     console.log(campoUsername.value)
     console.log(campoPassword.value)
}

btnLogin.addEventListener('click',(e)=>{
    e.preventDefault()
    login()
})
campoPassword.addEventListener('keyup',(e)=>{
    if(e.code === 'Enter')
        login()
})

btnSubmiteContato.addEventListener('click',()=>{
    if(nomeInputContato.value == "" || emailInputContato.value == "" || messageInputContato.value == ""){
        alert("Preencha todos os campos de contato!")
    }
    else{
        alert("Dados enviados com suceso !")
        nomeInputContato.value = "";
        emailInputContato.value = "";
        messageInputContato.value = "";
    }
})