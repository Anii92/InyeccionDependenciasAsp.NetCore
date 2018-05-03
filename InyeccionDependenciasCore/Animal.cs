using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InyeccionDependenciasCore
{
    public class Animal: IAnimal
    {
        public string Especie { get; set; }
        public string Sexo { get; set; }

        public string Caminar()
        {
            return "Estoy caminando";
        }
    }
}
