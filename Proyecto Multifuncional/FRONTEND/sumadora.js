document.getElementById("sum-form").addEventListener("submit", function (event) {
    event.preventDefault();
    const num1 = parseFloat(document.getElementById("num1").value);
    const num2 = parseFloat(document.getElementById("num2").value);

    fetch(`https://localhost:7128/Login/Suma?val1=${num1}&val2=${num2}`)
    .then(response => response.json())
    .then(data => {
        document.getElementById("sum-result").textContent = data;
    })
    .catch(error => {
        console.error('Error al llamar a la API de suma:', error);
    });
});


