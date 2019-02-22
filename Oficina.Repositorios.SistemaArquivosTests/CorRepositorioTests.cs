using Microsoft.VisualStudio.TestTools.UnitTesting;
using Oficina.Repositorios.SistemaArquivos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oficina.Dominio;


namespace Oficina.Repositorios.SistemaArquivos.Tests
{
    [TestClass()]
    public class CorRepositorioTests
    {
        private CorRepositorio corTest = new CorRepositorio();


        [TestMethod()]
        public void SelecionarTest()
        {
            var cores = corTest.Selecionar();

            foreach (var cor in cores)
            {
                Console.WriteLine($"{cor} - {cor.Nome}");
            }
        }

        [TestMethod()]
        public void SelecionarPorIdTest()
        {
            var cores = corTest.Selecionar(1);
            Console.WriteLine($"{cores.Id} ; {cores.Nome}");

            Assert.AreEqual(cores.Id, 1);
            Assert.IsTrue(cores.Nome == "Preto");

           // Assert.IsNull(cores);
        }
    }
}