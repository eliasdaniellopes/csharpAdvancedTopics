using System;
using ExerciseException.Entities;
using ExerciseException.Entities.Exceptions;
namespace ExerciseException
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                
                Console.WriteLine("Entre com as informações da conta");
                int number = int.Parse(Console.ReadLine());
                Console.WriteLine("Titular da conta: ");
                string holder = Console.ReadLine();
                Console.WriteLine("Saldo Inicial");
                double balance = double.Parse(Console.ReadLine());
                Console.WriteLine("Limite de saque");
                double withdrawLimit = double.Parse(Console.ReadLine());
                Console.WriteLine("Valor do saque");
                double withdraw = double.Parse(Console.ReadLine());
                Account ac = new Account(number, holder, balance, withdrawLimit);
                ac.Withdraw(withdraw);
                
            }catch(DomainException e)
            {
                Console.WriteLine("Erro " + e.Message);
            }
        }
    }
}
