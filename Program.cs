using System;
using System.Security.Cryptography.X509Certificates;
using MLConsoleApp1ML.Model;


namespace MLConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            static void prediction(string inputString)
            {
                // Add input data
                var input = new ModelInput();
                input.SentimentText = inputString;

                // Load model and predict output of sample data
                ModelOutput result = ConsumeModel.Predict(input);

                // Here's the prediction
                Console.WriteLine(input.SentimentText + "is considered");
                Console.WriteLine(result.Prediction);

                double predictionValue = Int16.Parse(result.Prediction);
                if (predictionValue == 1)
                {
                    Console.WriteLine("Toxic statement!\n");
                } 
                else
                {
                    Console.WriteLine("It's OK to say that\n");
                }

            }

            prediction("You're not so smart. I hate your guts.");
            prediction("I have a good point.");

        }
    }
}
