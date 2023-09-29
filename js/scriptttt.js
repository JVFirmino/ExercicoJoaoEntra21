function conferir(){
    let p = document.querySelector(".p")
    let cep  = document.querySelector(".cep").value
    fetch(`https://viacep.com.br/ws/${cep}/json/`)
    .then((dados) => dados.json())
    .then((response) => p.innerHTML = `<sapn>${(response.localidade)}</span>`)
    .catch((error) => console.log(error))
    
}


function gatos(){
    let pp = document.querySelector(".pp")
    fetch(`https://api.thecatapi.com/v1/images/search`)
    .then((dados) => dados.json())
    .then((response) => pp.innerHTML =`<img src = "${response[0].url}"></img>`)
    .catch((error)=> console.log(error))
}

setInterval(gatos, 3000)

function gatitos(){

    let ppp = document.querySelector(".ppp")
    fetch(`https://api.thecatapi.com/v1/images/search?limit=10`)
    .then((dados) => dados.json())
    .then((response) => {
        for(let i = 0; i < response.length; i++)
        ppp.innerHTML += `<img class="teste"src = "${response[i].url}">`
    })
    .catch((error) => console.log(error))
    
}