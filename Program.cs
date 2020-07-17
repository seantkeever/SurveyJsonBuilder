using Newtonsoft.Json;
using SurveyJsonBuilder.Models;
using System;

namespace SurveyJsonBuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            Question inputData = new Question("Test Description", true, true);
            Console.WriteLine(JsonConvert.SerializeObject(inputData));

            Console.WriteLine(inputData);
        }
    }
}
