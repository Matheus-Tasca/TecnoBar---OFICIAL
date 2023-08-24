const app = require('./app')
require('dotenv').config()
const port = process.env.PORT
app.listen(port, ()=> console.log(`rodando em ${port}`))