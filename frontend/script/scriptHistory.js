const linha = document.querySelector('.linha')
const itensVendidos = document.querySelector('.itens-vendidos')
const cabecalho = document.querySelector('.cabecalho')

linha.addEventListener("click",()=>{
    cabecalho.style.display = 'table-row'
    itensVendidos.style.display = 'table-row'
})