using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciaTI
{
    class Usuario
    {
        public string matricula { get; set; }
        public string nome { get; set; }
        public string dataNascimento { get; set; }
        public string endereco { get; set; }
        public string bairro { get; set; }
        public string cidade { get; set; }
        public string estado { get; set; }
        public string departamento { get; set; }
        public string funcao { get; set; }
        public string email { get; set; }
        public string dataAdmissao { get; set; }
        public string usuario { get; set; }
        public string senha { get; set; }
        public string perfil { get; set; }
        public static string erro;

        public static bool isEqual(Usuario userUm, Usuario userDois)
        {
            if(userUm == null || userDois == null) { return false; }
            if(userUm.matricula != userDois.matricula) { erro = "Usuário não existe"; return false; }
            else if(userUm.senha != userDois.senha) { erro = "Senha incorreta"; return false; }
            return true;
        }
    }
}
