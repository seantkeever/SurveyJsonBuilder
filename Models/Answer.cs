using System;
using System.Collections.Generic;
using System.Text;

namespace SurveyJsonBuilder.Models
{
    public class Answer
    {
        public Answer( short QuestionID,bool YesNo, string Description)
        {
            this.QuestionID = QuestionID;
            this.YesNo = YesNo;
            this.Description = Description;
        }

        public short QuestionID { get; set; }
        public bool YesNo { get; set; }
        public string Description { get; set; }
    }
}
