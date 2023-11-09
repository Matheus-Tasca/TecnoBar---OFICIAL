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
   let nome  = nomeCampo.value
   let email = emailCampo.value 
   let senha = senhaCampo.value 
   let cpf = cpfCampo.value

   if(nome == "" ||email == ""||senha == ""|| cpf == ""){
        alert('Preencha todos os campos!')
        limparCampos()
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
    var regex = /^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$/;

    // Testa o valor do campo em relação à regex
    return regex.test(email);
}
const validaSenha = (senha) =>{

}