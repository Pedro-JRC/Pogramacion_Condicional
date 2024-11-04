namespace CalificacionesApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // VARIABLES
            int nota1;
            int nota2;
            int nota3;
            double promedio;
            string estatus;
            

            // SOLICITA LA "NOTA1"
            Console.WriteLine("Favor digite la primera nota");
            nota1 = Convert.ToInt32(Console.ReadLine());

            // SOLICITA LA "NOTA2"
            Console.WriteLine("Favor digite la segunda nota");
            nota2 = Convert.ToInt32(Console.ReadLine());

            // SOLICITA LA "NOTA3"
            Console.WriteLine("Favor digite la tercera nota");
            nota3 = Convert.ToInt32(Console.ReadLine());

            // CALCULA EL PROMEDIO
            promedio = (nota1 + nota2 + nota3) / 3;
                    
            // CONDICIONES PARA INDICAR EL ESTATUS
            if (promedio >= 7)
            {
                estatus = ("Promovido");
            }
            else if (promedio >= 4)
            {
                estatus = ("Regular");
            }
            else 
            {
                estatus = ("Reprobado");
            }

            // INDICA EL PROMEDIO Y EL ESTATUS
            Console.WriteLine($"Su promedio es igual a: { promedio }, por lo tanto usted está: { estatus }");
        }
    }
}
