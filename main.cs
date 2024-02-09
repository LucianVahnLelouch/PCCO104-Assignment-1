using System;

class Program
{
    public static void Main(string[] args)
    {
        decimal bills = 1;

        switch (bills)
        {
        case 0.01M:
                Console.WriteLine("No Person is found in Php " + bills);
                break;
        case 0.05M:
                Console.WriteLine("No Person is found in Php " + bills);
                break;
        case 0.25M:
                Console.WriteLine("No Person is found in Php " + bills);
                break;
            case 1:
                Console.WriteLine("Jose Rizal is found in Php " + bills);
                break;
            case 5:
                Console.WriteLine("Emilio Aguinaldo is found in Php " + bills);
                break;
            case 10:
                Console.WriteLine("Andres Bonifacio, Apolinario Mabini is found in Php " + bills);
                break;
            case 20:
                Console.WriteLine("Manuel L. Quezon is found in Php " + bills);
                break;
            case 50:
                Console.WriteLine("Sergio Osmena is found in Php " + bills);
                break;
            case 100:
                Console.WriteLine("Manuel Roxas is found in Php " + bills);
                break;
            case 200:
                Console.WriteLine("Diosdado Macapagal is found in Php " + bills);
                break;
            case 500:
                Console.WriteLine("Benigno Sr. and Corazon Aquino is found in Php " + bills);
                break;
            case 1000:
                Console.WriteLine("Jose Abad Santos, Vicent Lim, Josefa Llanes Escoda are found in Php " + bills);
                break;
            default:
                Console.WriteLine("Invalid Denomination: " + bills);
                break;
        }
    }
}
