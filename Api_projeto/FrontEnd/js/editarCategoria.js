document.addEventListener("DOMContentLoaded", function(){
    document.getElementById("id").value = localStorage.getItem("idEditar")
})

async function editarCategoria(){
    var idValue = document.getElementById("id").value
    var nome = document.getElementById("nome").value

    let obj = {
        id : idValue,
        nome : nome,
    }

    var token = localStorage.getItem("token")
    
    await fetch(`https://localhost:7193/api/Categorias1/editar/${idValue}`,{
        method: "PUT",
        headers :{
            "Authorization" : "Bearer " + token,
            "Content-Type" : "application/json"
        },
        body: JSON.stringify(obj)
      }
    ).then(window.open("listarCategoria.html"))
}