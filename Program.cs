using System;

namespace atm_machine
{
    class ATM
    {
        public int amount;
        public int pin;
        public int pin1;
        public int pin2;
        public int prepin;
        public int check;
        public int current;
        public int input;
        public ATM()
        {
            amount = 10000;
            pin = 2580;

        }                   
    }
    class Program
    {
        static void Main(string[] args)
        {
            ATM myAtm = new ATM();
            Console.Write("enter your pin: ");
            myAtm.pin1 = Convert.ToInt32(Console.ReadLine());

            if (myAtm.pin1 == myAtm.pin)
            {
                Console.WriteLine("1. to check balance ");
                Console.WriteLine("2. to withdraw money");
                Console.WriteLine("3. to deposit money");
                Console.WriteLine("4. to change pin");

                Console.WriteLine("enter your choice");
                int ch = Convert.ToInt32(Console.ReadLine());
                switch (ch)
                {
                    case 1:
                        Console.WriteLine(" the current balance in your account is " + myAtm.amount);
                        break;

                    case 2:
                        Console.WriteLine("enter the amout you want to withdraw: ");
                        myAtm.input = Convert.ToInt32(Console.ReadLine());

                        if (myAtm.input >= myAtm.amount || myAtm.input % 100 == 0)
                        {
                            Console.WriteLine(" please take your cash " + myAtm.input);
                            myAtm.current = myAtm.amount - myAtm.input;
                            Console.WriteLine(myAtm.current);
                        }
                        else if (myAtm.input % 100 != 0)
                        {
                            Console.WriteLine("wrong input. please try again");
                        }
                        else
                        {
                            Console.WriteLine("please enter the amount you want to withdraw");
                        }
                        break;

                    case 3:
                        Console.WriteLine("enter the aount you want to deposit: ");
                        myAtm.input = Convert.ToInt32(Console.ReadLine());
                        myAtm.current = myAtm.input + myAtm.input;
                        Console.WriteLine(myAtm.current);

                        break;

                    case 4:
                        Console.WriteLine("to change pin");
                        Console.WriteLine("enter your privious pin");
                        myAtm.prepin = Convert.ToInt32(Console.ReadLine());
                        if (myAtm.prepin == myAtm.pin)
                        {
                            Console.WriteLine("enter a new pin: ");
                            myAtm.pin2 = Convert.ToInt32(Console.ReadLine());
                            myAtm.pin1 = myAtm.pin2;
                            Console.WriteLine("your  pin is changed");
                        }
                        else
                        {
                            Console.WriteLine("enter the correct pin");
                        }
                        break;

                    default:
                        Console.WriteLine("please enter the correct pin");
                     break;
                }

            }
            else
            {
               Console.WriteLine ("pin is wrong");
            }
            Console.ReadLine();
        }
    }
}
