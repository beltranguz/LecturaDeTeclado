
namespace LecturaDeTeclado.Class
{
    public class calcular
    { 
        public void LecturaDeTeclado()

        {
            int num1 = 0;   
            int num2 = 0;
            decimal suma = 0;
            decimal diferencia = 0;
            decimal producto = 0;
            decimal division = 0;

            try
            {
                Console.WriteLine("Digite el num1");
                num1 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Digite el num2");
                num2 = Convert.ToInt32(Console.ReadLine());

                suma = num1 + num2;
                diferencia = num1 - num2;
                producto = num1 * num2;
                division = num1 / num2;

                if (num1 > num2)
                {
                    Console.WriteLine($"La suma es: {suma}");
                    Console.WriteLine($"La diferencia es: {diferencia}");
                }

                else
                {
                    Console.WriteLine($"El producto es: {producto}");
                    Console.WriteLine($"La division es: {division}");
                }
            }
            catch ( Exception ex )
            {
                Console.WriteLine($"Error en los datos suministrados {ex.Message}");
            }

        }


    }
}
