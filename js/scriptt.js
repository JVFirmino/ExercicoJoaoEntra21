let array = []
let narray = []
let earray = []
let tarrey = []
function mostrar(){
    let nome = document.querySelector(".nome").value;
    let email = document.querySelector(".email").value;
    let telefone = document.querySelector(".telefone").value;
    let lista = document.querySelector(".lista")
    let texto = document.querySelector(".texto")
    let continuar = true
    
    if(nome == "" || email == "" || telefone == ""){
        texto.innerHTML = `<p>Preencha os campos</p>`
        continuar = false
    }

    for(let i = 0; i < narray.length+1; i++){
        if(narray[i] == nome && earray[i] == email && tarrey[i] == telefone ){
            texto.innerHTML = `<p>Já temos esse cadastro na nossa lista</p>`
            continuar = false
            break
        }
        else if(narray[i] != nome || earray[i] != email || tarrey[i] != telefone){
            narray[i] = nome
            earray[i] = email
            tarrey[i] = telefone
            break
        }
    }
    if(continuar == true){
        contatos = {
            nome: nome,
            email: email,
            telefone:telefone,
        }
        array.push(contatos)
        lista.innerHTML = ""
        for(let i = 0; i < array.length; i++){
            
            lista.innerHTML += `<li>${i} ${array[i].nome}   ${array[i].email}   ${array[i].telefone}</li>`
            
        } 
    }  
}
function editar(){
    
    let editarr = parseInt(document.querySelector(".editar").value) 
    let nomee = document.querySelector(".nomee").value
    let emaill = document.querySelector(".emaill").value
    let telefonee = document.querySelector(".telefonee").value;
    let lista = document.querySelector(".lista")
    let texto = document.querySelector(".texto")
    let continuar = true
    if(nomee == "" || emaill == "" || telefonee == "" ){
        continuar = false
    }
    if(continuar == true){
        for(let i = 0; i < array.length; i++){ 
            if( i == editarr ){ 
                array[i].nome = nomee
                array[i].email = emaill
                array[i].telefone = telefonee
                lista.innerHTML =""
                for(let i = 0; i < array.length; i++){
                    
                    lista.innerHTML += `<li>${i} ${array[i].nome}   ${array[i].email}  ${array[i].telefone}</li>`
                    
                }
                
            }
            else{
                texto.innerHTML = `<p>Não temos essa posiçao</p>`    
            }
        }
    }
    if(continuar == false){
        texto.innerHTML = `<p>Preencha os campos</p>`
    }
}

function excluir(){
    let posi = parseInt (document.querySelector(".posi").value)
    let lista = document.querySelector(".lista")
    let texto = document.querySelector(".texto")
    for(let i = 0; i < array.length; i++){
        if(i == posi){
            array.splice(posi, 1)
            lista.innerHTML = " "
            for(let i = 0; i < array.length; i++){
                lista.innerHTML += `<li>${i} ${array[i].nome}   ${array[i].email}  ${array[i].telefone}</li>`
            }
        }
        else{
            texto.innerHTML = `<p>Não temos essa posiçao</p>`
        }
    }
}