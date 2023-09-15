const linha = document.querySelector('.linha')
const itensVendidos = document.querySelector('.itens-vendidos')
const cabecalho = document.querySelector('.cabecalho')
const filtroDias = document.querySelector('#filtroDias')
const pai = document.querySelector('#pai')
linha.addEventListener("click",()=>{
    if((cabecalho.style.display === 'none') && (itensVendidos.style.display === 'none')){
    cabecalho.style.display = 'table-row'
    itensVendidos.style.display = 'table-row'
    }
    else{
        cabecalho.style.display = 'none'
        itensVendidos.style.display = 'none'
    }
})

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
    for(let i in retornoDatas){
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

        array.push([
            retornoDatas[i].codVenda,
            dataFormatada,
        valorFormatado])
    }

    for(let i in array){
        createRow(array[i][0], array[i][1], array[i][2])
        }
    
}

const createElement = (tag, classe ='', innerHTML = '',value = '') =>{
    const element = document.createElement(tag)
  
    if(classe) //class para estilização
      element.classList.add(classe)
    if(innerHTML)
        element.innerHTML = innerHTML
    if(value)
        element.id = value    
    return element
  }

const createRow = (codigo, data, valor) => {
    const linha = createElement(
        'tr',
        'linha',
        `<td>${codigo}</td>
         <td>${data}</td>
         <td>${valor}</td>`,
         codigo
    )
    pai.appendChild(linha)
}

const limpaLinhas = (elemento) =>{ //funcao para limpar valores ja existentes em item 
    while(elemento.firstChild){
      elemento.removeChild(elemento.firstChild)
    }
  }