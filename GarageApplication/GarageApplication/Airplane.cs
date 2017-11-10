﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarageApplication
{
    public class Airplane:Vehicle
    {
        private int noOfengines;
        public int NoOfEngines
        {
            get { return noOfengines; }
            set { NoOfEngines = value; }
        }
       

        public Airplane(string regnum, string col, int now, string tof, int noe) : base(regnum, col, now, tof)
        {
            NoOfEngines = noe;
        }

        public Airplane()
        {
        }

        public override string PrintVehicle()
        {
            return base.PrintVehicle() + "\n The" + GetType().Name + "contains" + NoOfEngines + " Engines ";
        }



    }
}
