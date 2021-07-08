using System;

namespace Quiz
{
    class Program
    {
        static void Main(string[] args)
        {
           // Console.WriteLine("Hello World!");

            Question patrick = new Question("Patrick");

            patrick.WelcomeToQuiz();
            Console.WriteLine("-----------------------------------------------------------");
            Console.WriteLine("Please enter Question 1: ");
            string response1 = Console.ReadLine();
            Console.WriteLine("Enter possible response 1: ");
            string possible1 = "#1." + Console.ReadLine();
            Console.WriteLine("Enter possible response 2: ");
            string possible2 = "#2." + Console.ReadLine();
            Console.WriteLine("Enter possible response 3: ");
            string possible3 = "#3." + Console.ReadLine();
            Console.WriteLine("Enter possible response 4: ");
            string possible4 = "#4." + Console.ReadLine();
            string[] possibleResponses = { possible1, possible2, possible3, possible4 }; //combines user-inputted questions for possible responses
            Console.WriteLine("Please enter the number that is the correct response: ");
            string correctAnswerNotParsed = Console.ReadLine();
            int correctAnswer = Int32.Parse(correctAnswerNotParsed); //parses correct answer as an int so it can be used as an indice to access correct response


            MultipleChoice q1PossibleAnswers = new MultipleChoice(possibleResponses, "Hello");  //for question one possible answers 
            MultipleChoice q1 = new MultipleChoice(response1, ""); //for question number one
            MultipleChoice correct = new MultipleChoice(correctAnswer, "Hello");



            q1.IntroToSection();
            q1.ListFirstQuestion();
            q1PossibleAnswers.ListQ1Responses();
            correct.ReceiveAnswer();











        }
    }
}
