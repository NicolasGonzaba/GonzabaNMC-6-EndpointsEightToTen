using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GonzabaNMC_6_EndpointsEightToTen.Services
{
    public class Magic8BallService
    {
    public string Fortune(string Question)
    {
        if (Question[Question.Length - 1] != '?')
        {
            return "Please end your question with a '?'";
        }
        Random rng=new Random();
        int Magic = rng.Next(0, 8);
        
        string[] answers=[
        "Signs point to no",
        "Absolutley not",
        "Your fortune look hazy",
        "I wouldn't test your luck",
        "Positively",
        "... it's best not to say now",
        "No doubt about it",
        "Fortune is in your favor"
        ];
        return answers[Magic];
    }
    }
}