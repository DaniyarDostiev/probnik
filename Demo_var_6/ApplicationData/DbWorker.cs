using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_var_6.ApplicationData
{
    internal class DbWorker
    {
        private static probnik_2Entities _context;
        public static probnik_2Entities GetContext()
        {
            if (_context == null)
            {
                _context = new probnik_2Entities();
            }
            return _context;
        }
    }
}
