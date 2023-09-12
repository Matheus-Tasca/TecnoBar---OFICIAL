const ctx = document.querySelector('#line-chart')
const botao = document.querySelector('#gerar')
const containerChart = document.querySelector('#containerChart')
const dataType = Array.from(document.getElementsByClassName('dado')) //array tipos de graficos(linha, barra...)
const chartsType = Array.from(document.getElementsByClassName('tipo'))//array tipo dado (lucro, vendas...)
const consumableType = Array.from(document.getElementsByClassName('consumable'))//array tipo de consumivel(bebida,alimentos....)
const itemType = Array.from(document.getElementsByClassName('consumivel'))
const dateInitial = document.querySelector('#dataInicio')
const dateFinal = document.querySelector('#dataFinal')
const categorias = document.querySelector('#categorias')
const pai = document.querySelector('#apendaqui')
let chart
var dados = []
let tipoGraph = ''
let dadoSelected = ''
let cat = ''
let arqType = ''
let cont = 0 


const createElement = (tag, classe ='',innerText = '', innerHTML = '',value = '', classe2 = '') =>{
  const element = document.createElement(tag)

  if(classe) //class para estilização
    element.classList.add(classe)
  if(classe2) //class para array de produtos
    element.classList.add(classe2)
  if(innerText)
      element.innerText = innerText
  if(innerHTML)
      element.innerHTML = innerHTML
  if(value)
      element.value = value    
  return element
}

const loadItem = async (valor)=>{ //retorna todos os itens da categoria com base no valor passado em 'valor'
  const categoria = {tipo: valor}
  await fetch ('http://localhost:4001/itens',{
    method: 'post',
    headers: {'Content-Type': 'application/json'},
    body: JSON.stringify(categoria)
  }).then((res)=>{
    if(!res.ok){
      console.log('ERRO')
    }
    return res.json()
  }).then((dados)=>{
    retorno = dados
  })

  limpaSelect(pai) //funcao para caso ele selecione uma opçaõ de categoria e depois mude, os itens ja inseridos sejam limpados
  
  let item = retorno
  console.log(item)

  for(let i in item){ //chama a função de criar item para cada elemento retornado do array
    createOptions(item[i].nomeProd, item[i].codProd)
    configura()
  }

  itemType.forEach(item =>{
    item.addEventListener("click",function () {
      selectItemType()
    })
  })
}

const createOptions = (nomeProd,valor)=>{ //cria item e adiciona a lista
  const item1 = createElement(
    'li',
    'item',
    '',
    `
      <span class="checkbox">
        <i class="fa-solid fa-check check-icon"></i> 
      </span><span class="item-text">
        ${nomeProd}
      </span>
     `,
     valor,
     'consumivel'
     )
  pai.appendChild(item1)
  itemType.push(item1)
  configura()
}

const limpaSelect = (elemento) =>{ //funcao para limpar valores ja existentes em item 
  while(elemento.firstChild){
    elemento.removeChild(elemento.firstChild)
  }
}

