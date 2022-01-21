

$('form').on('submit', function (event) {
    event.preventDefault();
    if ($("#password").val() != $("#confirmPassword").val()) {
        alert("senhas diferentes")
        return;
    }
    const urlParam = new URLSearchParams(window.location.search);
    const id = urlParam.get('id');

    var x = {
        email: "",
        username:"",
        password: $("#password").val(),
        confirmPassword: $("#confirmPassword").val()
        id: id

    }

    $.ajax({
        type: "POST",
        dataType: "json",
        contentType: "application/json; charset=UTF-8",
        data: JSON.stringify(x),
        url: "https://localhost:7028/api/user/reset",
        success: function (result) {
            if (result.response === 'OK')
                alert("Senha resetada")
            else
                alert("Credenciais invalidas!")
        },
        error: function (error) {
            console.log(error)
        }


    })

});