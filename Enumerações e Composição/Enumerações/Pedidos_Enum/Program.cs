using Pedidos_Enum.Entities;
using Pedidos_Enum.Entities.Enums;
using System;


namespace Pedidos_Enum
{
    class Program
    {
        static void Main(string[] args)
        {
            Order order = new Order
            {
                ID = 1800,
                Moment = DateTime.Now,
                Status = OrderStatus.PedingPayment

            };
            Console.WriteLine(order);

            string txt = OrderStatus.PedingPayment.ToString();
            Console.WriteLine(txt);

            OrderStatus os = Enum.Parse<OrderStatus>("Delivered"); // TEXTO ENTRE ASPAS IGUAL AO DO ENUM
            Console.WriteLine(os);
        }
        
    }
}
/* ENUM VOCÊ DEFINE OS VALORES POSSIVEIS QUE O ATRIBUTO PODE POSSUIR E ELE PODENDO POSSUI APENAS UM VALOR.
 * EX: 
 * CLASSE CONTA POSSUI O ATRIBUTO VENCIMENTO , VENCIMENTO ASSUME VALORES DE DOMINGO À SÁBADO. O ATRIBUTO VENCIMENTO É UM VALOR UNICO
 * QUE PODE ASSUMIR SOMENTE UM DESSES VALORES (2°,3°,4° ETC) 
*/