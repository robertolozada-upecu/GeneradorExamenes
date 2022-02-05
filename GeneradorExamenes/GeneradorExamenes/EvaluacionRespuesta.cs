using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneradorExamenes
{
    public class EvaluacionRespuesta
    {
        public static string Evaluar(bool SeleccionUsuario, bool OpcionCorrecta)
        {
            if (SeleccionUsuario==OpcionCorrecta)
            {
                return "Correcto";
            }
            return "Incorrecto";
        }
    }
}
