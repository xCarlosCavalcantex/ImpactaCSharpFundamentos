using Oficina.Dominio;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Oficina.Repositorios.SistemaArquivos
{
    public class ModeloRepositorio
    {
        private XDocument arquivoXml = XDocument.Load(ConfigurationManager.AppSettings["caminhoArquivoModelo"]);

        public List<Modelo> Selecionar(int marcaId)
        {
            var modelos = new List<Modelo>();

            foreach (var elemento in arquivoXml.Descendants("modelo"))
            {

            }

            return modelos;
        } 
    }
}
