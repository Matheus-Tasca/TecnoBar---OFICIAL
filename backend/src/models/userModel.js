const connection = require('./connection')

const cadastro = async(dadosCadastrais)=>{
    const {nome} = dadosCadastrais
    const {email} = dadosCadastrais
    const {senha} = dadosCadastrais
    const {cpf} = dadosCadastrais
    const query = 'INSERT INTO Usarios(nome,cpf,email,senha) VALUES (?,?,?,?)'
    const [cadastroFeito] = await (await connection).execute(query,[nome,cpf,email,senha])
    return {insertId: cadastroFeito.insertId}
}

const login = async (dadosLogin) =>{
    const {user} = dadosLogin
    const {senha} = dadosLogin
    const resultadoBusca = await (await connection).query(`
        Select
            id
        from 
            Usarios
        where 
            email = ? 
        and
            senha = ?
    `,[user,senha])
    if (resultadoBusca[0].length == 0){
        return "Usuario não encontrado na base de dados!"
    }
    else
        return resultadoBusca[0]
}

module.exports = {
    login,
    cadastro
}