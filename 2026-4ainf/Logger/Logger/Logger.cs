using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logger
{
    internal class Logger
    {
        private static Logger _istanza;
        
        private Logger()
        {

        }

        internal static Logger Istanza { 
            get {
                if (_istanza == null)
                {
                    _istanza = new Logger();
                }

                return _istanza;
            }
        }

        /*
        public static Logger Istanza()
        {
           if (_istanza == null)
            {
                _istanza = new Logger();
            }

            return _istanza;
        }
        */
        public void Log(string message)
        {
            Console.WriteLine(message);
        }
    }
}
