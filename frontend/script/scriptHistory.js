const itensVendidos = document.querySelector('.itens-vendidos')
const filtroDias = document.querySelector('#filtroDias')
const pai = document.querySelector('#pai')
let itens = ''

const diasEmNumero = () =>{
    if(filtroDias.value == "1 dia")
        return 1
    else if(filtroDias.value == "7 dias")
        return 7
    else if (filtroDias.value == "30 dias")
        return 30
    else if (filtroDias.value == "3 meses")
        return 90
    else if (filtroDias.value == "6 meses")
        return 180
    else 
        return 360
}

const loadHistory = async () => { //funcao chamada no onchange do filtro de dias
    const days = {dia : diasEmNumero()}//passe o numero de dias como arquivo JSON

    await fetch('http://localhost:4001/historico', { //faz um post com a data JSON
        method: 'post',
        headers: {'Content-Type': 'application/json'},
        body: JSON.stringify(days)
    }).then((res)=>{ //verifica se o retorno da funcao foi de erro
        if(!res.ok){
            console.log("erro")
        }
        return res.json()
    }).then((dados)=>{ //se chegar até aqui, o retorno foi positivo. Ele ja atribui o retorno dos dados a uma variavel
        retornoDatas = dados
    })

    limpaLinhas(pai) //funcao para limpar linhas ja existentes a cada vez que a função for chamada

    let array = [] // declaração de array para guardar os dados retornados sobre a visão geral de vendas

    for(let i in retornoDatas){ //utiliza o indice "i" para percorrer no tamanho do array, ou seja, para cada item retornado
        itens  = ""
        
        var dataOriginal = new Date(retornoDatas[i].DataVenda); //cria uma nova data com o valor retornado da coluna DataVenda no indice "i" do array.
        var dia = dataOriginal.getUTCDate();
        var mes = dataOriginal.getUTCMonth() + 1; // Adicionamos 1 ao mês, pois os meses em JavaScript são baseados em zero
        var ano = dataOriginal.getUTCFullYear();
        var dataFormatada = dia + "/" + (mes < 10 ? "0" : "") + mes + "/" + ano; // pega todas as ramifiações do objeto data que fizemos e formata da maneira desejada
        
        itens = await loadDetails(retornoDatas[i].codVenda) //armazena na var os dados dos itens que compoem cada venda
            
        array.push([ // adiciona no array os dados gerais das vendas e a variavel (array) que armazena os dados dos itens ventidos
            retornoDatas[i].codVenda,
            dataFormatada,
            retornoDatas[i].ValorVenda.toLocaleString('pt-BR', {
                style: 'currency',
                currency: 'BRL'
                }),
            itens
            ])
    }

    for(let i in array){//percorre o array que contem os dados das vendas

       const [linha,cabecalho]=  createRow(//cria uma nova linha com o valor do, codigo, data e valor
            array[i][0],
            array[i][1], 
            array[i][2])  

            cabecalho.style.display = 'none'

        for(let j in array[i][3]){ //percorre o array que contem os itens 

           const detalhesVenda =  criaDetalhes(//cria uma linha para cada item com o seu, codigo, nome, quantidade e valor de venda
                array[i][3][j].codProd,
                array[i][3][j].nomeProd,
                array[i][3][j].quantidade,
                array[i][3][j].ValorVenda.toLocaleString('pt-BR', {
                    style: 'currency',
                    currency: 'BRL'
                    }),
                array[i][0]
                )

                detalhesVenda.style.display = 'none'

                linha.addEventListener('click',()=>{
                if(detalhesVenda.style.display == 'none'){
                    detalhesVenda.style.display = 'table-row'
                }
                else{
                    detalhesVenda.style.display = 'none'
                }
       })   
        } 
            linha.addEventListener('click',()=>{
                if(cabecalho.style.display == 'none'){
                    cabecalho.style.display = 'table-row'
                }
                else{
                    cabecalho.style.display = 'none'
                }
       })     
    }   
   
}
const onLoadHistory = async () => { //funcao chamada no onchange do filtro de dias
    const days = {dia : 30}//passe o numero de dias como arquivo JSON

    await fetch('http://localhost:4001/historico', { //faz um post com a data JSON
        method: 'post',
        headers: {'Content-Type': 'application/json'},
        body: JSON.stringify(days)
    }).then((res)=>{ //verifica se o retorno da funcao foi de erro
        if(!res.ok){
            console.log("erro")
        }
        return res.json()
    }).then((dados)=>{ //se chegar até aqui, o retorno foi positivo. Ele ja atribui o retorno dos dados a uma variavel
        retornoDatas = dados
    })

    limpaLinhas(pai) //funcao para limpar linhas ja existentes a cada vez que a função for chamada

    let array = [] // declaração de array para guardar os dados retornados sobre a visão geral de vendas

    for(let i in retornoDatas){ //utiliza o indice "i" para percorrer no tamanho do array, ou seja, para cada item retornado
        itens  = ""
        
        var dataOriginal = new Date(retornoDatas[i].DataVenda); //cria uma nova data com o valor retornado da coluna DataVenda no indice "i" do array.
        var dia = dataOriginal.getUTCDate();
        var mes = dataOriginal.getUTCMonth() + 1; // Adicionamos 1 ao mês, pois os meses em JavaScript são baseados em zero
        var ano = dataOriginal.getUTCFullYear();
        var dataFormatada = dia + "/" + (mes < 10 ? "0" : "") + mes + "/" + ano; // pega todas as ramifiações do objeto data que fizemos e formata da maneira desejada
        
        itens = await loadDetails(retornoDatas[i].codVenda) //armazena na var os dados dos itens que compoem cada venda
            
        array.push([ // adiciona no array os dados gerais das vendas e a variavel (array) que armazena os dados dos itens ventidos
            retornoDatas[i].codVenda,
            dataFormatada,
            retornoDatas[i].ValorVenda.toLocaleString('pt-BR', {
                style: 'currency',
                currency: 'BRL'
                }),
            itens
            ])
    }

    for(let i in array){//percorre o array que contem os dados das vendas

       const [linha,cabecalho]=  createRow(//cria uma nova linha com o valor do, codigo, data e valor
            array[i][0],
            array[i][1], 
            array[i][2])  
            
            cabecalho.style.display = 'none'

        for(let j in array[i][3]){ //percorre o array que contem os itens 

           const detalhesVenda =  criaDetalhes(//cria uma linha para cada item com o seu, codigo, nome, quantidade e valor de venda
                array[i][3][j].codProd,
                array[i][3][j].nomeProd,
                array[i][3][j].quantidade,
                array[i][3][j].ValorVenda.toLocaleString('pt-BR', {
                    style: 'currency',
                    currency: 'BRL'
                    }),
                array[i][0]
                )

                detalhesVenda.style.display = 'none'

                linha.addEventListener('click',()=>{
                if(detalhesVenda.style.display == 'none'){
                    detalhesVenda.style.display = 'table-row'
                }
                else{
                    detalhesVenda.style.display = 'none'
                }
       })   
        } 
            linha.addEventListener('click',()=>{
                if(cabecalho.style.display == 'none'){
                    cabecalho.style.display = 'table-row'
                }
                else{
                    cabecalho.style.display = 'none'
                }
       })     
    }   
   
}

