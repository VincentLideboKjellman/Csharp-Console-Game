using System;

namespace TheConsoleGame
{
    class Program
    {
        static void Main(string[] args)
        {
            //INTRODUCTION
            Console.WriteLine("========================");
            Console.WriteLine("Welcome to One Is Wrong!");
            Console.WriteLine("========================");
            Console.WriteLine("You will guess which of three items that does not belong, if you choose wrong you will loose!");
            Console.WriteLine(" ");
            Console.WriteLine("Are you ready? Y/N");

            string startResponse = Console.ReadLine();

            if(string.Equals(startResponse, "y", StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("Great! good luck!");
                Quiz();
            }
            else
            {
                Console.WriteLine("Please follow instructions or be ready! Restart program when you feel ready...");
            }
            //

        }

        public static void Quiz()
        {
            //RANDOM COMMENT
            Random randomComment = new Random();
            string[] randomCommentArray = { "Phew! You did it!", "Wohoooo! Right answer!", "OMG EZPZ, you da winner!", "Nice! right answer!" };
            int randomCommentIndex = randomComment.Next(randomCommentArray.Length);

            //GAME QUESTIONS
            string[] questionsArray = { "1.Apple 2.Orange 3.Yellow", "1.Tiger 2.Ball 3.Bull", "1.Java 2.C# 3.CSS", "1.1 2.2 3.4", "1.4 Spaces 2.tabs 3.programming (This one is tricky hehe, BUT IT SHOULD NOT BE!)" };
            //answers
            int[] rightAnswerArray = { 3, 2, 3, 3, 1 };
            //

            //GAME

            //Question 1
            Console.WriteLine("Which one does not fit in?");
            Console.WriteLine(questionsArray[0]);
            var answer = int.Parse(Console.ReadLine());
            if (answer == rightAnswerArray[0])
            {
                Console.WriteLine($"{randomCommentArray[randomCommentIndex]}");

                //question 2
                Console.WriteLine("Next questions are: ");
                Console.WriteLine(questionsArray[1]);
                answer = int.Parse(Console.ReadLine());
                if (answer == rightAnswerArray[1])
                {
                    Console.WriteLine($"{randomCommentArray[randomCommentIndex]}");

                    //question 3
                    Console.WriteLine(questionsArray[2]);
                    answer = int.Parse(Console.ReadLine());
                    if (answer == rightAnswerArray[2])
                    {
                        Console.WriteLine($"{randomCommentArray[randomCommentIndex]}");

                        //question 4
                        Console.WriteLine(questionsArray[3]);
                        answer = int.Parse(Console.ReadLine());
                        if (answer == rightAnswerArray[3])
                        {
                            Console.WriteLine($"{randomCommentArray[randomCommentIndex]}");

                            //question 5
                            Console.WriteLine(questionsArray[4]);
                            answer = int.Parse(Console.ReadLine());
                            if (answer == rightAnswerArray[4])
                            {
                                Win();
                            }
                            else
                            {
                                WrongAnswer();
                            }
                        }
                        else
                        {
                            WrongAnswer();
                        }
                    }
                    else
                    {
                        WrongAnswer();
                    }
                }
                else
                {
                    WrongAnswer();
                }
            }
            else
            {
                WrongAnswer();

            }


        }
        public static void Win()
        {
            Console.WriteLine("Good Answer! Actually, you won this whole game, Worth your 49,99€? Good");
            Console.WriteLine("Also dont forget to sign up at oneiswrong@bestgame.scam to recieve news about ");
            Console.WriteLine("the brand new DLC but this time only available on your smartphone!");
        }
        public static void WrongAnswer()
        {
            Console.WriteLine("Oopsie! Wrong answer, You might think that your answer actually did fit to the other options. if so please contact our customer support at: ");
            Console.WriteLine("oneiswrong@bestgame.scam");
        }
    }
}
