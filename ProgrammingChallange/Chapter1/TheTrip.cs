using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingChallange.Chapter1
{
    public class TheTrip
    {
        private List<int> toBeOperated;
        public void setInput(List<int> inputs)
        {
            toBeOperated = inputs;
        }

        public List<int> calculate()
        {
            List<int> result = new List<int>();

            // setting up the new trip
            int pos = 0;
            int currentval = toBeOperated[pos];
            
            while (currentval > 0)
            {
                // initialization
                pos++; 
                int totalExchange = 0;

                // do a loop to figure out the total cost
                for (int i = pos; i < pos+currentval; i++)
                {
                    totalExchange += toBeOperated[i];
                }
                
                // divide the total cost by number of persons
                totalExchange = totalExchange / currentval;

                // traverse again to find out how much that person owed
                int resultVal = 0;
                for (int i = pos; i < pos + currentval; i++)
                {
                    int tempVal =  totalExchange - toBeOperated[i];
                    // if it's larger than 0 means he's owing the others, add it to money need to be paid
                    if (tempVal > 0)
                    {
                        resultVal += tempVal;
                    }
                }

                // add the result
                result.Add(resultVal);

                // navigate to the next trips
                pos += (int)(currentval);
                currentval = toBeOperated[pos];

            }


            return result;
        }
    }
}
