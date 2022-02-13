using System;
using System.Net;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace MachineLearningForKids
{
    public static class MachineLearningModel
    {

        /// <summary>
        /// Checks that a custom API key has been provided
        /// </summary>
        /// <param name="key">API key - the secret code for your ML project</param>
        public static void CheckApiKey(string key)
        {
            if(key == "CHANGE THIS TO YOUR PROJECT API KEY")
            {
                Console.WriteLine("You need to enter your secret project API key into this sample.");
                Console.WriteLine("Replace the string on line 6 with your key.");

                Environment.Exit(1);
            }
        }

        /// <summary>
        /// This function will train a new ML model using the current 
        /// training examples in your project
        /// </summary>
        /// <param name="key">API key - the secret code for your ML project</param>
        public static async Task TrainModel(string key)
        {
            CheckApiKey(key);

            HttpClient client = new HttpClient();

            string url = $"https://machinelearningforkids.co.uk/api/scratch/{key}/models";

            var response = await client.PostAsJsonAsync(url, new object());

            if (response.StatusCode != HttpStatusCode.OK)
            {
                var result = await response.Content.ReadFromJsonAsync<ErrorResult>();

                throw new Exception(result.Error);
            }
        }

        /// <summary>
        /// This function will check the training status of the 
        /// machine learning model for your project
        /// </summary>
        /// <param name="key">API key - the secret code for your ML project.</param>
        public static async Task<StatusResult> CheckModel(string key)
        {
            CheckApiKey(key);

            HttpClient client = new HttpClient();

            string url = $"https://machinelearningforkids.co.uk/api/scratch/{key}/status";

            var response = await client.GetAsync(url);

            if (response.StatusCode == HttpStatusCode.OK)
            {
                var status = await response.Content.ReadFromJsonAsync<StatusResult>();

                return status;
            }
            else
            {
                var result = await response.Content.ReadFromJsonAsync<ErrorResult>();

                throw new Exception(result.Error);
            }
        }
    }
}
