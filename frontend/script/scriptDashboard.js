var filtroDias = document.querySelector('#filtroDias')
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

const showData = async (luc, ven, fat) => {
    const vendas = document.querySelector('#vendas')
    const faturamento = document.querySelector('#faturamento')
    const lucro = document.querySelector('#lucro')
    const tempo = document.querySelectorAll('.tempo')
    const tempoValue = filtroDias.value
    console.log(tempo)

    tempo.forEach((elemento)=>{
        elemento.innerText = tempoValue
    })
    vendas.innerText = ven
    faturamento.innerText = fat
    lucro.innerText = luc
}

const datas = async () => {
    const days = {dia: diasEmNumero()}

    await fetch('http://localhost:4001/data', {
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

    let lucro = retornoDatas[0]
    let venda = retornoDatas[1]
    let faturamento = retornoDatas[2]
    showData(
        lucro.toFixed(2),
        venda,
        faturamento.toFixed(2))
}

const datasLoad = async () => {
    const days = {dia: 30}

    await fetch('http://localhost:4001/dataload', {
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
    let lucro = retornoDatas[0]
    let venda = retornoDatas[1]
    let faturamento = retornoDatas[2]
    showData(
        lucro.toFixed(2),
        venda,
        faturamento.toFixed(2))
}
filtroDias.addEventListener('change', datas)