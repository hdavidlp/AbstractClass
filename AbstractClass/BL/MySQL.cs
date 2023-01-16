using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass.BL
{
    public class MySQL: DataAccess
    {
        public override string Server {
            get
            {
                return $"[MYSQL:{base.Server}]";
            }
        }

        public override string GettingData()
        {
            return $"Getting Data from MySQL {base.Server}";
        }

        public override string SavingData()
        {
            return $"Saving data to MySQL {base.Server}";
        }
        
    }
}
