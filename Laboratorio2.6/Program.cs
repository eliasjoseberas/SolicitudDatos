using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio2_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string Nomcliente;
            string numCuenta;
            string tipoCuenta;
            decimal saldo;

            Console.WriteLine("Ingrese su nombre");
            Nomcliente = Console.ReadLine();
            
            Console.WriteLine("Ingrese su numero de cuenta");
            numCuenta = Console.ReadLine();

            Console.WriteLine("Ingrese el tipo de su cuenta");
            tipoCuenta = Console.ReadLine();

            Console.WriteLine("Ingrese su saldo actual");
            saldo = decimal.Parse(Console.ReadLine());

            Console.WriteLine("==========================");
            Console.WriteLine("    INFORMACIÓN CUENTA    ");
            Console.WriteLine("==========================");
            Console.WriteLine("");
            Console.WriteLine($"Cliente: {Nomcliente}");
            Console.WriteLine($"Cuenta: {numCuenta}");
            Console.WriteLine($"Tipo: {tipoCuenta}");
            Console.WriteLine($"Saldo: {saldo}");
        }
    }
}
