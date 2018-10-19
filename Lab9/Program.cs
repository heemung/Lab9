using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9
{
    class Program
    {
        static string strCheck;
        static void Main(string[] args)
        {

            List<string> names = new List<string>();
            NameAddList(names);

            List<string> homeTown = new List<string>();
            HometownAddList(homeTown);

            List<string> food = new List<string>();
            FoodAddList(food);

            List<string> color = new List<string>();
            ColorAddList(color);


            int studentNum, orginalNum;
            bool contYN = true, validData = true;
            string userAnswer;

            Console.WriteLine("Welcome to Our C# Class. ");

            while (contYN)
            {
                Console.WriteLine("\nWhat would you like to do?\nType 'add' to add student" +
                    " information. Type 'info' to look up student information.");
                if (WhichAddorRead() == true)
                {
                    while (true)
                    {
                        int countList = names.Count;
                        orginalNum = UserInput(countList);
                        studentNum = orginalNum - 1;
                        try
                        {
                            Console.WriteLine("Student {0} is {1}. What would you like to know" +
                                "about {2}? (enter of 'hometown', " +
                                "'favorite food' or 'color')",
                                orginalNum, names[studentNum], names[studentNum]);

                            userAnswer = Console.ReadLine().ToLower();
                            Answers(validData, userAnswer, names, homeTown, food,
                                color, studentNum);


                            Console.WriteLine("Do you want to run this again? 'Yes' or 'No'");
                            contYN = ContinueMethod();
                            break;

                        }
                        catch (ArgumentOutOfRangeException)
                        {
                            Console.WriteLine("Error: please a number between 1 and {0}." +
                                " Try Again\n", countList);
                            studentNum = 0;
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Adding New Student!\n");
                    AddtoLists(names, homeTown, food, color);
                }

            }
            Console.WriteLine("Thank You Come Again!");
            Console.ReadLine();
        }

        static int UserInput(int ammountOfListObjects)
        {
            int userInput;
            Console.WriteLine("Which student would you" +
            " like to learn more about? (enter a number 1-{0})",ammountOfListObjects);
            try
            {
                userInput = int.Parse(Console.ReadLine());
                return userInput;
            }
            catch (FormatException)
            {
                Console.WriteLine("ERROR: Please check your input");
                return UserInput(ammountOfListObjects);
            }
        }

        static bool ContinueMethod()
        {
            strCheck = Console.ReadLine().ToLower();
            if (strCheck == "yes")
            {
                return true;
            }
            else if (strCheck == "no")
            {
                return false;
            }
            else
            {
                Console.WriteLine("You entered something besides yes or no.\n " +
                    "Please Try Again. 'yes' or 'no'");
                return ContinueMethod();
            }
        }

        static bool WhichAddorRead()
        {
            strCheck = Console.ReadLine().ToLower();
            if (strCheck == "add")
            {
                return false;
            }
            else if (strCheck == "info")
            {
                return true;
            }
            else
            {
                Console.WriteLine("You entered something besides yes or no.\n " +
                    "Please Try Again. 'yes' or 'no'");
                return WhichAddorRead();
            }
        }

        static void AddtoLists(List<string> names,
        List<string> hometown, List<string> food, List<string> color)
        {
            Console.Write("Please enter the name of the student: ");
            names.Add(CheckBlankData(Console.ReadLine()));
            Console.Write("\nPlease enter the hometown of the student: ");
            hometown.Add(CheckBlankData(Console.ReadLine()));
            Console.Write("\nPlease enter the favorite food of the student: ");
            food.Add(CheckBlankData(Console.ReadLine()));
            Console.Write("\nPlease enter the favorite color of the student: ");
            color.Add(CheckBlankData(Console.ReadLine()));
        }

        static string CheckBlankData(string temp)
        {
            while (true)
            {
                if (temp == "")
                {
                    Console.WriteLine("Please enter valid data.");
                    temp = Console.ReadLine();
                }
                else
                {
                    return temp;
                }
            }
        }

        static void Answers(bool validData, string userAnswer, List<string> names,
        List<string> hometown, List<string> food, List<string> color, int studentNum)
        {
            while (validData)
            {
                switch (userAnswer)
                {
                    case "hometown":
                        {
                            Console.WriteLine("{0} hometown is {1}. Would you like to know more?" +
                                " (enter 'yes' or 'no')", names[studentNum], hometown[studentNum]);

                            if (!ContinueMethod())
                            {
                                validData = false;
                            }
                        }
                        break;

                    case "favorite food":
                        {
                            Console.WriteLine("{0} favorite food is {1}. Would you like to know more?" +
                                " (enter 'yes' or 'no')", names[studentNum], food[studentNum]);
                            if (!ContinueMethod())
                            {
                                validData = false;
                            }
                        }
                        break;
                    case "color":
                        {
                            Console.WriteLine("{0} favorite color is {1}. Would you like to know more?" +
                                " (enter 'yes' or 'no')", names[studentNum], color[studentNum]);
                            if (!ContinueMethod())
                            {
                                validData = false;
                            }
                        }
                        break;
                    default:
                        {
                            Console.WriteLine("That data does not exist. Please Try Again: \n");
                            break;
                        }

                }
                if (validData == true)
                {
                    Console.WriteLine("What do you want to know about {0}? (enter of 'hometown', " +
                        "'favorite food' or 'color')", names[studentNum]);
                    userAnswer = Console.ReadLine().ToLower();
                }
            }
        }

        static void UserInputAddListData()
        {

        }

        static void NameAddList(List<string> namesList)
        {
            namesList.Add("Clayton");
            namesList.Add("Jim");
            namesList.Add("Bob");
            namesList.Add("Billy Bob");
            namesList.Add("Maurico");
            namesList.Add("Heemung");
            namesList.Add("Sammie");
            namesList.Add("Sam");
            namesList.Add("Dumb Person Bill");
            namesList.Add("Taylor");
            namesList.Add("Matthew");
            namesList.Add("Sean0");
            namesList.Add("Jacky");
            namesList.Add("Tony");
            namesList.Add("Heather");
            namesList.Add("Dan the Man");
            namesList.Add("Dan not the Man");
            namesList.Add("Rodney");
            namesList.Add("Cara");
            namesList.Add("Drug Guy");
        }

        static void HometownAddList(List<string> townList)
        {
            townList.Add("Indy");
            townList.Add("JimVille");
            townList.Add("Ja");
            townList.Add("Billy Bobbyville");
            townList.Add("US");
            townList.Add("Korea");
            townList.Add("Indiana");
            townList.Add("Country");
            townList.Add("the dump");
            townList.Add("Cali");
            townList.Add("Space");
            townList.Add("Knightstown");
            townList.Add("Jackyville");
            townList.Add("Tony Town");
            townList.Add("Heats");
            townList.Add("Manville");
            townList.Add("not manville");
            townList.Add("ktown");
            townList.Add("Indianapolis");
            townList.Add("Hell");
        }

        static void FoodAddList(List<string> foodList)
        {
            foodList.Add("ice cream");
            foodList.Add("carrots");
            foodList.Add("pizza");
            foodList.Add("hot dogs");
            foodList.Add("fries");
            foodList.Add("chips");
            foodList.Add("dog food");
            foodList.Add("hamburger");
            foodList.Add("grass");
            foodList.Add("apples");
            foodList.Add("steak");
            foodList.Add("beer");
            foodList.Add("baked potatos");
            foodList.Add("hero dogs");
            foodList.Add("bacon");
            foodList.Add("24oz steak");
            foodList.Add("babies");
            foodList.Add("bananas");
            foodList.Add("fruit");
            foodList.Add("coke");
        }

        static void ColorAddList(List<string> namesList)
        {
            namesList.Add("blue");
            namesList.Add("yellow");
            namesList.Add("green");
            namesList.Add("black");
            namesList.Add("red");
            namesList.Add("purple");
            namesList.Add("pink");
            namesList.Add("brown");
            namesList.Add("clear");
            namesList.Add("blue");
            namesList.Add("blue");
            namesList.Add("green");
            namesList.Add("green");
            namesList.Add("white");
            namesList.Add("pink");
            namesList.Add("gold");
            namesList.Add("baby poop brown");
            namesList.Add("orange");
            namesList.Add("purple");
            namesList.Add("super white");
        }

        static void ReIndexLists()
        {
        
        }

    }
}