const createElement = (tag, classe ='', innerHTML = '',value = '', innerText = '', classe2 = '', classe3 = '') =>{
    const element = document.createElement(tag)
  
    if(classe) //class para estilização
      element.classList.add(classe)
    if(innerHTML)
        element.innerHTML = innerHTML
    if(value)
        element.id = value
    if(innerText)
        element.innerText = innerText    
    if(classe2)
        element.classList.add(classe2)
    if(classe3)
        element.classList.add(classe3)
    
    return element
  }

const createRow = (codigo, data, valor, ) => {
    const linha = createElement(
        'tr',
        'linha',
        `<td>${codigo}</td>
         <td>${data}</td>
         <td>${valor}</td>`,
         `cod${codigo}`
    )
    pai.appendChild(linha)

    const cabecalho = createElement(
        'tr',
        'cabecalho',
        `<th>Descrição</th>
        <th>Quantidade</th>
        <th>Valor</th>`,
        '',
        '',
        'table-secondary'
    )
    pai.appendChild(cabecalho)

    return [linha, cabecalho]
}

const criaDetalhes = (codProd, nomeProd,quantidade, valorTotal,valorLinha) =>{
    const detalhes = createElement(
        'tr',
        'itens-vendidos',
        `<td>${codProd} - ${nomeProd}</td>
        <td>${quantidade}</td>
        <td>${valorTotal}</td>`,
        '',
        '',
        `valorLinha${valorLinha}`,
        'table-active'
    )
    pai.appendChild(detalhes)

   return detalhes
}

const limpaLinhas = (elemento) =>{ //funcao para limpar valores ja existentes em item 
    while(elemento.firstChild){
      elemento.removeChild(elemento.firstChild)
    }
  }

const loadDetails = async (id) =>{
    
    const res = await fetch (`http://localhost:4001/historico/${id}`)
    const itens = await res.json()
    return itens
}
