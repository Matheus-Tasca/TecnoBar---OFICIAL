const connection = require('./connection')
const { subWeeks, subMonths ,format } = require('date-fns')

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

const salesHistory = async (days)=>{ 
    const {dia} = days
    const datamin = new Date()
    datamin.setDate(datamin.getDate() - [dia])
    const dataSale = await (await connection).query(`
    select 
        Venda.codVenda,Venda.Data_Registro as DataVenda, SUM(produto.valorVenda * Venda.QtdProd) as ValorVenda 
    from 
        Venda 
    inner join 
        produto on Venda.codProd = produto.codProd 
    where   Venda.Data_Registro >= ? 
        group by Venda.codVenda;
    `,[datamin])

    console.log(datamin)
    return dataSale[0]
}

const completeSalesHistory = async (id)=>{
    const saleDetails = await (await connection).query(`
        select 
            produto.codProd, produto.nomeProd, Venda.QtdProd as quantidade, produto.valorVenda * Venda.QtdProd as ValorVenda 
        from    
            Venda 
        inner join 
            produto on Venda.codProd = produto.codProd 
        where 
            Venda.codVenda = ?;
    `,[id])
    
    return saleDetails[0]
}

const decremento = (dias) =>{
    let resultArray = []
    if(dias == 1){
        resultArray.push(1)
        return resultArray
    }
    else if(dias == 7){
        for(let i = 1; i<7; i++){
            resultArray.push(i)
        }
        return resultArray
    }
    else if(dias == 30){
        for(let i = 1; i<30; i+=6){
            resultArray.push(i)
        }
        return resultArray
    }
    else if(dias == 90){
        for(let i = 1; i<90;i+=15){
            resultArray.push(i)
        }
        return resultArray
    }
    else if(dias == 180){
        for(let i = 1; i<160; i+=160){
            resultArray.push(i)
        }
        return resultArray
    }
    else{
        for(let i = 0; i<360; i+=60){
            resultArray.push(i)
        }
        return resultArray
    }
}

const dashEspecifico = async (dados) =>{
    
    const {dias} = dados
    const {dataType} = dados
    const {item} = dados
    const {categoriaItem} = dados
    const datamin = new Date()
    const valores = []

    if(dataType == 'Lucro'){
        for(let i in decremento(dias)){
            datamin.setDate(datamin.getDate() - [decremento(dias)[i]])
                const arrayLucro = await (await connection).query(` 
            SELECT 
                (produto.ValorVenda - produto.ValorEntrada) * COUNT(*) AS LucroTotalProduto
            FROM 
                Venda 
            INNER JOIN 
                produto ON Venda.codProd = produto.codProd
            WHERE
                Venda.Data_Registro >= ? 
            GROUP BY
                produto.codProd;
            `,[datamin])
            valores.push(arrayLucro[0])
            console.log(datamin)
        }
        console.log(valores)
    }
    else if(dataType == 'Vendas'){

    }
    else if(dataType == 'Faturamento'){

    }

    
}

module.exports = {
    getData,
    loadData,
    loadItem,
    dashEspecifico,
    salesHistory,
    completeSalesHistory
}