using Microsoft.VisualStudio.TestTools.UnitTesting;
using Oficina.Dominio;
using Oficina.Repositorios.SqlServer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oficina.Repositorios.SqlServer.Tests
{
    [TestClass()]
    public class VeiculoRepositorioTests
    {
        [TestMethod()]
        public void InserirTest()
        {
            var veiculo = new VeiculoPasseio();

            veiculo.Placa = "XXT6904";
            veiculo.Ano = 2015;
            veiculo.Cor = new Cor { Nome = "Azul" };
            veiculo.Modelo = new Modelo { Nome = "Monster" };

            new VeiculoRepositorio().Inserir(veiculo);
        }
    }
}