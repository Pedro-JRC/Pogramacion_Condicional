namespace TestAPP
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            // VARIABLES:
            int preguntas;
            string pregunta_valida;
            int respuestas_correctas;
            string respuestas_valida;
            double porcentaje;
            string nivel;

            while (true)
            {
                // SOLICITA LA CANTIDAD TOTAL DE PREGUNTAS
                Console.WriteLine("Favor introduzca la cantidad total de preguntas:");
                pregunta_valida = Console.ReadLine();

                // VALIDACIONES
                if (int.TryParse(pregunta_valida, out preguntas) && preguntas > 0)
                {
                    break;                 
                }
                else
                {
                    Console.WriteLine("Error: Favor verifique que esté introduciendo un numero entero mayor a 0.");
                }
            }


            while (true)
            {
                // SOLICITA LA CANTIDAD TOTAL DE RESPUESTAS CORRECTAS
                Console.WriteLine("Favor introduzca la cantidad total de respuestas correctas");
                respuestas_valida = Console.ReadLine();

                // VALIDACIONES
                if (int.TryParse(respuestas_valida, out respuestas_correctas) && respuestas_correctas >= 0 && respuestas_correctas <= preguntas)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Error: Favor verifique que esté introduciendo un numero entero menor o igual al numero de preguntas.");
                }
            }


            // CALCULA EL PORCENTAJE DE RESPUESTAS CORRECTAS
            porcentaje = ((double)respuestas_correctas / preguntas) * 100;

            // CONDICIONES PARA MOSTRAR EL NIVEL
            if (porcentaje >= 90)
            {
                nivel = "Nivel máximo";
            }
            else if (porcentaje >= 75)
            {
                nivel = "Nivel medio";
            }
            else if (porcentaje >= 50)
            {
                nivel = "nivel regular";
            }
            else 
            {
                nivel = "Fuera de nivel";
            }

            // MUESTRA EL NIVEL OBTENIDO
            Console.WriteLine($"El porcentaje de respuestas correctas fue del { porcentaje }% y su nivel obtenido es: { nivel }.");
        }
    }
}
