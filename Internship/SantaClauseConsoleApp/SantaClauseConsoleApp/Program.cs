using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Text;//For witing in .txt file





namespace SantaClauseConsoleApp
{

    class Program
    {





        static void Main(string[] args)
        {
            Console.WriteLine("-------------------------------------------------Santa Delivery System-------------------------------------------------");
            Console.WriteLine("\n");

            Question1();
            Question2();
            Question3();
            Question4();
            Question5();
            Question6();
        }
        //I created a constant for the Enum for better usage
        private const BehaviorEnum good = BehaviorEnum.Good;
        private const BehaviorEnum bad = BehaviorEnum.Bad;
        //I created a global array of Child to acces them from any Question()
        public static Child[] children = new Child[7];
        public static Adress[] adresses = new Adress[7];

            

        static void Question1()
        {
            //Create letters for each child -> Create 3 children 
            LinkedList<Item> item11 = new LinkedList<Item>();
            Item item1 = new Item("RC CAR");
            Item item2 = new Item("CUBES");
            item11.AddLast(item1);
            item11.AddLast(item2);
            Letter letter1 = new Letter(new DateTime(2021, 10, 12), item11);
            children[1] = new Child("POP IONUT", new DateTime(2010, 1, 12), "BAIA MARE , STR HORTENSIEI NR 3", good, letter1);


            LinkedList<Item> item22 = new LinkedList<Item>();
            Item item3 = new Item("DOLL");
            Item item4 = new Item("CUBES");
            item22.AddLast(item3);
            item22.AddLast(item4);
            Letter letter2 = new Letter(new DateTime(2021, 10, 12), item22);
            children[2] = new Child("CIRT MIRELA", new DateTime(2010, 1, 12), "CLUJ-NAPOCA , STR DEALULUI NR 12", bad, letter2);


            LinkedList<Item> item33 = new LinkedList<Item>();
            Item item5 = new Item("RC CAR");
            Item item6 = new Item("CUBES");
            item33.AddLast(item5);
            item33.AddLast(item6);
            Letter letter3 = new Letter(new DateTime(2021, 10, 12), item33);
            children[3] = new Child("HAN DRAGOS", new DateTime(2010, 1, 12), "CLUJ-NAPOCA , STR MORII NR 29", 0, letter3);

            Console.WriteLine("##### 1 #####" + "\n");
            //Display the children on the Console
            for (int i = 1; i <= 3; i++)
                Console.WriteLine(children[i]);
        }