const configura = () =>{
  const selectBtns = document.querySelectorAll(".select-btn");

  selectBtns.forEach(function (btn) {
    btn.addEventListener("click", function () {
      const currentItem = this;
      const listItems = currentItem.nextElementSibling;

      // Fechar a lista de itens ao selecionar uma opção
      if (currentItem.classList.contains("open")) {
        listItems.style.display = "none";
      } else {
        // Fechar outras listas abertas
        selectBtns.forEach(function (otherBtn) {
          if (otherBtn !== currentItem) {
            otherBtn.classList.remove("open");
            otherBtn.nextElementSibling.style.display = "none";
          }
        });

        listItems.style.display = "block";
      }

      currentItem.classList.toggle("open");
    });
  });

  // Adicionar event listener para as opções da lista
  const optionItems = document.querySelectorAll(".list-items .item");

  optionItems.forEach(function (item) {
    item.addEventListener("click", function (event) {
      event.stopPropagation(); // Impedir o evento de propagação até o botão
      const selectedText = item.querySelector(".item-text").textContent;
      const selectBtn = item.parentElement.previousElementSibling;
      const btnText = selectBtn.querySelector(".btn-text");

      btnText.textContent = selectedText;
      selectBtn.classList.remove("open");
      item.parentElement.style.display = "none";
    });
  });


  const items = document.querySelectorAll(".item");
  let selectedItem = null;
  
  items.forEach((item) => {
    item.addEventListener("click", () => {
      if (selectedItem === item) {
        item.classList.remove("checked");
        selectedItem = null;
      } else {
        items.forEach((otherItem) => {
          otherItem.classList.remove("checked");
        });
        item.classList.add("checked");
        selectedItem = item;
      }

      let checked = document.querySelectorAll(".checked");
      let btnText = item.closest(".containerForm").querySelector(".btn-text");

      if (checked.length > 0) {
        btnText.textContent = `${selectedItem.textContent}`;
      } else {
        btnText.textContent = "Selecione";
      }
    });
  });
}

  const selectChartType = (clickedChart) => { //adicionar selected a um elemeto do array chartsType
    chartsType.forEach(chart => {
        if (chart === clickedChart) {
            chart.classList.add("selected")
        } else {
            chart.classList.remove("selected")
        }
      })
  }

  const selectDataType = (clickedData) => {//adicionar selected a um elemeto do array dataType 
    dataType.forEach(data => {
        if (data === clickedData) {
            data.classList.add("selected")
        } else {
            data.classList.remove("selected")
        }
      })
  }

  const selectConsumableType = (clickedConsumable) => {//dicionar selected a um elemeto do array consumableType
    consumableType.forEach(consumable => {
        if (consumable === clickedConsumable) {
          consumable.classList.add("selected")
        } else {
          consumable.classList.remove("selected")
        }
      })
  }

  const selectItemType = () => {
    itemType.forEach(item => {
      let classe = item.classList
      if(classe.contains("checked")){
        console.log(item.value)
      }
    })
  }

  chartsType.forEach(chart => { //chamada da funcao ao clicar num elemnto do array
    chart.addEventListener("click", function() {
        selectChartType(this)
      })
  })

  dataType.forEach(data => {//chamada da funcao ao clicar num elemnto do array
    data.addEventListener("click", function() {
        selectDataType(this)
      })
  })
  
  consumableType.forEach(consumable => {//chamada da funcao ao clicar num elemnto do array
    consumable.addEventListener("click", function() {
        selectConsumableType(this)
      })
  })




function getSelectedOptions() {
  if (chart) {// regera o grafico
    chart.destroy()
    chart = null
  }
  var dataIncio = dateInitial.value
  var dataFinal = dateFinal.value
  var selectedOptions = document.querySelectorAll('.selecionavel.selected')
  var valoresSelecionados = Array.from(selectedOptions).map(function (option) { //array dos valores selecionados
    return option.getAttribute('data-value')
  })
  
  console.log(dataFinal, dataIncio)

  if(dataIncio === ""){
    alert("Insira uma data inicial!")
    document.querySelector('#dataInicio').focus()
  }
  else if(dataFinal === ""){
    alert("Insira uma data final!")
    document.querySelector('#dataFinal').focus()
  }
  else if(dataFinal < dataIncio){
    alert("A data final não pode ser menor que a data inicial.")
  }/*
  else if (tipoGraph == null || dadoSelected == null || cat == null)
    alert("Preencha todos os campos!") 
    */
  else{
  const [ tipoGraph,dadoSelected, cat] = valoresSelecionados
  console.log(valoresSelecionados)
  const options = {
    responsive: true,
    scales: {
      y: {
        beginAtZero: true
      }
    }
  }

  var data = {
    labels: ['Janeiro', 'Fevereiro', 'Março', 'Abril', 'Maio', 'Junho'],
    datasets: [{
      label: dadoSelected + " de " + cat,
      data: [12, 14, 18, 10, 12, 16],
      backgroundColor: [
        'rgb(255, 99, 132)',
        'rgb(54, 162, 235)',
        'rgb(255, 205, 86)'
      ],
      borderWidth: 4,
      borderColor: 'rgb(0,0,0)'
    }]
  }

  chart = new Chart(ctx, {
    type: tipoGraph.toString(),
    data: data,
    options: options
  })
  var canva = document.querySelector('#containerChart')
  canva.style.display = 'flex'
}
}

botao.addEventListener('click',() =>{
  getSelectedOptions()
})

configura()