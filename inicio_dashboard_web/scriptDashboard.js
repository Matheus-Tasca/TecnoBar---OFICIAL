function dados(opcao){
    const venda = document.querySelector("#venda");
    const lucro = document.querySelector("#lucro");
    const faturamento = document.querySelector("#faturamento");

    switch (opcao){
        case '1dia':{
            venda.innerHTML = "100";
            lucro.innerHTML = "R$ 5678";
            faturamento.innerHTML = "R$ 90";
            $('.tituloCard').text('1 Dia');    
            break;
        }
        case '7dias':{
            venda.innerHTML = "700";
            lucro.innerHTML = "R$ 5234,54";
            faturamento.innerHTML = "R$ 1232.00";
            $('.tituloCard').text('7 Dias')
            break;
        }
        case '30dias':{
            venda.innerHTML = "2.000";
            lucro.innerHTML = "R$ 2.456";
            faturamento.innerHTML = "R$ 1.234";
            $('.tituloCard').text('30 Dias')
            break;
        }
        case '3messes':
            venda.innerHTML = "12.000"
            lucro.innerHTML = "R$ 5.000"
            faturamento.innerHTML = "R$ 15.000"
            $('.tituloCard').text('3 meses')
            break;
        case '6messes':{
            venda.innerHTML = "24.000";
            lucro.innerHTML = "R$ 22.000";
            faturamento.innerHTML = "R$ 55.000";
            $('.tituloCard').text('6 meses')
            break;
        }
        case '1ano':
            venda.innerHTML = "44.000"
            lucro.innerHTML = "R$ 55.000"
            faturamento.innerHTML = "R$ 90.000"
            $('.tituloCard').text('1 ano')
            break;
    }
}
