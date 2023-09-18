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
let primeiraLinha = ''
let detalhesLinha = ''
const loadHistory = async () => {
    const days = {dia : diasEmNumero()}

    await fetch('http://localhost:4001/historico', {
        method: 'post',
        headers: {'Content-Type': 'application/json'},
        body: JSON.stringify(days)
    }).then((res)=>{
        if(!res.ok){
            console.log("erro")
        }
        return res.json()
    }).then((dados)=>{
        retornoDatas = dados
    })
    limpaLinhas(pai)
    let array = []
    let arrayItens = []
    for(let i in retornoDatas){
        itens  = ""
        
        var dataOriginal = new Date(retornoDatas[i].DataVenda);

        var dia = dataOriginal.getUTCDate();
        var mes = dataOriginal.getUTCMonth() + 1; // Adicionamos 1 ao mês, pois os meses em JavaScript são baseados em zero
        var ano = dataOriginal.getUTCFullYear();
        var dataFormatada = dia + "/" + (mes < 10 ? "0" : "") + mes + "/" + ano;
        
        var valorOriginal = retornoDatas[i].ValorVenda;

        var valorFormatado = valorOriginal.toLocaleString('pt-BR', {
        style: 'currency',
        currency: 'BRL'
        })

        itens = await loadDetails(retornoDatas[i].codVenda)


        arrayItens.push(itens)
            
        array.push([
            retornoDatas[i].codVenda,
            dataFormatada,
            valorFormatado,
            itens
         // arrayItens
    ])
    }
    

    for(let i in array){
        primeiraLinha = ''
        primeiraLinha = createRow(
            array[i][0],
            array[i][1], 
            array[i][2])  

        for(let j in array[i][3]){
            detalhesLinha = ''
          detalhesLinha = criaDetalhes(
                array[i][3][j].codProd,
                array[i][3][j].nomeProd,
                array[i][3][j].quantidade,
                array[i][3][j].ValorVenda.toLocaleString('pt-BR', {
                    style: 'currency',
                    currency: 'BRL'
                    }),
                array[i][3][j].codProd
                )
        } 

        var teste = document.querySelector(`#cod${array[i][0]}`)
        var details = document.querySelector(`#valor${array[i][0]}`)
        console.log(details)
        teste.addEventListener('click',()=>{
            details.style.display = 'block'
        })
    }   
}

const onLoadHistory = async () => {
    const days = {dia : 30}

    await fetch('http://localhost:4001/historico', {
        method: 'post',
        headers: {'Content-Type': 'application/json'},
        body: JSON.stringify(days)
    }).then((res)=>{
        if(!res.ok){
            console.log("erro")
        }
        return res.json()
    }).then((dados)=>{
        retornoDatas = dados
    })
    limpaLinhas(pai)
    let array = []
    let arrayItens = []
    for(let i in retornoDatas){
        itens  = ""
        
        var dataOriginal = new Date(retornoDatas[i].DataVenda);

        var dia = dataOriginal.getUTCDate();
        var mes = dataOriginal.getUTCMonth() + 1; // Adicionamos 1 ao mês, pois os meses em JavaScript são baseados em zero
        var ano = dataOriginal.getUTCFullYear();
        var dataFormatada = dia + "/" + (mes < 10 ? "0" : "") + mes + "/" + ano;
        
        var valorOriginal = retornoDatas[i].ValorVenda;

        var valorFormatado = valorOriginal.toLocaleString('pt-BR', {
        style: 'currency',
        currency: 'BRL'
        })

        itens = await loadDetails(retornoDatas[i].codVenda)


        arrayItens.push(itens)
            
        array.push([
            retornoDatas[i].codVenda,
            dataFormatada,
            valorFormatado,
            itens
         // arrayItens
    ])
    }
    
    for(let i in array){

        createRow(
            array[i][0],
            array[i][1], 
            array[i][2])  

        for(let j in array[i][3]){

            criaDetalhes(
                array[i][3][j].codProd,
                array[i][3][j].nomeProd,
                array[i][3][j].quantidade,
                array[i][3][j].ValorVenda.toLocaleString('pt-BR', {
                    style: 'currency',
                    currency: 'BRL'
                    })
                )
        } 
    }   
}


const createElement = (tag, classe ='', innerHTML = '',value = '', innerText = '', classe2 = '') =>{
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

    cabecalho.style.display = 'none'

    linha.addEventListener("click",()=>{
        if((cabecalho.style.display === 'none')){
            cabecalho.style.display = 'table-row'
        }
        else{
            cabecalho.style.display = 'none'
        }
    })
}

const criaDetalhes = (codProd, nomeProd,quantidade, valorTotal) =>{
    const detalhes = createElement(
        'tr',
        'itens-vendidos',
        `<td>${codProd} - ${nomeProd}</td>
        <td>${quantidade}</td>
        <td>${valorTotal}</td>`,
        `valor${codProd}`,
        '',
        'table-active'
    )
    pai.appendChild(detalhes)

   
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