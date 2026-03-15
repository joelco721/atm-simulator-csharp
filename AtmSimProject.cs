using System;

public class Bank
{ 
    static string userName;
    static string passWord;
    static int balance = 1000;
    public static void Account()
    {
      while (true)
      {

       Console.WriteLine("Create Username");
       userName = Console.ReadLine();
       Console.WriteLine("Create Password");
       passWord = Console.ReadLine();

       if (userName == passWord)
        {
            Console.WriteLine("You cannot have the same Username and Password, Please choose a new Username or Password");
            continue;
        }

        else
        {
            Login();
            break;
        }

        
      }
     
    }

    public static void Welcome()
    {
        Console.WriteLine($"Welcome {userName}"); 
      while (true)
      {    
        Console.WriteLine("1. Check balance\n2. Deposit\n3. Withdraw\n4. Exit");
        string choose = Console.ReadLine();

        if (choose == "1")
        {
            Console.WriteLine($"Your total balance is ${balance}");
        }

        else if (choose == "2")
        {
            Console.WriteLine("Enter the ammount of money you would like to deposit");
            if (int.TryParse(Console.ReadLine(), out int deposit))
            { 
                    
               Console.WriteLine($"You've deposited ${deposit} and your total balance is ${balance += deposit}");
            }
            
        }

        else if (choose == "3")
        {
           Console.WriteLine($"Your balance is ${balance}.\nHow much money you would like to withdraw?");
           if (int.TryParse(Console.ReadLine(), out int withdraw ))
           {
          
              if (withdraw <= balance)
              {
                Console.WriteLine($"You withdrew ${withdraw} and your total balance is ${balance -= withdraw}");
              }

              else 
              {
                Console.WriteLine("Not enough money in your account");
              }
           }

        }

        else
        {
            Console.WriteLine("Goodbye!");
            break;
        }

      }  

    }


    public static void Login()
    {   
      Console.WriteLine("Congrats you just opened your bank account\nIn order to login to your account you must sign in.");
     while (true) 
     {
      Console.WriteLine("Enter your Username");
      string loginusr = Console.ReadLine();
      Console.WriteLine("Enter your Password");
      string loginpass = Console.ReadLine();

      if (userName == loginusr && passWord == loginpass)
      {
         Welcome();
         break;
      }
      else
      {
         Console.WriteLine("Invalid Creds");
      }

     } 
      

    }


    public static void Main()
    {
       
       Console.WriteLine("Welcome To Bank Joel\n1. To Create An Account\n2. Exit");
       string enter = Console.ReadLine();

        if (enter == "1")
          {
            Account();
          }
       
        else 
          {
            Console.WriteLine("Goodbye!");
          }
    
        
    }



  





}









