using System;
using System.Net;
using System.Threading.Tasks;

namespace MachineLearningForKids
{
    internal class Program
    {
        private const string API_KEY = "CHANGE THIS TO YOUR PROJECT API KEY";

        private static async Task<int> Main(string[] args)
        {
            // CHANGE THIS to the text that you want your 
            // machine learning model to classify
            var testText = "triste";

            var demo = await MachineLearningText.ClassifyText(API_KEY, testText);

            //var label = demo["class_name"];
            //var confidence = demo["confidence"];

            // CHANGE THIS to do something different with the result
            //Console.WriteLine("result: '%s' with %d%% confidence" % (label, confidence))


            // -------------------------------------------------------
            // ADD TRAINING EXAMPLES TO YOUR MACHINE LEARNING PROJECT
            // -------------------------------------------------------

            // remove the comment on the next line to use this 

            // Training();

            // -------------------------------------------------------
            // TRAIN A NEW MACHINE LEARNING MODEL
            // -------------------------------------------------------



            // remove the comment on the next line to use this 

            // TrainModel();

            return 0;
        }

        private static void Training()
        {
            // CHANGE THIS to the text that you want to add 
            // to your project training data
            var training_text = "Training Example From Python";

            // CHANGE THIS to the training bucket to add the
            // training example to
            var trainingLabel = "Label";

            
            MachineLearningText.StoreText(API_KEY, training_text, trainingLabel);
        }

        private static void TrainModel()
        {
            // after collecting new training examples, you can use 
            // to train a new machine learning model 

            MachineLearningModel.TrainModel(API_KEY);
        }
    }
}
