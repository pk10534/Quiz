using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz
{

    public abstract class Intros
    {
        public abstract void IntroToSection();
        public abstract void ListFirstQuestion();
    }

    class Question
    {

        public string[] AllQuestions { get; set; }
        public string Name { get; set; }
        
        public Question(string name)
        {
            this.Name = name;
        }
        

        public void WelcomeToQuiz()
        {
            Console.WriteLine("Welcome to the quiz! You will be presented with a Multiple Choice Question, aTrue/False statement, and a question where there could be multiple correct responses. Good luck!");
        }

        




        /*
        public Question (string[] questions)
        {
            this.AllQuestions = questions;
        }
        */















    }
}
