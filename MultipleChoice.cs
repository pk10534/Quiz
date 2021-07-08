using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz
{
    class MultipleChoice : Question
    {

        public string Question1 { get; set; }
        public string Question2 { get; set; }
        public string[] PossibleAnswers { get; set; }
        public int CorrectResponse { get; set; }


        public MultipleChoice(string question1, string name) : base(name)
        {
            this.Question1 = question1;
        }

        public MultipleChoice(string[] possibleAnswers, string name) : base(name) //says to get possible answers from user for question 1
        {
            this.PossibleAnswers = possibleAnswers;
        }



        public MultipleChoice(int correctResponse, string name) : base(name) //this lets them set the indice of the correct response from the array
        {
            this.CorrectResponse = correctResponse;
        }

        public void IntroToSection() //first to be written
        {
            Console.WriteLine("This is the multiple choice portion of the quiz. You will be presented with one question, with four possible responses. Only one will be correct");
        }

        public void ListFirstQuestion() //lists the initial question
        {
            Console.WriteLine(Question1);
        }

        public void ListQ1Responses() //listing the components of the array for possible answers
        {
            //Console.WriteLine(PossibleAnswers);
            foreach (var response in PossibleAnswers)
            {
                Console.WriteLine(response);
            }
        }

        
        
        public void ReceiveAnswer() //takes answer from user, converts it to an int which can be used to access the indice Correct Response, and then informs user if it is correct or not.
        {
            Console.WriteLine("Enter your answer here in numeric format (for example '2'): ");
            string answer1 = Console.ReadLine();
            int answer1Proper = Int32.Parse(answer1);
            if (answer1Proper == CorrectResponse)
            {
                Console.WriteLine("Correct! Pleaese move on to the True/False question");
            }
            else
            {
                Console.WriteLine("Sorry, that is incorrect.");
            }
        }

 










    }
}
