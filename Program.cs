using System;
using System.IO;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            var filename = args[0];
            // File contains one number per line
            dynamic contents;   //Question #1 we can assign a dynamic value and run on try / catch 
            try{ 
                contents = File.ReadAllLines(filename);
            }catch (Exception e){
                //Fire Exception for unreachable file
            }

            int index = 0; 
            
            while (index != contents.Length - 1) 
            {
                var line = contents[index]; //Question #2 program will crash here since contents is empty there is no value on [index] 
                int mode = int.Parse(line);
                if (Int32.TryParse(mode.ToString(), out mode))//Question #4 Wrap the Parse inside an if that validates that the value is a number (continues)
                {
                    int factor = 0;
                    if (mode >= 1) factor = 10;
                    else if (mode <= -1) factor = 1; //Question #3 when Mode = 0 its not accounted for, only takes >=1 or <=-1
                    Console.WriteLine("Result = {0}", mode / factor);
                    index++;
                }
                else {
                    index++; //Question #4 just ignore and increase index to the next line
                }               
            }
        }
    }
}

