using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaBazaarProject.Business
{
    public class EnumManager
    {
        public Position SetPosition(int position)
        {
            Position setPosition = Position.SALES;

            switch (position)
            {
                case 0:
                    setPosition = Position.ADMIN;
                    break;

                case 1:
                    setPosition = Position.MANAGER;
                    break;

                case 2:
                    setPosition = Position.SALES;
                    break;

                case 3:
                    setPosition = Position.WAREHOUSE;
                    break;

            }
            return setPosition;

        }
        public Position GetPosition(string position)
        {
            Position setPosition = Position.SALES;

            switch (position)
            {
                case "Admin":
                    setPosition = Position.ADMIN;
                    break;

                case "Manager":
                    setPosition = Position.MANAGER;
                    break;

                case "Sales":
                    setPosition = Position.SALES;
                    break;

                case "Warehouse":
                    setPosition = Position.WAREHOUSE;
                        break;
            }
            return setPosition;

        }

        public Shifts SetShiftType(string inputShift)
        {
            Shifts shift = Shifts.MORNING;
         
            switch (inputShift)
            {
                case "Morning":
                    shift = Shifts.MORNING;
                    break;

                case "Midday":
                    shift = Shifts.MIDDAY;
                    break;

                case "Evening":
                    shift = Shifts.EVENING;
                    break;
            }

            return shift;
        }
        public List<EnumCategory> listCategories() {
            EnumCategory[] array = (EnumCategory[])Enum.GetValues(typeof(EnumCategory));
            List<EnumCategory> listCategories = new List<EnumCategory>();
            foreach (EnumCategory i in array ) {
                listCategories.Add(i);
            }
            return listCategories;
        }
        public EnumCategory getProductCategory(string category) {
            EnumCategory enumCategory = EnumCategory.MOBILE;
            switch (category) {
                case "COMPUTER":
                    enumCategory = EnumCategory.COMPUTER;
                    break;
                case "HOSUEHOLD":
                    enumCategory = EnumCategory.HOUSEHOLD;
                    break;
                case "BEAUTYandCARE":
                    enumCategory = EnumCategory.BEAUTYandCARE;
                    break;
            }
            return enumCategory;
        }
    }
}
