using System;
using System.IO;

namespace Exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                File.Open(@"C:file.txt", FileMode.Open);
            }
            catch(IOException ioException)
            {
                throw;
            }
            finally
            {
                //code will always executed;
            }
        }

        private static void Do()
        {
            throw new InvalidTimeZoneException();
        }
    }
}
