const express = require('express')
const router = express.Router()
const dashController = require('./controllers/dashController')

router.post('/data', dashController.getData)
router.post('/dataload',dashController.loadData)
router.post('/itens',dashController.loadItem)
router.post('/especifico',dashController.dashEspecifico)
module.exports = router