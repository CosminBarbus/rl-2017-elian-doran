using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Speech.Synthesis;

namespace ElianDoran.iQuest.Homework01
{
    class Program
    {
        static void Pause()
        {
            Console.Write("\nPress any key to continue...");
            Console.ReadKey();
        }

        static void Main(string[] args)
        {
            Console.Title = "iQuest Homework 01";

            using (var synthesizer = new SpeechSynthesizer())
            {
                synthesizer.Volume = 100;
                synthesizer.SpeakProgress += Synthesizer_SpeakProgress;

                List<Animal> animals = Animal.GetAllAnimals();

                foreach (var animal in animals)
                {
                    var phrase = String.Format("The {0} makes {1}.", animal.Name, animal.Sound);

                    synthesizer.Speak(phrase);
                    Console.WriteLine("\b.");
                }
            }

            Pause();
        }

        private static void Synthesizer_SpeakProgress(object sender, SpeakProgressEventArgs e)
        {
            Console.Write("{0} ", e.Text);
        }
    }
}
