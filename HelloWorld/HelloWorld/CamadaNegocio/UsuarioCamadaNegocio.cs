using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HelloWorld.CamadaNegocio
{
    public class UsuarioCamadaNegocio
    {

        public (bool, string) Criar(Models.Usuario usuario)
        {
            string msg = "";
            bool operacao = false;
            //obrigatório nome de usuário único
            //senha com min 6 caracteres
            if (usuario.Senha.ToString().Length < 6)
            {
                msg = "Senha muito pequena.";
            }
            else
            {
                operacao = true;
                //gravar....
            }
            return (operacao, msg);
        }

        public bool Validar(string usuarioNome, string senha)
        {
            if (usuarioNome == "adm" && senha == "132")
            {
                return true;
            }
            else return false;

        }
    }
}
