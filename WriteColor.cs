//dotnet new console -o Munhasiradam

using System;

namespace Munhasiradam
{
    class WriteColor_class
    {
        public static void Main(string[] args)
        {
             // variables
            int[] array_values;
            int total_value = 0, answer = 0;
            bool while_control = true;

            Console.WriteLine("Press any key to continue.. \n");

            while(while_control)
            {
                if(total_value == 0)
                {
                    //first opening || false answer
                    
                    // Next metotunu kullanabilmek icin Random sinifini Random tipinde veri tutucuya instance ile implement ediyorum
                    Random rnd = new Random();
                
                    // numbers array 
                    array_values = new int[]
                    {
                        rnd.Next(1,6),
                        rnd.Next(5,10)
                    };
                    
                    // to print the array in the correct form
                    for(int i=0; i < array_values.Length; i++)
                    {
                        // Length metotunun ilk eleman degeri 1 ile baslar dizi elemanlarinda ilk index 0 tanimli deger ile baslar
                        if(i == array_values.Length -1) // 1 == (2-1)
                        {
                            Console.Write(array_values[i] + " = ");
                        }
                        else if(i < array_values.Length)
                        {
                            Console.Write(array_values[i] + " + ");
                        }
                        
                        total_value += array_values[i];		
                    }
                    
                    // exception handling
                    try 
                    {
                        answer = Convert.ToInt32(Console.ReadLine());
                    }
                    catch
                    {
                        if(answer == 0)
                        {
                            Console.WriteLine("\n----- PLEASE WRITE A CORRECT VALUE ! -----\n");
                        }
                    }
                    finally
                    {
                        if(answer != 0)
                        {
                            Console.WriteLine("\nAnswer -> " + answer);
                        }
                    }
                }
                else if(answer != total_value)
                {
                    if(answer != 0)
                    {
                        //bad method
                        Cave_func();
                    }

                    // reset values (refresh)
                    total_value = 0;
                    answer = 0;
                }
                else if(answer == total_value)
                {
                    //good method
                    WriteColor("Answer [TRUE] congratulations");
                    while_control = false;
                }
                else
                {
                    Console.WriteLine("Ben Jarvis degilim, beklenmeyen bir durum ile karsilasildi ...");
                    while_control = false;
                }
            }

            Console.WriteLine("The loop is over.");
        }

        // - - - - - Ma -> property funcs 

        //good method
        private static void WriteColor(string system_message)
        {
            for(int i=0; i < system_message.Length; i++)
            {
                char char_i = system_message[i];
                string string_i = Convert.ToString(char_i);
                
                if(string_i == "[")
                {
                    string_i = null;
                    Console.Write(string_i);
                    Console.ForegroundColor = ConsoleColor.Green;       
                }
                else if(string_i == "]")
                {
                    string_i = null;
                    Console.ResetColor();  
                    Console.Write(string_i);           
                }
                else
                {
                    Console.Write(string_i);
                }
            }
            
            Console.WriteLine("...");
        }

        //bad method
        private static void Cave_func()
        {
            Console.Write("Answer [");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("FALSE");
            Console.ResetColor();
            Console.WriteLine("] please try again...");
        }
    }
}
