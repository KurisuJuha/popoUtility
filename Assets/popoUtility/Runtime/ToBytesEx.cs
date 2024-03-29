using System;
using System.Text;


namespace JuhaKurisu.PopoTools.Utility
{
    public static class ToBytesEx
    {
        public static byte[] ToBytes(this bool value)
            => BitConverter.GetBytes(value);

        public static byte[] ToBytes(this byte value)
            => new byte[] { value };

        public static byte[] ToBytes(this sbyte value)
            => BitConverter.GetBytes(value);

        public static byte[] ToBytes(this Int16 value)
            => BitConverter.GetBytes(value);

        public static byte[] ToBytes(this UInt16 value)
            => BitConverter.GetBytes(value);

        public static byte[] ToBytes(this Int32 value)
            => BitConverter.GetBytes(value);

        public static byte[] ToBytes(this UInt32 value)
            => BitConverter.GetBytes(value);

        public static byte[] ToBytes(this Int64 value)
            => BitConverter.GetBytes(value);

        public static byte[] ToBytes(this UInt64 value)
            => BitConverter.GetBytes(value);

        public static byte[] ToBytes(this char value)
            => BitConverter.GetBytes(value);

        public static byte[] ToBytes(this Single value)
            => BitConverter.GetBytes(value);

        public static byte[] ToBytes(this Double value)
            => BitConverter.GetBytes(value);

        public static byte[] ToBytes(this string value)
            => Encoding.UTF8.GetBytes(value);
    }
}