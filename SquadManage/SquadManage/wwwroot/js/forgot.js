

$('form').on('submit', function (event) {
    event.preventDefault();
    var x = {
        email: $("#email").val(),

    }
    $.ajax({
        type: "POST",
        dataType: "json",
        contentType: "application/json; charset=UTF-8",
        data: JSON.stringify($("#email").val()),
        url: "https://localhost:7028/api/user/forgot",
        success: function (result) {
            if (result.response === 'OK')
                alert("Email foi enviado para recuperar a senha!")
            else
                alert("Credenciais invalidas!")
        },
        error: function (error) {
            console.log(error)
        }


    })

});