

$('form').on('submit', function (event) {
    event.preventDefault();
    var x = {
        email: $("#email").val(),
        password: $("#password").val()

    }
    $.ajax({
        type: "POST",
        dataType: "json",
        contentType: "application/json; charset=UTF-8",
        data: JSON.stringify(x),
        url: "https://localhost:7028/api/user",
        success: function (result) {
            if (result.response === 'OK')
                alert("Logado")
            else
                alert("Credenciais invalidas!")
        },
        error: function (error) {
            console.log(error)
        }


    })

});