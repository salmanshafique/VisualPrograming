using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
            {
                int number;
                String [] dob;

                Console.WriteLine("Enter your number of siblings: ");
                number = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter their date of birth please MM DD YYYY: ");
                dob = new String[number];
                for (int i = 0; i < dob.Length; i++)
                {
                    Console.WriteLine("Enter the date of birth of sibling {0}:  ",i+1);
                    dob[i] = Console.ReadLine();     
                }

                DateTime[] date_array = new DateTime[dob.Length];
                for (int i = 0; i < dob.Length; i++)
                {
                    date_array[i] = Convert.ToDateTime(dob[i]);
                }

                Array.Sort(date_array);
                TimeSpan[] age_span = new TimeSpan[dob.Length];
                DateTime today = DateTime.Today;
                for (int i = 0; i < dob.Length; i++)
                {
                    age_span[i] = today - date_array[i];
                }

                DateTime[] FinalAge = new DateTime[age_span.Length];
                for(int i = 0; i<FinalAge.Length; i++)
                 FinalAge[i]= DateTime.MinValue + age_span[i];


                int years, months, days;
                for (int i = 0; i < FinalAge.Length; i++)
                {
                    //MinValue is 1/1/1 so we have to subtract
                    years = FinalAge[i].Year - 1;
                    months = FinalAge[i].Month - 1;
                    days = FinalAge[i].Day - 1;
                    Console.WriteLine("Age of sibling " + (i+1) + " is: " +years + " years " + months + " months " + days + " days");
                }
                
                    Console.Read();
          }
   }