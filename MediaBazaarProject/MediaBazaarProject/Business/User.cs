using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaBazaarProject.Business
{
    public class User
    {
        private string name;
        private Position position;

        public User(string name, Position position)
        {
            this.name = name;
            this.position = position;
        }
    }
}
