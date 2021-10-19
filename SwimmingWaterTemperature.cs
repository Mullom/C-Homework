/*
Cengage Mindtap C# Programming Exercise 11-2 ArgumentException
Instructions
Write the application SwimmingWaterTemperature containing a variable that can hold a temperature expressed in degrees Fahrenheit. 
Within the class, create a method that accepts a parameter for a water temperature and returns true or false, 
indicating whether the water temperature is between 70 and 85 degrees and thus comfortable for swimming. 
If the temperature is not between 32 and 212 (the freezing and boiling points of water), 
it is invalid, and the method should throw an ArgumentException.

In the Main() method, continuously prompt the user for data temperature, pass it to the method, 
and then display the following messages indicating whether the temperature is comfortable, not comfortable, or invalid:
X degrees is comfortable for swimming.
X degrees is not comfortable for swimming.
Value does not fall within the expected range.
*/


using System;
using static System.Console;
class SwimmingWaterTemperature
{
    static void Main()
    {
        const int QUIT = 999;
        bool isComfortable;
        int waterTemperature;
        Write("Enter temperature or {0} to quit >> ", QUIT);
        int.TryParse(ReadLine(), out waterTemperature);
        while (waterTemperature != QUIT)
        {
            try
            {
                isComfortable = CheckComfort(waterTemperature);
                if (isComfortable)
                    WriteLine("{0} degrees is comfortable for swimming.", waterTemperature);
                else
                    WriteLine("{0} degrees is not comfortable for swimming.", waterTemperature);
            }
            catch (ArgumentException ae)
            {
                WriteLine(ae.Message);
                WriteLine("Exception caught. ");
            }
            Write("Enter another temperature or {0} to quit >> ", QUIT);
            int.TryParse(ReadLine(), out waterTemperature);
        }
    }

    public static Boolean CheckComfort(int temp)
    {
        if (temp >= 70 && temp <= 85)
        {
            return true;
        }
        else if (temp >= 32 && temp <= 212)
        {
            return false;
        }
        else
        {
            throw new ArgumentException("Value does not fall within the expected range.");
        }
    }
}
