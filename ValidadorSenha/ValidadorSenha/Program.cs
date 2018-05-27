using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValidadorSenha
{
    public class Program
    {
        static void Main(string[] args)
        {
            ValidadorSenha senha = new ValidadorSenha();

            string result = senha.criarSenha();
            Console.WriteLine(result);
            Console.ReadKey();

        }
    }
}
