using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace OOPZooHw.Models
{

    public class AnimalSitter
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public static void Add(AnimalSitter animalSitter)
        {
            if (string.IsNullOrEmpty(animalSitter.Name))
                Console.WriteLine("Bakıcı adı olmak zorundadır.");
            else
                Console.WriteLine($"Bakıcı oluşturuldu. Id : {animalSitter.Id} | Name : {animalSitter.Name}");
        }

        public void PlayWithAnimal(Animal animal)
        {
            animal.Bored();
            Console.WriteLine($"{Name} bakıcısı {animal.Species} {animal.Name} ile oynuyor ve sıkılganlığını alıyor.");
            animal.PlayAndHappy();
        }

        public void Feed(Animal animal)
        {
            animal.Hungry();
            Console.WriteLine($"{Name} bakıcısı {animal.Species} {animal.Name}'i besliyor.");
            animal.Happy();
        }

        public void AttentionToAnimal(Animal animal)
        {
            animal.Bored();
            Console.WriteLine($"{Name} bakıcısı {animal.Species} {animal.Name} ile ilgilenip onu seviyor.");
            animal.Happy();
        }
    }
}
