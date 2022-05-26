using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jsonInventory
{
    internal class jsonInventoryMain
    {
        

        public void convert(string jFilePath)
        {
            FactoryModel model = new FactoryModel();
            List<InventoryModel> Rice;
            List<InventoryModel> Wheat;
            List<InventoryModel> Pulses;

            using (StreamReader file = new StreamReader(jFilePath)) 
            {
                var json = file.ReadToEnd();
                FactoryModel item = JsonConvert.DeserializeObject<FactoryModel>(json);
                Rice = item.Rice;
                Wheat = item.Wheat;
                Pulses = item.Pulses;
                Console.WriteLine("Which Item you want check:\n1.Rice\n2.Wheat\n3.Pulses");
                int choice = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Item\tPrice\tweight");
                switch (choice)
                {
                    case 1:
                        foreach (var contact in Rice)
                        Console.WriteLine(contact.name +" -> "+ contact.price +"  -> "+ contact.weight);
                        break;
                    case 2:
                        foreach (var contact in Rice)
                            Console.WriteLine(contact.name + "  -> " + contact.price + "  ->  " + contact.weight);
                        break;
                    case 3:
                        foreach (var contact in Rice)
                            Console.WriteLine(contact.name + "  -> " + contact.price + "  ->  " + contact.weight);
                        break;
                    default:
                        Console.WriteLine("Invalid option.");
                        break;
                }
                
                
            }
        }
    }
}
