

$('form').on('submit', function (event) {
    event.preventDefault();
    var x = {
        username: $("#username").val(),

        email: $("#email").val(),
        password: $("#password").val(),
        confirmPassword: $("#confirmPassword").val()


    }
    $.ajax({
        type: "POST",
        dataType: "json",
        contentType: "application/json; charset=UTF-8",
        data: JSON.stringify(x),
        url: "https://localhost:7028/api/user/register",
        success: function (result) {
            if (result.response == 'OK')
                alert("Sua conta foi criada com sucesso!")
            else
                alert("Erro ao criar sua conta!")
        },
        error: function (error) {
            console.log(error)
        }


    })

});