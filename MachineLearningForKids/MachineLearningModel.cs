using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
        public static void TrainModel(string key)
        {
            CheckApiKey(key);
        

  //url = ("https://machinelearningforkids.co.uk/api/scratch/" + 
  //       key + 
  //       "/models")

  //response = requests.post(url)

  //if response.ok == False:
  //  #if something went wrong, display the error
  //  print (response.json())
    }

        /// <summary>
        /// This function will check the training status of the 
        /// machine learning model for your project
        /// </summary>
        /// <param name="key">API key - the secret code for your ML project.</param>
        public static void CheckModel(string key)
        {
            CheckApiKey(key);

            //  url = ("https://machinelearningforkids.co.uk/api/scratch/" + 
            //         key + 
            //         "/status")

            //  response = requests.get(url)

            //  if response.ok:
            //    responseData = response.json()

            //    status = {
            //      2 : "ready to use",
            //      1 : "training is in progress",
            //      0 : "problem"
            //    }

            //    return { 
            //      "status" : status[responseData["status"]], 
            //      "msg" : responseData["msg"] 
            //    }
            //  else:
            //#if something went wrong, display the error
            //    print (response.json())
            //    }
        }
    }
}
