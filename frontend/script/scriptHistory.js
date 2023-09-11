const linha = document.querySelector('.linha')
const itensVendidos = document.querySelector('.itens-vendidos')
const cabecalho = document.querySelector('.cabecalho')

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