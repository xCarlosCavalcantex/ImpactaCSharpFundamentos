using Microsoft.VisualStudio.TestTools.UnitTesting;
using Oficina.Repositorios.SqlServer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oficina.Repositorios.SqlServer.Tests
{
    [TestClass()]
    public class CorRepositorioTests
    {
        private CorRepositorio repositorio = new CorRepositorio();
        [TestMethod()]
        public void SelecionarTest()
        {
            Assert.IsTrue(repositorio.Selecionar().Count != 0);
        }

        [TestMethod()]
        public void SelecionarPorra()
        {
            Assert.IsTrue(repositorio.Selecionar(1).Nome == "Amarelo");
        }
    }
}