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
        public string BedRoomNumber { get; set; }
        public string BathroomNumber { get; set; }
        public string HouseAddress { get; set; }
        public string RentPerWeek { get; set; }
        public string Lattitude { get; set; }
        public string Longitude { get; set; }
    }
}