        static void Question2()
        {   //I search for the letter I manually wrote and put it in a string so I can work with it
            string letter1Location = @"C:\\Users\\claux\\Desktop\\WinterInternship2022-Backend-main\\SantaClauseConsoleApp\\SantaClauseConsoleApp\\letter1.txt";
            string letter1 = File.ReadAllText(letter1Location);

            //I generate a list of items/toys from the .txt file so I can create a new Letter object
            LinkedList<Item> Scrisoare1 = new LinkedList<Item>();
            Item item1 = new Item(letter1.Split('[', ']')[9]);
            Item item2 = new Item(letter1.Split('[', ']')[11]);
            Scrisoare1.AddLast(item1);
            Scrisoare1.AddLast(item2);
            Letter letter11 = new Letter(new DateTime(2021, 10, 12), Scrisoare1);//Since in the README->REQUIREMENTS at #### 2. it wasn`t specified the date of the letters I had to manually write, I randomly choose dates to be able to create the Letter object

            //I read the age from the letter and convert it to int
            string age11 = letter1.Split('[', ']')[3];
            int age1 = Int16.Parse(age11);

            //Create the child
            children[4] = new Child(letter1.Split('[', ']')[1], new DateTime(letter11.DataScrierii.Year - age1, letter11.DataScrierii.Month, letter11.DataScrierii.Day), letter1.Split('[', ']')[5], 0, letter11);

            //I read the child behavior from the letter I manually wrote and change it to BehaviorEnum type 
            string behaviour1 = letter1.Split('[', ']')[7];
            if (behaviour1 == "GOOD")
                children[4].Comportament = BehaviorEnum.Good;
            else
                children[4].Comportament = BehaviorEnum.Bad;



            //I search for the letter I manually wrote and put it in a string so I can work with it
            string letter2Location = @"C:\\Users\\claux\\Desktop\\WinterInternship2022-Backend-main\\SantaClauseConsoleApp\\SantaClauseConsoleApp\\letter2.txt";
            string letter2 = File.ReadAllText(letter2Location);

            //I generate a list of items/toys from the .txt file so I can create a new Letter object
            LinkedList<Item> Scrisoare2 = new LinkedList<Item>();
            Item item3 = new Item(letter1.Split('[', ']')[9]);
            Item item4 = new Item(letter1.Split('[', ']')[11]);
            Scrisoare2.AddLast(item3);
            Scrisoare2.AddLast(item4);
            Letter letter22 = new Letter(new DateTime(2021, 10, 12), Scrisoare2);//Since in the README->REQUIREMENTS at #### 2. it wasn`t specified the date of the letters I had to manually write, I randomly choose dates to be able to create the Letter object

            //I read the age from the letter and convert it to int
            string age22 = letter2.Split('[', ']')[3];
            int age2 = Int16.Parse(age22);

            //Create the child
            children[5] = new Child(letter2.Split('[', ']')[1], new DateTime(letter22.DataScrierii.Year - age2, letter22.DataScrierii.Month, letter22.DataScrierii.Day), letter2.Split('[', ']')[5], 0, letter22);

            //I read the child behavior from the letter I manually wrote and change it to BehaviorEnum type 
            string behaviour2 = letter2.Split('[', ']')[7];
            if (behaviour2 == "GOOD")
                children[5].Comportament = BehaviorEnum.Good;
            else
                children[5].Comportament = BehaviorEnum.Bad;



            //I search for the letter I manually wrote and put it in a string so I can work with it
            string letter3Location = @"C:\\Users\\claux\\Desktop\\WinterInternship2022-Backend-main\\SantaClauseConsoleApp\\SantaClauseConsoleApp\\letter3.txt";
            string letter3 = File.ReadAllText(letter3Location);

            //I generate a list of items/toys from the .txt file so I can create a new Letter object
            LinkedList<Item> Scrisoare3 = new LinkedList<Item>();
            Item item5 = new Item(letter3.Split('[', ']')[9]);
            Item item6 = new Item(letter3.Split('[', ']')[11]);
            Scrisoare3.AddLast(item5);
            Scrisoare3.AddLast(item6);
            Letter letter33 = new Letter(new DateTime(2021, 10, 12), Scrisoare3);//Since in the README->REQUIREMENTS at #### 2. it wasn`t specified the date of the letters I had to manually write, I randomly choose dates to be able to create the Letter object

            //I read the age from the letter and convert it to int
            string age33 = letter3.Split('[', ']')[3];
            int age3 = Int16.Parse(age33);

            //Create the child
            children[6] = new Child(letter3.Split('[', ']')[1], new DateTime(letter33.DataScrierii.Year - age3, letter33.DataScrierii.Month, letter33.DataScrierii.Day), letter3.Split('[', ']')[5], 0, letter33);

            //I read the child behavior from the letter I manually wrote and change it to BehaviorEnum type 
            string behaviour3 = letter3.Split('[', ']')[7];
            if (behaviour3 == "GOOD")
                children[6].Comportament = BehaviorEnum.Good;
            else
                children[6].Comportament = BehaviorEnum.Bad;

            Console.WriteLine("\n" + "##### 2 #####" + "\n");
            //Display the children from the letters
            for (int i = 4; i <= 6; i++)
                Console.WriteLine(children[i]);

            //Display children names as stated in Requirements -> 2.
            /* for (int i = 4; i <= 6; i++)
                 Console.WriteLine(children[i].Name);*/
        }



