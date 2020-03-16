var index = {

    btnCadastrar: function () {

        var nomeUsuario = document.getElementById("usuario").value;
        var senha = document.querySelector("#senha").value;
        var senhaConf = document.querySelector("#senhaConf").value;

        if (nomeUsuario.trim() == "") {

            document.getElementById("divMsg").innerHTML =
                "Informe o nome.";
        }
        else if (senha.trim() == "" || senhaConf.trim() == "") {

            document.getElementById("divMsg").innerHTML =
                "As senhas não informadas.";
        }
        else if (senha != senhaConf) {

            document.getElementById("divMsg").innerHTML =
                "As senhas não conferem.";
        }
        else {

                var dados = {
                    nomeUsuario,
                    senha,
                    senhaConf
                }

                var config = {
                    method: "POST",
                    headers: {
                        "Content-Type": "application/json; charset=utf-8"
                    },
                    credentials: 'include', //inclui cookies
                    body: JSON.stringify(dados)  //serializa
                };

                fetch("CadastrarUsuario/Criar", config)
                    .then(function (dadosJson) {
                        var obj = dadosJson.json(); //deserializando
                        return obj;
                    })
                    .then(function (dadosObj) {

                        window.location.href = "Default";

                    })
                    .catch(function () {

                        document.getElementById("divMsg").innerHTML = "deu erro";
                    })

             }

    }

}