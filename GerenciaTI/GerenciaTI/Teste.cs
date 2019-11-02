using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciaTI
{
    class Teste
    {
        public Teste() { }
        public string matricula { get; set; }
        public string senha { get; set; }

        public static string erro = "asasaas";

        public static bool isEqual(Teste userUm, Teste userDois)
        {
            if (userUm == null || userDois == null) { erro = "Usuário não existe";  return false; }
            if (userUm.matricula != userDois.matricula) { erro = "Usuário não existe"; return false; }
            else if (userUm.senha != userDois.senha) { erro = "Senha incorreta"; return false; }
            return true;
        }

    }
}
