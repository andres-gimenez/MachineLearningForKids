using System;
using System.Threading.Tasks;

namespace MachineLearningForKids
{
    internal class Program
    {
        private const string API_KEY = "CHANGE THIS TO YOUR PROJECT API KEY";

        private static async Task<int> Main(string[] args)
        {
            // -------------------------------------------------------
            // ADD TRAINING EXAMPLES TO YOUR MACHINE LEARNING PROJECT
            // -------------------------------------------------------
            // remove the comment on the next line to use this 

            //await Training();

            // -------------------------------------------------------
            // TRAIN A NEW MACHINE LEARNING MODEL
            // -------------------------------------------------------
            // remove the comment on the next line to use this 

            //await TrainModel();

            // -------------------------------------------------------
            // VIEW STATUS OF MACHINE LEARNING
            // -------------------------------------------------------
            // remove the comment on the next lines to use this 

            //await CheckModel();

            // CHANGE THIS to the text that you want your 
            // machine learning model to classify
            var testText = "hace un dia soleado";

            var results = await MachineLearningText.ClassifyText(API_KEY, testText);

            foreach(var result in results)
            {
                Console.WriteLine($"result: {result.ClassName} with {result.ConfidencePercent:p} confidence.");
            }

            return 0;
        }

        private static async Task Training()
        {
            // CHANGE THIS to the text that you want to add 
            // to your project training data
            var trainingText = "Training Example From C#";

            // CHANGE THIS to the training bucket to add the
            // training example to
            var trainingLabel = "Triste";

            await MachineLearningText.StoreText(API_KEY, trainingText, trainingLabel);
        }

        private static async Task TrainModel()
        {
            // after collecting new training examples, you can use 
            // to train a new machine learning model 

            await MachineLearningModel.TrainModel(API_KEY);
        }

        private static async Task CheckModel()
        {
            var status = await MachineLearningModel.CheckModel(API_KEY);
            Console.WriteLine($"Message: {status.Message}");
            Console.WriteLine($"Status: {status.StatusDescription}");
            Console.WriteLine($"Type: {status.Type}");
        }
    }
}
