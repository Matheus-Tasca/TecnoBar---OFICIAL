function dados(opcao){
    const venda = document.querySelector("#venda");
    const lucro = document.querySelector("#lucro");
    const faturamento = document.querySelector("#faturamento");

    switch (opcao){
        case '1dia':{
            venda.innerHTML = "1234";
            lucro.innerHTML = "5678";
            faturamento.innerHTML = "90";
            break;
        }
        case '7dias':{
            venda.innerHTML = "1111111111";
            lucro.innerHTML = "222222222";
            faturamento.innerHTML = "33333333";
            break;
        }
        case '30dias':{
            venda.innerHTML = "100000";
            lucro.innerHTML = "40.7b";
            faturamento.innerHTML = "99999";
            break;
        }
        case '3messes':
            venda.innerHTML = "600 m"
            lucro.innerHTML = "19"
            faturamento.innerHTML = "1"
            break;
        case '6messes':{
            venda.innerHTML = "666";
            lucro.innerHTML = "66.6 b";
            faturamento.innerHTML = "6.66 m";
            break;
        }
        case '1ano':
            venda.innerHTML = "4444 m"
            lucro.innerHTML = "1 b"
            faturamento.innerHTML = "1.6 m"
            break;
    }
}
