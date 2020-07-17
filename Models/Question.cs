using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SurveyJsonBuilder.Models
{
    public class Question
    {
        public Question(string Description, bool AllowYesNo, bool AllowShortAnswer)
        {
            this.Description = Description;
            this.AllowYesNo = AllowYesNo;
            this.AllowShortAnswer = AllowShortAnswer;
        }

        public string Description { get; set; }
        public bool AllowYesNo { get; set; }
        public bool AllowShortAnswer { get; set; }
    }
}
