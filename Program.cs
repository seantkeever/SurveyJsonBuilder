using Newtonsoft.Json;
using SurveyJsonBuilder.Models;
using System;

namespace SurveyJsonBuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            //Question inputData = new Question("Total SSL Certificate(s)?", true, true);
            //Console.WriteLine(JsonConvert.SerializeObject(inputData));
            //Console.WriteLine(inputData);


            Answer inputData = new Answer(1, true, null);
            Console.WriteLine(JsonConvert.SerializeObject(inputData));
            Console.WriteLine(inputData);
        }
    }
}
