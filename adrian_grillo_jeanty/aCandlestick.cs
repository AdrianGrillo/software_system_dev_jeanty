using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adrian_grillo_jeanty
{
    internal class aCandlestick
    {
        public Decimal open;
        public Decimal close;
        public Decimal high;
        public Decimal low;
        public long volume;
        public DateTime date;

        // Defining our own default constructor
        public aCandlestick() { }

        // Without this custom default constructor, this class would use the built in default constructor
        // Which would then call each member classes default constructors
        // Decimal and long would be set to 0
        // DateTime is set to the moment in time its default constructor is called
        
        // The order of the arguments matter, you can leave off any number of arguments from the end
        // It will know what arguments are missing
        public aCandlestick(
            DateTime date,
            decimal open = 0, 
            decimal close = 0, 
            decimal high = 0, 
            decimal low = 0, 
            long volume = 0
            )
        {
            this.date = date;
            this.open = open;
            this.close = close;
            this.high = high;
            this.low = low;
            this.volume = volume;
        }

        // This constructor takes a string and parses it then assigns the correct values accordingly
        public aCandlestick(String rowOfData)
        {

        }
    }
}
