using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaBazaarProject.Business
{
    public class User
    {

        public int Id { get; set; }
        private string name;
        private Position position;

        public string FirstName { get; set; }
        public Position Position { get; set; }

        public User(string firstName, Position position)
        {
            this.FirstName = firstName;
            this.Position = position;
        }

        public User()
        {

        }

        public Position SetPosition(string position)
        {
            Position setPosition = Position.SALES;

            switch (position)
            {
                case "ADMIN":
                    setPosition = Position.ADMIN;
                    break;

                case "MANAGER":
                    setPosition = Position.MANAGER;
                    break;

                case "SALES":
                    setPosition = Position.SALES;
                    break;

                case "WAREHOUSE":
                    setPosition = Position.WAREHOUSE;
                    break;
            }
            return setPosition;

        }
    }
}
