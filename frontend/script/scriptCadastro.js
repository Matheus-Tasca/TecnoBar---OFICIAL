const nomeCampo  = document.querySelector('#nomeCadastro')
const emailCampo = document.querySelector('#emailCadastro')
const senhaCampo = document.querySelector('#senhaCadastro') 
const cpfCampo = document.querySelector('#cpfCadastro')
const botaoCadastrar = document.querySelector('#btnCadastra')

const formataCpf = (cpf) =>{
    cpf = cpf.replace(/\D/g, '')
    cpf = cpf.slice(0, 11)

    var formattedCPF = ''
    for (var i = 0; i < cpf.length; i++) {
        if (i === 3 || i === 6) {
            formattedCPF += '.'
            } 
        else if (i === 9) {
            formattedCPF += '-'
            }
        formattedCPF += cpf[i]
            }
    return formattedCPF
}
const limparCampos = () =>{
    nomeCampo.value = ""
    emailCampo.value = ""
    senhaCampo.value = ""
    cpfCampo.value = ""
}
const cadastrar = async () => {
   let msg
   let nome  = nomeCampo.value
   let email = validaEmail(emailCampo.value) 
   let senha = validaSenha(senhaCampo.value) 
   let cpf = parseInt(validaCPF(cpfCampo.value))

   console.log('Nome: '+nome)
   console.log('email: '+email)
   console.log('cpf: '+cpf)
   console.log('senha: '+senha) 

   if (validacoes(nome,email,senha,cpf,msg) !== ""){
    let alerta = validacoes(nome,email,senha,cpf,msg)
    alert(alerta) 

   }
   else{
    const dadosCadastrais = {nome: nome, email:email, senha: senha, cpf: cpf}

    await fetch('http://localhost:4001/cadastro',{
        method: 'post',
        headers : {'Content-Type':'application/json'},
        body: JSON.stringify(dadosCadastrais)
    }).then((res)=>{
        if(!res.ok)
            console.log('ERRO')
        return res.json()
    }).then((dados)=>{
        resultado = dados
        alert('Cadastro realizado com sucesso!')
        window.location.href = "InicioDashboard.html"
    })
    limparCampos()
}
}

botaoCadastrar.addEventListener('click',()=>{
    cadastrar()
})

cpfCampo.addEventListener("input",()=>{
    let cpfFormatado = formataCpf(cpfCampo.value)
    cpfCampo.value = cpfFormatado
})

cpfCampo.addEventListener('keyup',(e)=>{
    if (e.code === 'Enter')
    cadastrar()
})

const validaEmail = (email) =>{
    var regex = /^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$/

    if (regex.test(email))
        return email
}
const validaSenha = (senha) =>{
    var regex = /^(?=.*[A-Z])(?=.*\d).{8,}$/
    if (regex.test(senha))
        return senha
}
const validaCPF = (cpf) =>{
    cpf = cpf.replace(/\D/g, '')
    if(cpf.length !== 11)
        return false
    else if(/^(\d)\1{10}$/.test(cpf))
        return false
    else 
        return cpf
}
const validacoes = (nome,email,senha , cpf,msg)=>{
    msg = ""
    if(nome =="")
        msg = 'Preencha o campo NOME!'
    else if(email == undefined)
        msg = 'Preencha o campo EMAIL corretamente!'
    else if(cpf == NaN)
        msg = 'Preencha o campo CPF corretamente!'
    else if(senha == undefined)
        msg = 'Senha deve ter no minimo 8 caracteres, 1 letra maiuscúla e 1 número!'
    return msg
}