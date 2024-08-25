using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Net.Mail;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*A2Q1 a1q1 = new A2Q1();
            a1q1.function1();
            Console.ReadLine();*/

            /*A2Q2 a1q2 = new A2Q2();
            a1q2.function2();
            Console.ReadLine();*/
            /*
                        ATM myATM = new ATM(5000); 
                        myATM.function3();
                        Console.ReadLine();*/


            /* A2Q4 a1q4 = new A2Q4();
             a1q4.function4();
             Console.ReadLine();*/
            /*
                        A2Q5 validator = new A2Q5();
                        validator.function5();
            
                        Console.ReadLine(); */
            A2Q6 a6 = new A2Q6();
            a6.function6();
            Console.ReadLine();


        }
                }
            }
/*class A2Q1 {
    public void function1() {
        int size = Convert.ToInt32(Console.ReadLine());
     decimal[] a = new decimal[size];
        for (int i = 0; i < size; i++) {
            a[i] = Convert.ToDecimal(Console.ReadLine());
        }
        decimal sum = 0;
        foreach (int i in a) {
            sum += i;
        }
        if (sum > 3000) {
            sum = sum * 10 / 100;
        }
        Console.WriteLine(sum);
    } }
*/
/*class A2Q2
{
    public void function2()
    {
        Console.Write("Enter the temperature in Celsius: ");
        double c = Convert.ToDouble(Console.ReadLine());
        double F = (c * 9 / 5) + 32;
        Console.WriteLine("The temp in fahrenheit is" + F);
        if (c < 0)
        {
            Console.WriteLine("Warning: The temperature is below freezing!");
        }
    }
}
*/

/*class ATM
{
    private decimal balance;

    public ATM(decimal initialBalance)
    {
        balance = initialBalance;
    }

    public void function3()
    {
        while (true)
        {
            Console.WriteLine("1. Check Balance");
            Console.WriteLine("2. Deposit Money");
            Console.WriteLine("3. Withdraw Money");
            Console.WriteLine("4. Exit");
            Console.Write("Select an option (1-4): ");
            int choice = Convert.ToInt32(Console.ReadLine());

            if (choice == 1)
            {
                CheckBalance();
            }
            else if (choice == 2)
            {
                DepositMoney();
            }
            else if (choice == 3)
            {
                WithdrawMoney();
            }
            else if (choice == 4)
            {
                Console.WriteLine("Thank you for using the ATM. Goodbye!");
                return; //exit the current method
            }
            else
            {
                Console.WriteLine("Invalid option. Please select a valid option.");
            }
        }
    }

    private void CheckBalance()
    {
        Console.WriteLine($"\nYour current balance is: Rs. {balance}");
    }

    private void DepositMoney()
    {
        Console.Write("\nEnter the amount to deposit: Rs. ");
        decimal depositAmount = Convert.ToDecimal(Console.ReadLine());
        balance += depositAmount;
        Console.WriteLine($"Your new balance is: Rs. {balance}");
    }

    private void WithdrawMoney()
    {
        decimal withdrawAmount = Convert.ToDecimal(Console.ReadLine());

        if (withdrawAmount <= balance)
        {
            balance -= withdrawAmount;
            Console.WriteLine($"Your new balance is: Rs. {balance}");
        }
        else
        {
            Console.WriteLine("Error: Insufficient funds for this withdrawal.");
        }
    }
}

*/

/*class A2Q4 {
    public void function4() {
        int size = Convert.ToInt32(Console.ReadLine());
        int[] a = new int[size];
        for (int i = 0; i < size; i++) {
            a[i] = Convert.ToInt32(Console.ReadLine());
        }
        int sum = 0;
        foreach (int i in a) { 
            sum+= i;    
        }
        double avg = sum / size;
        char grade;
        if (avg >= 90) {
            grade = 'A';
        }
        else if (avg >= 80)
        {
            grade = 'B';
        }
        else if (avg >= 70)
        {
            grade = 'C';
        }
        else if (avg >= 60)
        {
            grade = 'D';
        }
        else
        {
            grade = 'F';
        }
        Console.WriteLine($"\nAvg marks: {avg}");
        Console.WriteLine($"grade: {grade}");
    }
}
*/
/*class A2Q5
{
    public void function5()
    {
        String password = Console.ReadLine();
        if (isValid(password))
        {
            Console.WriteLine("passwrod is valid");
        }
        else {
            Console.WriteLine("password is invalid");
       }
}
static bool isValid(string password) {
        if (password.Length < 8)
        {
            return false;
        }

        bool hasUppercase = false;
        bool hasLowercase = false;
        bool hasDigit = false;

        // Iterate through each character in the password
        foreach (char c in password)
        {
            if (char.IsUpper(c))
            {
                hasUppercase = true;
            }
            else if (char.IsLower(c))
            {
                hasLowercase = true;
            }
            else if (char.IsDigit(c))
            {
                hasDigit = true;
            }

           
            if (hasUppercase && hasLowercase && hasDigit)
            {
                return true;
            }
        }

       
        return false;
    }
}
   */

/*class A2Q6
{

    public double fare;
    public void function6()
    {
        double distance = Convert.ToDouble(Console.ReadLine());
        float hour = Convert.ToSingle(Console.ReadLine());
        int km = Convert.ToInt32(Console.ReadLine());
        int flat = 20;
        if (distance <= 2)
        {
            fare = flat;
        }
        else
        {
            fare = flat + (distance - 2) * km;
        }
        if (hour >= 10) {
            fare += fare + 10;
        }
        Console.WriteLine(fare);
    }
}
*/

class A2Q7 {
    bool[] a=new bool[5];
    
    

}