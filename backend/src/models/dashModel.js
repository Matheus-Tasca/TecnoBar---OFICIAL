const connection = require('./connection')

const getData = async (days) =>{
    const {dia} = days
    const datamin = new Date()
    datamin.setDate(datamin.getDate() - [dia])
    var lucro = 0.0
    var faturamento = 0.0

    // query para gerar o lucro de cada produto
    const arrayLucro = await (await connection).query(` 
    SELECT 
        produto.nomeProd,
        (produto.ValorVenda - produto.ValorEntrada) * COUNT(*) AS LucroTotalProduto,
         Venda.Data_Registro
    FROM 
        Venda 
    INNER JOIN 
        produto ON Venda.codProd = produto.codProd
    WHERE
        Venda.Data_Registro >= ? 
    GROUP BY
        produto.codProd;
    `,[datamin])

    // query para gerar o faturamento de cada produto
    const arrayFaturamento = await (await connection).query(`
    Select 
	    produto.nomeProd, produto.ValorVenda * (SUM(Venda.QtdProd)) as FaturamentoTotalProduto, Venda.Data_Registro 
    from
	    Venda 
    inner join 
	    produto on Venda.codProd = produto.codProd
    where
	    Venda.Data_Registro >= ?
    group by
	    produto.codProd;
    `,[datamin])
    
    // query para pegar o valor total de vendas
    const arrayVendas = await (await connection).query(`
    Select 
        count(Venda.codVenda) as VendasTotais 
    from 
        Venda 
    inner join 
        produto on produto.codProd = Venda.codProd
    where 
        Venda.Data_Registro >= ?;
    `,[datamin])

    const faturamentoReal = arrayFaturamento[0]//variavel sem o buffer gerado pelo db
    const lucroReal = arrayLucro[0]//variavel sem o buffer gerado pelo db
    const vendasReal = arrayVendas[0]//variavel sem o buffer gerado pelo db

    for (let i in lucroReal){//loop para adicionar o lucro de cada produto a uma unica variavel
        lucro +=lucroReal[i].LucroTotalProduto
    }
    for(let i in faturamentoReal){//loop para adicionar o faturamento de cada produto a uma unica variavel
        faturamento+=faturamentoReal[i].FaturamentoTotalProduto;
    }

    const datas = [lucro, vendasReal[0].VendasTotais ,faturamento]
    return datas
}
const loadData = async (days) =>{
    const {dia} = days
    const datamin = new Date()
    datamin.setDate(datamin.getDate() - [dia])
    var lucro = 0.0
    var faturamento = 0.0

    // query para gerar o lucro de cada produto
    const arrayLucro = await (await connection).query(` 
    SELECT 
        produto.nomeProd,
        (produto.ValorVenda - produto.ValorEntrada) * COUNT(*) AS LucroTotalProduto,
         Venda.Data_Registro
    FROM 
        Venda 
    INNER JOIN 
        produto ON Venda.codProd = produto.codProd
    WHERE
        Venda.Data_Registro >= ? 
    GROUP BY
        produto.codProd;
    `,[datamin])

    // query para gerar o faturamento de cada produto
    const arrayFaturamento = await (await connection).query(`
    Select 
	    produto.nomeProd, produto.ValorVenda * (SUM(Venda.QtdProd)) as FaturamentoTotalProduto, Venda.Data_Registro 
    from
	    Venda 
    inner join 
	    produto on Venda.codProd = produto.codProd
    where
	    Venda.Data_Registro >= ?
    group by
	    produto.codProd;
    `,[datamin])
    
    // query para pegar o valor total de vendas
    const arrayVendas = await (await connection).query(`
    Select 
        count(Venda.codVenda) as VendasTotais 
    from 
        Venda 
    inner join 
        produto on produto.codProd = Venda.codProd
    where 
        Venda.Data_Registro >= ?;
    `,[datamin])

    const faturamentoReal = arrayFaturamento[0]//variavel sem o buffer gerado pelo db
    const lucroReal = arrayLucro[0]//variavel sem o buffer gerado pelo db
    const vendasReal = arrayVendas[0]//variavel sem o buffer gerado pelo db

    for (let i in lucroReal){//loop para adicionar o lucro de cada produto a uma unica variavel
        lucro +=lucroReal[i].LucroTotalProduto
    }
    for(let i in faturamentoReal){//loop para adicionar o faturamento de cada produto a uma unica variavel
        faturamento+=faturamentoReal[i].FaturamentoTotalProduto;
    }
    const datas = [lucro, vendasReal[0].VendasTotais ,faturamento]
    return datas
}

const loadItem = async (categoria)=>{
    const {tipo} = categoria
    const produtos = await (await connection).query(`
    select 
        produto.nomeProd, 
        produto.codProd 
    from 
        produto 
    where 
        produto.codCategoria = ?;

    `,
    [tipo]
    )
    return produtos[0]
}
/*
const salesHistory = async (days)=>{
    const {dia} = days
    const datamin = new Date()
    datamin.setDate(datamin.getDate() - [dia])
    const dataSale = await (await connection).query(`
    SELECT 

    `)
}
*/
module.exports = {
    getData,
    loadData,
    loadItem
}