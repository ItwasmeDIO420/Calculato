using System;

namespace Jaydens_program
{
    class Program
    {
        static void Main(string[] args)
        {
            // explain what these are
            int Number1 = 0;
            int Number2 = 0;
            int equation;

            string operater;

            //what is this doing?
            void getnumber1()
            {
                Console.WriteLine("what's your first number?");

                Number1 = Convert.ToInt32(Console.ReadLine());
           }
            //what is this doing?
            void getoperater()
            {
                Console.WriteLine("add,subtract,multiply or divide?");
                
                operater = Console.ReadLine();


            }
            //what is this doing?
            void getNumber2()
            {

                Console.WriteLine("what's the next number?");

                Number2 = Convert.ToInt32(Console.ReadLine());
            }
            //what is this doing?
            void addnumbers()
            {
                equation = Number1 + Number2;
                Console.WriteLine("answer = " + equation);
            }
            //what is this doing?
            void subtractnumbers()
            {// comment
                equation = Number1 - Number2;
                Console.WriteLine("answer = " + equation);
            }
            //what is this doing?
            void multiplynumbers()
            {
                equation = Number1 * Number2;
                Console.WriteLine("answer = " + equation);


            }
            //what is this doing?
            void dividenumbers()
            {
                equation = Number1 / Number2;
                Console.WriteLine("answer = " + equation);
            }
            //what is this doing?
            void domath()
            {
                if (operater == "+")
                {
                    addnumbers();
                }
                else if (operater == "-")
                {
                    subtractnumbers();
                }
                else if (operater == "*")
                {
                    multiplynumbers();
                }
                else if (operater == "/")
                {
                    dividenumbers();

                }

                else
                {
                    getoperater();
                    domath();
                }


            }
            getnumber1();
            getNumber2();
            getoperater();
            domath();
        }
    }
}
