using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace MachineLearningForKids
{
    public static class MachineLearningText
    {
        /// <summary>
        /// This function will pass your text to the machine learning model
        /// and return the top result with the highest confidence
        /// </summary>
        /// <param name="key">API key - the secret code for your ML project</param>
        /// <param name="text">The text that you want your ML model to classify</param>
        public static async Task<ClassifyResult[]> ClassifyText(string key, string text)
        {
            MachineLearningModel.CheckApiKey(key);

            HttpClient client = new HttpClient();

            string url = $"https://machinelearningforkids.co.uk/api/scratch/{key}/classify";

            var classify = new Classify()
            {
                Data = "text",
            };

            var response = await client.PostAsJsonAsync(url, classify);

            if (response.StatusCode == HttpStatusCode.OK)
            {
                var result = await response.Content.ReadFromJsonAsync<ClassifyResult[]>();

                return result;
            }
            else
            {
                var result = await response.Content.ReadFromJsonAsync<ErrorResult>();

                throw new Exception(result.Error);
            }
        }

        /// <summary>
        /// This function will store your text in one of the training
        /// buckets in your machine learning project
        /// </summary>
        /// <param name="key">API key - the secret code for your ML project</param>
        /// <param name="text">The text that you want your ML model to classify</param>
        /// <param name="label">the training bucket to put text into</param>
        public static void StoreText(string key, string text, string label)
        {
            MachineLearningModel.CheckApiKey(key);

            //  url = ("https://machinelearningforkids.co.uk/api/scratch/" +
            //         key +
            //         "/train")

            //  response = requests.post(url,
            //                           json ={ "data" : text, "label" : label })

            //  if response.ok == False:
            //    #if something went wrong, display the error
            //    print (response.json())

        }
    }
}
