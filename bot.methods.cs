using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatBot
{
    internal partial class bot
    {
        Human human = new Human();

        public void Start()
        {        

            Console.WriteLine("HELLO IN MY BOT");
            Console.Write("Enter Your Name : "); human.SetName(Console.ReadLine());

            Console.Write("Enter Your Age  : "); human.SetAge(int.Parse(Console.ReadLine()));
           
            Console.Write("Enter Your Id   : "); human.SetId(int.Parse(Console.ReadLine()));

            Console.Clear();
            ReadFromUser();
        }
        public void ReadFromUser()
        {

            Console.WriteLine("FOR START =>> 1");
            input = byte.Parse(Console.ReadLine());

            if (input == 1)
            {
                Console.Clear();
                Options();
            }
            else
            {
                Console.WriteLine("Your Option Is Not Correct ");
                Console.WriteLine("Please Enter Valid Option ");
                ReadFromUser();
            }
        }
        public void Options()
        {
            Console.WriteLine("1 : About Me ");
            Console.WriteLine("2 : About Bot");
           

            input=byte.Parse(Console.ReadLine());
            if (input == 1) { About_me(); }
            else if (input==2) { About_Bot(); }
        }
        public void About_me()
        {
            human.HumanDetails();
            NewOption();
        }
        public void About_Bot()
        {
            Bot_Details();
            NewOption() ;
        }
        public void Stop() 
        {
            Console.WriteLine("Enjoy " +human.GetName());
        }
        public void NewOption()
        {
            Console.WriteLine("Do You Want Another Opthion ");
            Console.WriteLine(" Y || N");
            NewDesition=char.Parse(Console.ReadLine());
            if (NewDesition=='Y'||NewDesition=='y')
            {
                Console.Clear();
                Options();  
            }else if (NewDesition=='N'||NewDesition=='n')
            {
                Console.Clear();
                Stop();
            }
        }
    }
}
