using System;

namespace csharp_Cashmachine
{
    class Program
    {
        //      void withdrawl(int bankBalance, int userInput){
        //         bankBalance -=userInput;
        //         Console.WriteLine("my new bank balanve is : {0}", bankBalance);
        // }

    int bankBalance = 1000;
            string userInput;
        void checkPin()
        {
        START:
            string pinNumber = "1000";
            Console.Write("please enter your input: ");
            userInput = Console.ReadLine();

            if (pinNumber == userInput){
                Menu();
            } else{
                Console.Write("Please Enter Correct Pin ");
            }

            
        }
        void Menu(){
                Console.WriteLine("Welcome A-aron, type 1 for withdraw type 2 to deposit or type 3 to check balance or press any key to exit  ");
                userInput = Console.ReadLine();

                if(userInput == "1"){
                    withdrawl();
                }else if(userInput == "2"){
                    deposit();
                }else if(userInput == "3"){
                    checkBalance();
                }else{
                    Console.WriteLine("have a Great Day ");
                } 
                }
        void withdrawl()
        {
        //setting the balance in the bank 
            
            //setting the user input to be what i want to withdraw 
            string userInput;

            Console.Write("how much would you like to withdraw: ");
            // asking the user how much they would like to withdraw 
            userInput = Console.ReadLine();
            //logging the users input
            Console.WriteLine(userInput);
            //converting the user inpout to a string then doing the sum
            bankBalance -= Convert.ToInt32(userInput);
            //logging the resukts 
            Console.WriteLine("your new balance is: {0}", bankBalance);
             Menu();
        }
        void deposit()
        {

            string userInput;

            Console.Write("how much would you like to deposit: ");
            userInput = Console.ReadLine();
            Console.WriteLine(userInput);
            bankBalance += Convert.ToInt32(userInput);
            Console.WriteLine("your new balance is: {0}", bankBalance);
            Menu();
        } 
        void checkBalance()
        {
            Console.WriteLine("your Balance is : {0}", bankBalance);
            Menu();
        }
        static void Main(string[] args)
        {
            Program Cashmachine = new Program();
            Cashmachine.checkPin();

            // Cashmachine.checkBalance();
            // Cashmachine.withdrawl();
            // Cashmachine.deposit();

        }

    }
}
