namespace LoggingKata
{
    /// <summary>
    /// Parses a POI file to locate all the Taco Bells
    /// </summary>
    public class TacoParser
    {
        readonly ILog logger = new TacoLogger();
        
        public ITrackable Parse(string line) // takes string called line
        {
            logger.LogInfo("Begin parsing");

            // Take your line and use line.Split(',') to split it up into an array of strings, separated by the char ','
            var cells = line.Split(','); // split a string and truns it into an array of strings

            // If your array.Length is less than 3, something went wrong
            if (cells.Length < 3)
            {
                // Log that and return null
                // Do not fail if one record parsing fails, return null
                return null; // TODO Implement
            }

            // grab the latitude from your array at index 0 DONE
               var lat = double.Parse(cells[0]);
            // grab the longitude from your array at index 1 DONE
               var lng = double.Parse(cells[1]);
            // grab the name from your array at index 2 DONE
               var name = cells[2];
            // Your going to need to parse your string as a `double`
            // which is similar to parsing a string as an `int`

            // You'll need to create a TacoBell class
            // that conforms to ITrackable DONE

            // Then, you'll need an instance of the TacoBell class
            // With the name and point set correctly DONE
            
             var point = new Point();
             point.Latitude = lat;   
             point.Longitude = lng;

             var tacoBell = new TacoBell();
             tacoBell.Location = point;
             tacoBell.Name = name;
             

            // Then, return the instance of your TacoBell class
            // Since it conforms to ITrackable DONE

            return tacoBell;
        }
    }
}