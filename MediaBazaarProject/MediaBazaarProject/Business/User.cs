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

        public string Name { get; set; }
        public Position Position { get; set; }

        public User(string name, Position position)
        {
            this.name = name;
            this.position = position;
        }

        public User()
        {

        }

        public Position SetPosition(int position)
        {
            Position setPosition = Position.WORKER;

            switch (position)
            {
                case 0:
                    setPosition = Position.ADMIN;
                    break;

                case 1:
                    setPosition = Position.MANAGER;
                    break;

                case 2:
                    setPosition = Position.WORKER;
                    break;


            }
            return setPosition;

        }
    }
}
