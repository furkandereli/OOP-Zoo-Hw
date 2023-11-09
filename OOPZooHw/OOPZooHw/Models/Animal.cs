using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPZooHw.Models
{
    public class Animal
    {
        public string Name { get; set; }
        public string Species { get; set; }

        public static void Add(Animal animal)
        {
            if(string.IsNullOrEmpty(animal.Name) || string.IsNullOrEmpty(animal.Species))
                Console.WriteLine("Hayvan adı ve türü olmadan ekleme yapılamaz.");
            else
                Console.WriteLine($"Hayvan ekleme başarılı.\nHayvan adı : {animal.Name} | Türü : {animal.Species}");
            
        }

        public void Hungry()
        {
            Console.WriteLine($"{Species} {Name} acıkmış");
        }

        public void Bored()
        {
            Console.WriteLine($"{Species} {Name} sıkılmış");
        }

        public void PlayAndHappy()
        {
            Console.WriteLine($"{Species} {Name} oyun oynuyor ve mutlu");
        }

        public void Happy()
        {
            Console.WriteLine($"{Species} {Name} mutlu");
        }
    }
}
