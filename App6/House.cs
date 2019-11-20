using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace App6
{
    class House
    {
        public double BedRoomNumber { get; set; }
        public double BathroomNumber { get; set; }
        public string HouseAddress { get; set; }
        public double RentPerWeek { get; set; }
    }
}