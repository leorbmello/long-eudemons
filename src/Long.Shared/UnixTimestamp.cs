﻿namespace Long.Shared
{
    public static class UnixTimestamp
    {

        public static int Now => (int)(DateTime.Now - DateTime.UnixEpoch).TotalSeconds;

        public static DateTime ToDateTime(int seconds) => DateTime.UnixEpoch.AddSeconds(seconds);
        public static DateTime ToDateTime(uint seconds) => DateTime.UnixEpoch.AddSeconds((int)seconds);

        public static DateTime? ToNullableDateTime(int? seconds)
        {
            int value = seconds.GetValueOrDefault(0);
            if (value == 0)
            {
                return null;
            }
            return ToDateTime(value);
        }

        public static DateTime? ToNullableDateTime(uint? seconds)
        {
            uint value = seconds.GetValueOrDefault(0);
            if (value == 0)
            {
                return null;
            }
            return ToDateTime(value);
        }

        public static DateTime FromUintDate(uint data)
        {
            return new DateTime((int)(2000 + data / 1000000),
               (int)((data % 1000000) / 10000),
              (int)((data % 10000) / 100),
               (int)(data % 100), 0, 0);
        }

        public static int FromDateTime(DateTime? dateTime) 
        {
            if (dateTime.HasValue)
            {
                return (int)(dateTime.Value - DateTime.UnixEpoch).TotalSeconds;
            }
            return 0;
        }

        public static int ToUnixTimestamp(this DateTime dateTime)
        {
            return FromDateTime(dateTime);
        }
    }
}
