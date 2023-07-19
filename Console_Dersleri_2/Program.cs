using Console_Dersleri_2.DAL;
using Console_Dersleri_2.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Dersleri_2
{
    class Program
    {
        
        static void Main(string[] args)
        {
            //Person
            //Job
            //Data Access Layer --> Dal --> SQL Connection
            //Context --> Veri tabanı bağlantı adresi ve veri tabanı bağlantı yapılandırması

            //Code First
            Context c = new Context();
            var values = c.Customers.ToList();

            void Listele()
            {
                foreach (var item in values)
                {
                    Console.WriteLine(item.CustomerName);
                }
            }

            //Customer customer = new Customer();
            //customer.CustomerName = "Eylül Yücedağ";
            //customer.CustomerCity = "Lviv";
            //c.Customers.Add(customer);
            //c.SaveChanges();
            //Listele();

            //var values2 = c.Customers.Where(x => x.CustomerID == 4).FirstOrDefault();
            //c.Customers.Remove(values2);
            //c.SaveChanges();
            //Console.WriteLine("Silme işlemi Yapıldı");

            //var values3 = c.Customers.Where(x => x.CustomerID == 3).FirstOrDefault();
            //values3.CustomerName = "Ahmet Karalı";
            //values3.CustomerCity = "Trabzon";
            //c.SaveChanges();
            //Console.Write("Güncelleme yapıldı");






            Console.ReadLine();
        }
    }
}
