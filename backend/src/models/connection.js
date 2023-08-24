const mysql = require('mysql2/promise')//importa mysql instalado no package.json
require('dotenv').config()
const connection = mysql.createConnection({
    host: process.env.MYSQL_HOST,
    user: process.env.MYSQL_USER,
    password: process.env.MYSQL_PASSWORD,
    database: process.env.MYSQL_DB
})//configura e cria a coneccao



module.exports = connection //exporta para conseguir ser requerida depois