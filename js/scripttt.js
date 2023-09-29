let array = []
let array2 = []

function mostrar(){
    let numeros = document.querySelector(".numeros").value
    let listar = document.querySelector(".listar")
    let continuar = true
    if(numeros == ""){
        listar.innerHTML += `<span>Preencher os campos</span>`
        continuar = false
    }
    listar.innerHTML = ""
    if(continuar == true){

        for(let i = 0; i < array.length+1; i++){
            array.push(numeros)
            array2.push(numeros)  
            listar.innerHTML += `<span>${array}</span>`
            break
            
        }
    }

}

function posicao(){
    let pmostrar = document.querySelector(".pmostrar")
    let p = document.querySelector(".p").value
    pmostrar.innerHTML =""
    for(let i = 0; i < array.length; i++){
        if(p == array[i]){
            
            pmostrar.innerHTML += `<span>${i}  </span>`
        }
    }
}


function excluir(){
    let remover = document.querySelector(".remover").value
    let pmostrar = document.querySelector(".pmostrar")
    let listar = document.querySelector(".listar")
    for(let i = 0; i < array.length; i++){
        if (remover == array[i]){
            array.splice(i, 1)
            listar.innerHTML = ""
            pmostrar.innerHTML =""
            listar.innerHTML += `<span>${array}</span>`
        }
    }
}

function subs(){
    let subss = document.querySelector(".subss").value
    let mudar = document.querySelector(".mudar").value
    let listar = document.querySelector(".listar")
    for(let i = 0; i < array.length; i++){
        if(subss == array[i]){
            array[i] = mudar
            listar.innerHTML = ""
            listar.innerHTML += `<span>${array}</span>`

        }
    }

}


function ocre(){
    let ordenar = document.querySelector(".ordenar")

    ordenar.innerHTML = `<span>${array.sort(function(a, b){return a - b})}</span>`
}

function odcre(){
    let dec = document.querySelector(".dec")
    dec.innerHTML = `<span>${array.sort(function(a, b){return b - a})}</span>`
}

function normal(){
    let normal = document.querySelector(".normal")

    normal.innerHTML = `<span>${array2}</span>`

}