        static void Question3()
        {
            //For generating a letter I need the age of the child but I only have the date of birth and the date the letter was written
            int age1 = children[1].Scrisoare.DataScrierii.Year - children[1].DataNastere.Year;

            //Having the letter predifined format I build the leatear with custom values from children
            string writeLetter1 =
                "Dear Santa, " +
                "\nI am [" + children[1].Name + "]" +
                "\nI am [" + age1 + "] years old. I live at [" + children[1].Adresa + "]. I have been a very [" + children[1].Comportament + "] child this year" +
                "\nWhat I would like the most this Christmas is:" +
                "\n[" + children[1].Scrisoare.Jucarii.First.Value + "],[" + children[1].Scrisoare.Jucarii.Last.Value + "]";

            //Having the letter in string format I write it intro a .txt file in the app folder
            StreamWriter sw1 = new StreamWriter("C:\\Users\\claux\\Desktop\\WinterInternship2022-Backend-main\\SantaClauseConsoleApp\\SantaClauseConsoleApp\\generatedLetter1.txt", true, Encoding.ASCII);
            sw1.Write(writeLetter1);
            sw1.Close();

            //Repeat process from above
            int age2 = children[2].Scrisoare.DataScrierii.Year - children[2].DataNastere.Year;
            string writeLetter2 =
                "Dear Santa, " +
                "\nI am [" + children[2].Name + "]" +
                "\nI am [" + age2 + "] years old. I live at [" + children[2].Adresa + "]. I have been a very [" + children[2].Comportament + "] child this year" +
                "\nWhat I would like the most this Christmas is:" +
                "\n[" + children[2].Scrisoare.Jucarii.First.Value + "],[" + children[2].Scrisoare.Jucarii.Last.Value + "]";

            StreamWriter sw2 = new StreamWriter("C:\\Users\\claux\\Desktop\\WinterInternship2022-Backend-main\\SantaClauseConsoleApp\\SantaClauseConsoleApp\\generatedLetter2.txt", true, Encoding.ASCII);
            sw2.Write(writeLetter2);
            sw2.Close();

            //Repeat process from above
            int age3 = children[3].Scrisoare.DataScrierii.Year - children[3].DataNastere.Year;
            string writeLetter3 =
                "Dear Santa, " +
                "\nI am [" + children[3].Name + "]" +
                "\nI am [" + age3 + "] years old. I live at [" + children[3].Adresa + "]. I have been a very [" + children[3].Comportament + "] child this year" +
                "\nWhat I would like the most this Christmas is:" +
                "\n[" + children[3].Scrisoare.Jucarii.First.Value + "],[" + children[3].Scrisoare.Jucarii.Last.Value + "]";

            StreamWriter sw3 = new StreamWriter("C:\\Users\\claux\\Desktop\\WinterInternship2022-Backend-main\\SantaClauseConsoleApp\\SantaClauseConsoleApp\\generatedLetter3.txt", true, Encoding.ASCII);
            sw3.Write(writeLetter3);
            sw3.Close();

            Console.WriteLine("\n" + "##### 3 #####");
            Console.WriteLine("\n" + "Check the letters created in SantaClauseConsoleApp named generatedLetter");
        }

        static void Question4()
        {

            string letter1 = @"C:\\Users\\claux\\Desktop\\WinterInternship2022-Backend-main\\SantaClauseConsoleApp\\SantaClauseConsoleApp\\generatedLetter1.txt";
            string letter11 = File.ReadAllText(letter1);
            string letter2 = @"C:\\Users\\claux\\Desktop\\WinterInternship2022-Backend-main\\SantaClauseConsoleApp\\SantaClauseConsoleApp\\generatedLetter2.txt";
            string letter22 = File.ReadAllText(letter2);
            string letter3 = @"C:\\Users\\claux\\Desktop\\WinterInternship2022-Backend-main\\SantaClauseConsoleApp\\SantaClauseConsoleApp\\generatedLetter3.txt";
            string letter33 = File.ReadAllText(letter3);

            string[] toys = { letter11.Split('[', ']')[9], letter11.Split('[', ']')[11],
                letter22.Split('[', ']')[9], letter22.Split('[', ']')[11], letter33.Split('[', ']')[9],
                letter33.Split('[', ']')[11] };




            SortedDictionary<int, string> sort = new SortedDictionary<int, string>(new DescendingComparer<int>());
            Console.WriteLine("\n");
            var groups = toys.GroupBy(v => v);
            foreach (var group in groups)
                sort.Add(group.Count(), group.Key);

            Console.WriteLine("#### 4 ####" + "\n");
            Console.WriteLine("Toy report:");

            foreach (var kvp in sort)
                Console.WriteLine("{1} - {0}", kvp.Key, kvp.Value);


        }

        static void Question5()
        {
            Console.WriteLine("##### 5 ##### " + "\n");
            Console.WriteLine("I dont think that in this implementation the Singleton Pattern can be applied");
            Console.WriteLine("The Singleton Pattern ensure that a class has just a single instance");
            Console.WriteLine("In our case we use class Child to create a number of Child objects that we use across the methods and each of their personal data needs to be stored ");
            Console.WriteLine("So if we tried to use Singleton Patter, upon creating a new Child object, the previous Child object would be deleted and we don`t want that!");
        }

        static void Question6()
        { 
            Console.WriteLine("\n" + "##### 6 #####");
            Console.WriteLine("\n" + "I couldn`t finish this question but i have commented the code i`ve done to it so far");
            Console.WriteLine("\n" + "Happy Holidays");


            /*for(int i= 1; i <=children.Length ; i++)
              {   // I create a new clas that has the adress and city from each child
                  adresses[i].City = children[i].Adresa.Split(',')[0];
                  adresses[i].Street = children[i].Adresa.Split(',')[1];


              }
              for (int i = 1; i <= children.Length; i++)
              {//I try to sort them adresses by the city
                  int j = 0;
                  while (adresses[i].City == adresses[j].City)
                  {
                      Console.WriteLine(adresses[i].Street);
                      j++;
                  }
              }*/

        }
            
            
        }




        }


    

    // Class to write toys in descending order 
    class DescendingComparer<T> : IComparer<T> where T : IComparable<T>
    {
        public int Compare(T x, T y)
        {
            return y.CompareTo(x);
        }
    }


