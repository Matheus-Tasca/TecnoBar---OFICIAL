var ctx = document.querySelector('#line-chart')
var dados = []
let tipoGraph = ''
let dadoSelected = ''
let cat = ''
let arqType = ''

document.addEventListener("DOMContentLoaded", function () {
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

  //const selectBtnArq = document.querySelectorAll(".select-btn-arq");
  // selectBtnsArq.forEach(function (btn) {
  //   btn.addEventListener("click", function () {
  //     const currentItemArq = this;
  //     const listItemsArq = currentItem.nextElementSibling;

  //     // Fechar a lista de itens ao selecionar uma opção
  //     if (currentItem.classList.contains("open")) {
  //       listItems.style.display = "none";
  //     } else {
  //       // Fechar outras listas abertas
  //       selectBtnsArq.forEach(function (otherBtn) {
  //         if (otherBtn !== currentItem) {
  //           otherBtn.classList.remove("open");
  //           otherBtn.nextElementSibling.style.display = "none";
  //         }
  //       });

  //       listItems.style.display = "block";
  //     }

  //     currentItem.classList.toggle("open");
  //   });
  // });

  // // Adicionar event listener para as opções da lista
  // const optionItemsArq = document.querySelectorAll(".list-items .item");
  // optionItems.forEach(function (item) {
  //   item.addEventListener("click", function (event) {
  //     event.stopPropagation(); // Impedir o evento de propagação até o botão
  //     const selectedTextArq = item.querySelector(".item-text").textContent;
  //     const selectBtnArq = item.parentElement.previousElementSibling;
  //     const btnTextArq = selectBtn.querySelector(".btn-text");

  //     btnText.textContent = selectedText;
  //     selectBtn.classList.remove("open");
  //     item.parentElement.style.display = "none";
  //   });
  // });

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
});

function toggleOption(option) {
  option.classList.toggle('selected');
}

function getSelectedOptions() {
  var selectedOptions = document.querySelectorAll('.selecionavel.selected')
  var valoresSelecionados = Array.from(selectedOptions).map(function (option) {
    return option.getAttribute('data-value')
  })

  var dataIncio = document.querySelector('#dataInicio').value
  var dataFinal = document.querySelector('#dataFinal').value

  console.log(dataIncio,dataFinal)

  if(dataIncio === ""){
    alert("Insira uma data inicial!")
    document.querySelector('#dataInicio').focus()
  }
  else if(dataFinal === ""){
    alert("Insira uma data final!")
    document.querySelector('#dataFinal').focus()
  }
  else if (tipoGraph == null || dadoSelected == null || cat == null)
    alert("Preencha todos os campos!") 
  else{
  console.log(valoresSelecionados)
  const [tipoGraph, dadoSelected, cat] = valoresSelecionados

  

  var options = {
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
      borderWidth: 4,
      borderColor: 'rgb(0,0,0)'
    }]
  }

  new Chart(ctx, {
    type: tipoGraph.toString(),
    data: data,
    options: options
  })

  var canva = document.querySelector('#containerChart')
  canva.style.display = 'flex'
}
}

