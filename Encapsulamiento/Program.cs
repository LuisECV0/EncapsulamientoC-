using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploEncapsulamiento
{
    public class CuentaBancaria
    {
        // Campo privado para almacenar el saldo
        private decimal saldo;

        // Constructor para inicializar el saldo
        public CuentaBancaria(decimal saldoInicial)
        {
            saldo = saldoInicial;
        }

        // Método público para depositar dinero
        public void Depositar(decimal cantidad)
        {
            if (cantidad > 0)
            {
                saldo += cantidad;
                Console.WriteLine($"Depósito exitoso. Saldo actual: {saldo:C}");
            }
            else
            {
                Console.WriteLine("La cantidad a depositar debe ser positiva.");
            }
        }

        // Método público para retirar dinero
        public void Retirar(decimal cantidad)
        {
            if (cantidad > 0 && cantidad <= saldo)
            {
                saldo -= cantidad;
                Console.WriteLine($"Retiro exitoso. Saldo actual: {saldo:C}");
            }
            else
            {
                Console.WriteLine("La cantidad a retirar no es válida.");
            }
        }

        // Método público para obtener el saldo actual
        public decimal ObtenerSaldo()
        {
            return saldo;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Crear una nueva cuenta bancaria con un saldo inicial
            CuentaBancaria cuenta = new CuentaBancaria(1000m);

            // Realizar operaciones en la cuenta
            cuenta.Depositar(200m);
            cuenta.Retirar(150m);

            // Obtener el saldo actual
            decimal saldoActual = cuenta.ObtenerSaldo();
            Console.WriteLine($"Saldo final: {saldoActual:C}");
        }
    }
}

