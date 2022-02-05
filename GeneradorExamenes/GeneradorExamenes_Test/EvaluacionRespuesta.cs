using System.Text;

namespace GeneradorExamenes_Test
{
    public class EvaluacionRespuesta
    {
        public static string Evaluar(bool SeleccionUsuario, bool OpcionCorrecta)
        {
            if (SeleccionUsuario==true && OpcionCorrecta==true)
            {
                return "Correcto";
            }
            else if (SeleccionUsuario==false && OpcionCorrecta==false)
            {
                return "Correcto";
            }
            return "Incorrecto";
        }
    }
}