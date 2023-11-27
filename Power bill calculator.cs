using System;
using System.ComponentModel.Design;

class Program
{
    static void Main()
    {
     
            Console.WriteLine("Welcome to the power billing system");
            Console.WriteLine("Below are the types of usage with their respective codes");
            Console.WriteLine("1 Residential");
            Console.WriteLine("2 Commercial");
            Console.WriteLine("3 Industrial");
        int typeOfUsage;
        decimal monthlyConsumption;

        while (true)
        {

            Console.WriteLine("Enter your code:");
            string userInputTypeOfUsage = Console.ReadLine();

            if (int.TryParse(userInputTypeOfUsage, out typeOfUsage) && typeOfUsage <= 3 && typeOfUsage > 0)
            {
                break;
            }
            else
            {
                Console.WriteLine("Enter a valid code!!");
            }
        }



        while (true)
        {
            Console.WriteLine("Enter your monthly consumption");
            string userInputAmountOfUsage = Console.ReadLine();
            if (decimal.TryParse(userInputAmountOfUsage, out  monthlyConsumption))
            {
                break;
            }
            else
            {
                Console.WriteLine("Enter a valid Monthly consumption input!!");
            }
        }
        
                        static decimal ResidentialBillingAlgorithm(decimal monthlyConsumption)
                        {
                            decimal monthlyPowerBill = monthlyConsumption * 12.50m;
                            Console.WriteLine($"Your monthly power bill is :{monthlyConsumption}kWh * 12.50 = {monthlyPowerBill}kes");
                            return monthlyPowerBill;
                        }

                        static decimal CommercialBillingAlgorithm(decimal monthlyConsumption)
                        {
                            decimal monthlyPowerBill = monthlyConsumption * 15.75m;
                            Console.WriteLine($"Your monthly power bill is :{monthlyConsumption}kWh * 15.75 = {monthlyPowerBill}kes");
                            return monthlyPowerBill;
                        }

                        static decimal IndustrialBillingAlgorithm(decimal monthlyConsumption)
                        {
                            decimal monthlyPowerBill = monthlyConsumption * 18.90m;
                            Console.WriteLine($"Your monthly power bill is :{monthlyConsumption}Kwh * 18.90 = {monthlyPowerBill}kes");
                            return monthlyPowerBill;
                        }

                        if (typeOfUsage == 1)
                        {
                            ResidentialBillingAlgorithm(monthlyConsumption);
                        }
                        else if (typeOfUsage == 2)
                        {
                            CommercialBillingAlgorithm(monthlyConsumption);
                        }
                        else if (typeOfUsage == 3)
                        {
                            IndustrialBillingAlgorithm(monthlyConsumption);
                        }

   }
}








