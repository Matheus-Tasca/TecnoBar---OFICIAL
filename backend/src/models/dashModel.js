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

function valoresIntermediariosInteiros(valor1, valor2, quantidade) {
  
    const intermediarios = [];
    const step = (valor2 - valor1) / (quantidade + 1);
  
    for (let i = 1; i <= quantidade; i++) {
      intermediarios.push(Math.round(valor1 + i * step));
    }
  
    return intermediarios;
  }
  

const decremento = (dias) =>{
    let resultArray = []
    if(dias == 1){
        resultArray.push(1)
    }
    else if(dias == 7){
        for(let i = 1; i<7; i++){
            resultArray = valoresIntermediariosInteiros(1,7,6)
        }
    }
    else if(dias == 30){
       resultArray = valoresIntermediariosInteiros(1,30,6)
    }
    else if(dias == 90){
        resultArray = valoresIntermediariosInteiros(1,90,6)

    }
    else if(dias == 180){
        resultArray = valoresIntermediariosInteiros(1,180,6)

    }
    else{
        resultArray = valoresIntermediariosInteiros(1,360,6)
    }
    
    return resultArray
}

const dashEspecifico = async (dados) =>{
    
    const {dataType} = dados
    const {dias} = dados
    const {item} = dados
    const {categoriaItem} = dados
    let result = 0
    const valores = []

    if(dataType == 'Lucro'){
        let arrayDias = decremento(dias)
        for(let i = 1; i<arrayDias.length; i++){
            const datamin = new Date()
            let valor = arrayDias[i]
            datamin.setDate(datamin.getDate() - valor)
            
            const arrayLucro = await (await connection).query(` 
                SELECT 
                    produto.codProd, (produto.ValorVenda - produto.ValorEntrada) * COUNT(*) AS LucroTotalProduto
                FROM 
                    Venda 
                INNER JOIN 
                    produto ON Venda.codProd = produto.codProd
                WHERE
                    Venda.Data_Registro >= ?
                GROUP BY
                    produto.codProd;
            `,[datamin])
            
            result = 0
            for(let j in arrayLucro[0]){
                let temp = Number(arrayLucro[0][j].LucroTotalProduto)
               result += temp
            }
            console.log("Lucro da data "+datamin +' - '+result)
            const cont = i
            const vai = `${i} - ${result}`
            valores.push(vai)
        }
        return valores
        
    }
    else if(dataType == 'Vendas'){
        let arrayDias = decremento(dias)
        for(let i = 1; i<arrayDias.length; i++){
            const datamin = new Date()
            let valor = arrayDias[i]
            datamin.setDate(datamin.getDate() - valor)
            
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
            let totalVendas = arrayVendas[0][0].VendasTotais
            valores.push(totalVendas)
        }   
        return valores
    }
    else if(dataType == 'Faturamento'){
        let arrayDias = decremento(dias)
        for(let i = 1; i<arrayDias.length; i++){
            const datamin = new Date()
            let valor = arrayDias[i]
            datamin.setDate(datamin.getDate() - valor)
            
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

        let totalFaturamento = arrayFaturamento[0][0].FaturamentoTotalProduto
        console.log(totalFaturamento)
        valores.push(totalFaturamento) 
   }
   return valores
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