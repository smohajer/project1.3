using System;

namespace project13
{
    class Program
    {
        static void ReplaceSpaces(char[] str, int trueLength)
        {
            //counts the spaces for string passed in (as char)
            int spaceCount = 0;
            for (int i = 0; i< trueLength;i++)
            {
                if (str[i]==' ')
                {
                    spaceCount++;
                }
            }

            //builds new number to build the array off of, with extra spaces added since we need to remove space  and add %20
            int index = trueLength + (spaceCount * 2);
            if (trueLength < str.Length) str[trueLength] = '\0';

            // initialize new array with new index
            char[] newArray = new char[index];
            //work from end to front and replace space if needed, else copy the char over
            for (int i=trueLength-1;i>=0;i--)
            {
                if (str[i]==' ')
                {
                    newArray[index - 1] = '0';
                    newArray[index - 2] = '2';
                    newArray[index - 3] = '%';
                    index = index - 3;
                }
                else
                {
                    newArray[index - 1] = str[i];
                    index--;
                }

            }
            Console.WriteLine(newArray);
        }
        static void Main(string[] args)
        {
            string random = "I love Lamp!";
            char[] something = random.ToCharArray();
            ReplaceSpaces(something, something.Length);
        }
    }
}
