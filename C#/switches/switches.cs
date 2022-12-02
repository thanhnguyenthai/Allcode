using System;
namespace iswitches
{
    class Program
    {
        static void Main(string[] args)
        {
            // switch = an efficient alternative to many else if statements

            System.Console.WriteLine("What day is it today?");
            String day = Console.ReadLine();
        /*
            if (day == "Monday")
            {
                Console.WriteLine("Its Monday");
            }
            else if (day == "Tuesday")
            {
                Console.WriteLine("Its Tuesday ");
            }
            else if (day == "Wednesday")
            {
                Console.WriteLine("Its Wednesday");
            }
            else if (day == "Thursday")
            {
                Console.WriteLine("Its Thursday");
            }
            else if (day == "Friday")
            {
                Console.WriteLine("Its Friday");
            }
            else if (day == "Saturday")
            {
                Console.WriteLine("Its Saturday");
            }
            else if(day == "Sunday")
            {
                Console.WriteLine("Its Sunday");
            }

            else 
            {System.Console.WriteLine(day + "is not a day");}
        */   
        

        // We should do it like this:

        switch (day)
        {
            case "Monday":
            System.Console.WriteLine("Its Monday");
            break;
            case "Tues":
            System.Console.WriteLine("Its Tues");
            break;
            case "Wed":
            System.Console.WriteLine("Its Wed");
            break;
            case "Thus":
            System.Console.WriteLine("Its Thus");
            break;  
            case "Fri":
            System.Console.WriteLine("Its Fri");
            break;
            case "SAT":
            System.Console.WriteLine("Its SAT");
            break;
            case "SUN":
            System.Console.WriteLine("Its SUN");
            break;  
            default:
            System.Console.WriteLine(day + " is not a day");
            break;
        }
            
            Console.ReadKey();
        }
    }
}