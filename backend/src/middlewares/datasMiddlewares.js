const validateDiaField = (req,res,next) =>{
    const {body} = req

    if(body.dia == undefined){
        return res.status(400).json({message: 'dia é obrigatório!'})
    }
    if(body.dia == ''){
        return res.status(400).json({message: 'dia não deve ser vazio!'})
    }
    next()
}

const validateCategoriaField = (req,res,next) =>{
    const {body} = req

    if(body.tipo == undefined){
        return res.status(400).json({message: 'tipo é obrigatório!'})
    }
    if(body.tipo == ''){
        return res.status(400).json({message: 'tipo não deve ser vazio!'})
    }
    next()
}

module.exports = {
    validateDiaField,
    validateCategoriaField
}