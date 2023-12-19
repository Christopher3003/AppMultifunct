document.getElementById("registro-form").addEventListener("submit", function(event) {
    event.preventDefault();

    const username = document.getElementById("username").value;
    const password = document.getElementById("password").value;
    console.log(username);
    console.log(password);
    const url = 'https://localhost:7128/Login/Registrarse';


    fetch(url, {
        method: "POST",
        headers: {
            "Content-Type": "application/json"
        },
        body: JSON.stringify({
            nombreUsuario: username,
            password: password
        })
    })    
    .then(response => response.json())
    .then(data => {
        console.log(data);
        window.location.href = "menu.html"
    })
    .catch(error => {
        console.error("Error al registrar al usuario:", error);
    });
});
