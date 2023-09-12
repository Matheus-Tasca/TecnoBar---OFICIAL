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
/*AGUARDANDO RESTRUTURAÇÃO DO DB
const salesHistory = async (days)=>{ 
    const {dia} = days
    const datamin = new Date()
    datamin.setDate(datamin.getDate() - [dia])
    const dataSale = await (await connection).query(`
    SELECT 

    `)
}
*/
const formataDatas = (datas) =>{
    const {inicio} = datas
    const {fim} = datas

    const inicioArray = inicio.split('-')
    const fimArray = fim.split('-')

    const anoInicio = parseInt(inicioArray[0])
    const mesInicio = parseInt(inicioArray[1]) - 1
    const diaIncio = parseInt(inicioArray[2])
    const anoFim = parseInt(fimArray[0])
    const mesFim = parseInt(fimArray[1]) - 1
    const diasFim = parseInt(fimArray[2])

    const objectDataIncio = new Date(anoInicio, mesInicio, diaIncio)
    const objectDataFim = new Date(anoFim,mesFim,diasFim)

    const anoFormatadoIncio = objectDataIncio.getFullYear()
    const mesFormatadoIncio = (objectDataIncio.getMonth()+1).toString().padStart(2,'0')
    const diaFormatadoIncio = objectDataIncio.getDate().toString().padStart(2,'0')
    const anoFormatadoFim = objectDataFim.getFullYear()
    const mesFormatadoFim = (objectDataFim.getMonth()+1).toString().padStart(2,'0')
    const diaFormatadoFim = objectDataFim.getDate().toString().padStart(2,'0')

    const inicioFormatado = `${anoFormatadoIncio}-${mesFormatadoIncio}-${diaFormatadoIncio}`
    const fimFormatado = `${anoFormatadoFim}-${mesFormatadoFim}-${diaFormatadoFim}`

    const data = new Date()
    const ano = data.getFullYear()
    const mes = (data.getMonth()+1).toString().padStart(2,'0')
    const dia = data.getDate().toString().padStart(2,'0')

    const dataFormatada = `${ano}-${mes}-${dia}`

    
    const datasJSON = {
       "inicio" : inicioFormatado,
        "fim" : fimFormatado,
        "dataAtual" : dataFormatada,
        "mesComeco" : mesFormatadoIncio,
        "mesFim" : mesFormatadoFim
    }
    return datasJSON
}
const dashEsp = (datas) =>{
    var nomeMes
    const retorno = formataDatas(datas)
    const {dataInicio} = retorno
    const {dataFim} = retorno
    const {dataAtual} = retorno
    const {mesComeco} = retorno
    const {mesFim} = retorno

    if(mesComeco == '01')
        var nomeMes = 'Janeiro'
    else if(mesComeco == '02')
        var nomeMes = 'Fevereiro'
    else if(mesComeco == '03')
        var nomeMes = 'Março'
    else if(mesComeco == '04')
        var nomeMes = 'Abril'
    else if(mesComeco == '05')
        var nomeMes = 'Maio'
    else if(mesComeco == '06')
        var nomeMes = 'Junho'
    else if(mesComeco == '07')
        var nomeMes = 'Julho'
    else if(mesComeco == '08')
        var nomeMes = 'Agosto'
    else if(mesComeco == '09')
        var nomeMes = 'Setembro'    
    else if(mesComeco == '10')
        var nomeMes = 'Outubro'
    else if(mesComeco == '11')
        var nomeMes = 'Novembro'
    else if(mesComeco == '12')
        var nomeMes = 'Dezembro'

        
    console.log(nomeMes)
    /*
    RETORNAR 
        -VALOR DO MES (PARA COLOCAR NO RODAPE)
        -SUBDIVIDIR DATAS PARA AS LABELS
        -LABELS
    */
}
module.exports = {
    getData,
    loadData,
    loadItem,
    dashEsp
}