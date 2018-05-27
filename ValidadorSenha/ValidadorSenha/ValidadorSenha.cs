using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace ValidadorSenha
{
    class ValidadorSenha
    {
        public bool ValidaSenha(string senha)
        {
            Regex reg = new Regex(@"^[A-Za-z]{5}[0-9]{1}$");
            bool valida = reg.IsMatch(senha);                  
            return valida;
        }
        public string criarSenha()
        {
            var caracteres = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";
            var VetorSenha = new char[5];
            var random = new Random();

            for (int i = 0; i < VetorSenha.Length; i++)
            {
                VetorSenha[i] = caracteres[random.Next(caracteres.Length)];
            }
            var senha = new String(VetorSenha);
            int num = random.Next(0, 9);
            senha += num;          
            return senha;
        }
    }
}
