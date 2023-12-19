document.getElementById("conversion-form").addEventListener("submit", function (event) {
    event.preventDefault();
    const dolar = parseFloat(document.getElementById("dollars").value);

    fetch(`https://localhost:7128/Login/Divisa?dolar=${dolar}`)
    .then(response => response.json())
    .then(data => {
        document.getElementById("pesos-result").textContent = data;
    })
    .catch(error => {
        console.error('Error al llamar a la API de conversor de divisas:', error);
    });
});