
/*let lista = document.getElementById("lista")



    console.log(lista)

    function mostrar(){
        lista.style.display = "block"
    }

    function fora(){
        lista.style.display = "none"
    }
*/


function midade(){

    let idade = document.querySelector("#idade").value
    let mensagem = document.querySelector(".breno")
    if(idade >= 18){
        
        mensagem.innerHTML = "MAIOR DE IDADE"
       
        
    }
    else{
        mensagem.innerHTML = "MENOR DE IDADE"
    }
}


function maluno(){

    let mensagem = document.querySelector(".breno")
    
    let nota1 = parseFloat (document.querySelector("#nota1").value)
    let nota2 = parseFloat (document.querySelector("#nota2").value)
    let nota3 = parseFloat (document.querySelector("#nota3").value)

    let frequencia = document.querySelector("#frequencia").value

    let media = (nota1 + nota2 + nota3)/3

    if(media > 7 && frequencia > 7){
        mensagem.innerHTML = "APROVADO"
    }
    else{
        mensagem.innerHTML = "REPROVADO"
    }


}


function mimc(){
    let mensagem = document.querySelector(".breno")

    let pesos = parseFloat (document.querySelector("#peso").value)
    let alturas = parseFloat (document.querySelector("#altura").value)

    let alturasq = alturas * alturas
    let imc = pesos / alturasq

    if (imc < 17){
        mensagem.innerHTML = "Muito abaixo do peso"
    }
    else if(imc >= 17 && imc <= 18.49){
        mensagem.innerHTML = "Abaixo do peso"
    }
    else if(imc >= 18.5 && imc <= 24.99){
        mensagem.innerHTML = "Peso normal"
    }
    else if(imc >= 25 && imc <= 29.99){
        mensagem.innerHTML = "Acima do peso"
    }
    else if(imc >= 30 && imc <= 34.99){
        mensagem.innerHTML = "Obesidade I"
    }
    else if(imc >= 35 && imc <= 39.99){
        mensagem.innerHTML = "Obesidade II(Severa)"
    }
    else if(imc > 40){
        mensagem.innerHTML = "Obesidade III(mórbida)"
    }
}


function cargooo(){

    let mensagem = document.querySelector(".breno")
    let mensagemm = document.querySelector(".biden")

    let cargos = document.querySelector("#cargo").value
    let salarios = parseFloat (document.querySelector("#salario").value)
    let fsalario
    let dsalarios

    if(cargos == "gerente"){
        dsalarios = (salarios/100)*5
        fsalario = salarios  + dsalarios
        mensagem.innerHTML = fsalario
        mensagemm.innerHTML = salarios
    }
    else if (cargos == "supervisor"){
        dsalarios = (salarios/100)*8
        fsalario = salarios + dsalarios
        mensagem.innerHTML = fsalario
        mensagemm.innerHTML = salarios
    }
    else if (cargos == "operador"){
        dsalarios = (salarios/100)*9
        fsalario = salarios + dsalarios
        mensagem.innerHTML = fsalario
        mensagemm.innerHTML = salarios
    }
    else if(cargos == "colaborador"){
        dsalarios = (salarios/100)*10
        fsalario = salarios + dsalarios
        mensagem.innerHTML = fsalario
        mensagemm.innerHTML = salarios
    }
}
