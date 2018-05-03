using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InyeccionDependenciasCore
{
    public interface IAnimal
    {
        string Especie { get; set; }
        string Sexo { get; set; }

        string Caminar();
    }
}
