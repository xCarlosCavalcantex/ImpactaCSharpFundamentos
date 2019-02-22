using Microsoft.VisualStudio.TestTools.UnitTesting;
using Oficina.Repositorios.SistemaArquivos;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace Oficina.Repositorios.SistemaArquivos.Tests
{
    [TestClass()]
    public class MarcaRepositorioTests
    {
        private MarcaRepositorio marcaTest = new MarcaRepositorio();

        [TestMethod()]
        public void SelecionarTest()
        {
            var marcas = marcaTest.Selecionar();

            foreach (var marca in marcas)
            {
                Console.WriteLine($"{marca.Id} - {marca.Nome}");
            }
        }

        [TestMethod()]
        public void SelecionarPorIdTest()
        {
            var marcas = marcaTest.Selecionar(1);
            Console.WriteLine($"{marcas.Id} ; {marcas.Nome}");

            Assert.AreEqual(marcas.Id, 1);
            Assert.IsTrue(marcas.Nome == "VW");

           // Assert.IsNull(marcas);
        }
    }
}