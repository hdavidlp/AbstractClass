using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass.BL
{
    public abstract class DataAccess
    {
        private string _server="No server";
        public virtual string Server { get { return _server; } }
        public string Connecting(string server)
        {
            _server = server;
            return $"Connecting {Server}";
        }

        public abstract string GettingData();
        public abstract string SavingData();
    }
}
