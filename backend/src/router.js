const express = require('express')
const router = express.Router()
const dashController = require('./controllers/dashController')
const userController = require('./controllers/userController')
const middleData = require('./middlewares/datasMiddlewares')

router.post(
    '/data', 
    middleData.validateDiaField,
    dashController.getData
    )
router.post(
    '/dataload',
    middleData.validateDiaField,
    dashController.loadData
    )
router.post(
    '/itens',
    middleData.validateCategoriaField,
    dashController.loadItem
    )
router.post(
    '/especifico',
    dashController.dashEspecifico
    )
router.post(
    '/historico',
    middleData.validateDiaField,
    dashController.salesHistory
    )

router.get(
    '/historico/:id',
    dashController.completeSalesHistory
    )
router.post(
    '/cadastro',
    userController.addUser
    )
router.post(
    '/login',
    userController.login
)

module.exports = router