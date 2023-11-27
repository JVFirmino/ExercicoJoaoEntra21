using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrudComBanco.Interface
{
    internal interface Icrud <T>
    {
        public void Adicionando();

        public void CriandoLista(List<T>t);

        public void Removendo();

        public void Alterando();

    }
}
