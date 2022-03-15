﻿using System;
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


        public Shifts SetShiftType(string inputShift)
        {
            Shifts shift = Shifts.MORNING;
         
            switch (inputShift)
            {
                case "Morning":
                    shift = Shifts.MORNING;
                    break;

                case "Day":
                    shift = Shifts.MIDDAY;
                    break;

                case "Night":
                    shift = Shifts.EVENING;
                    break;
            }

            return shift;
        }
    }
}
