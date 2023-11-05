const userModel = require('../models/userModel')

const addUser = async (req,res)=>{
    const cadastroFeito = await userModel.cadastro(req.body)
    return res.status(200).json(cadastroFeito)
}

const login = async (req,res)=>{
    const dadosLogin = await userModel.login(req.body)
    return res.status(200).json(dadosLogin)
}

module.exports = {
    addUser,
    login
}