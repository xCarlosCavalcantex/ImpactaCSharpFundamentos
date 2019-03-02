using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oficina.Dominio
{
   public interface ICorRepositorio
    {
        void Inserir (Cor cor);

        List<Cor> Selecionar();

        Cor Selecionar(int id);

        void Atualizar (Cor cor);

        void Excluir(int id);
    }
}
