const dashModel = require('../models/dashModel')

const getData = async (req,res) =>{
    const datas = await dashModel.getData(req.body)
    return res.status(200).json(datas)
}

const loadData = async (req,res)=>{
    const loadData = await dashModel.loadData(req.body)
    return res.status(200).json(loadData)
}

const loadItem = async (req,res)=>{
    const itens = await dashModel.loadItem(req.body)
    return res.status(200).json(itens)
}
const dashEspecifico = async (req,res)=>{
    const dados = await dashModel.dashEspecifico(req.body)
    return res.status(200).json(dados)
}
const salesHistory = async (req,res)=>{
    const historico = await dashModel.salesHistory(req.body)
    return res.status(200).json(historico)
}
const completeSalesHistory = async(req,res)=>{
    const {id} = req.params
    const completeSale = await dashModel.completeSalesHistory(id)
    return res.status(200).json(completeSale)
}
const login = async (req,res)=>{
    const dadosLogin = await dashModel.login(req.body)
    return res.status(200).json(dadosLogin)
}
module.exports = {
    getData,
    loadData,
    loadItem,
    dashEspecifico,
    salesHistory,
    completeSalesHistory
}