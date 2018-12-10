﻿using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Essentials;

namespace CitPark
{
    public class Settings
    {
        public readonly Settings _instance = new Settings();

        [Flags]
        public enum ParkTypesEnum
        {
            None = 0,
            Handicap = 1,
            Family = 2,
            Eletric = 4,
            Bike = 8
        }

        public Settings() { }

        public static bool TimerNotification { get; set; }
        public static bool DarkMode { get; set; }
        public static DistanceUnits SelectedDistanceUnit { get; set; }
        public static int DefaultTimer { get; set; }
        public static int WarnTime { get; set; }
        public static int SearchRadius { get; set; }

        // This setting will be in binary, so each 1 corresponds to a parking type
        public static int ParkTypes { get; set; }
    }
}
