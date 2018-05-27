using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace ValidadorSenha
{
    [TestFixture]
    class ValidadorSenhaTest
    {
        [Test]
        public void ValidaSenhaCorretaTeste()
        {
            ValidadorSenha valSen = new ValidadorSenha();
            string senha = "AbCdE1";
            bool result = valSen.ValidaSenha(senha);
            Assert.True(result);
        }
        [Test]
        public void CriarSenhaTeste()
        {
            ValidadorSenha senha = new ValidadorSenha();
            
            string result = senha.criarSenha();
            Assert.True(senha.ValidaSenha(result));
        }
        


        
    }
}
