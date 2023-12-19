document.getElementById("conversion-form").addEventListener("submit", function (event) {
    event.preventDefault();
    const fahreneit = parseFloat(document.getElementById("fahrenheit").value);

    fetch(`https://localhost:7128/Login/Temperatura?temp=${fahreneit}`)
    .then(response => response.json())
    .then(data => {
        document.getElementById("celsius-result").textContent = data;
    })
    .catch(error => {
        console.error('Error al llamar a la API de conversor de temperatura:', error);
    });
});