namespace CommonStructuresSample
{
    using System;

    internal sealed class Program
    {
        private static void Main(string[] args)
        {
            // Left-hand-side declaration uses the type alias if applicable.
            // Right-hand-side initialization uses the type name.

            byte unsignedInteger8Min = Byte.MinValue;
            byte unsignedInteger8Max = Byte.MaxValue;
            Console.WriteLine($"Unsigned 8-bit integer range {unsignedInteger8Min} - {unsignedInteger8Max}");

            sbyte signedInteger8Min = SByte.MinValue;
            sbyte signedInteger8Max = SByte.MaxValue;
            Console.WriteLine($"Signed 8-bit integer range {signedInteger8Min} - {signedInteger8Max}");

            ushort unsignedInteger16Min = UInt16.MinValue;
            ushort unsignedInteger16Max = UInt16.MaxValue;
            Console.WriteLine($"Unsigned 16-bit integer range {unsignedInteger16Min} - {unsignedInteger16Max}");

            short signedInteger16Min = Int16.MinValue;
            short signedInteger16Max = Int16.MaxValue;
            Console.WriteLine($"Signed 16-bit integer range {signedInteger16Min} - {signedInteger16Max}");

            uint unsignedInteger32Min = UInt32.MinValue;
            uint unsignedInteger32Max = UInt32.MaxValue;
            Console.WriteLine($"Unsigned 32-bit integer range {unsignedInteger32Min} - {unsignedInteger32Max}");

            int signedInteger32Min = Int32.MinValue;
            int signedInteger32Max = Int32.MaxValue;
            Console.WriteLine($"Signed 32-bit integer range {signedInteger32Min} - {signedInteger32Max}");

            ulong unsignedInteger64Min = UInt64.MinValue;
            ulong unsignedInteger64Max = UInt64.MaxValue;
            Console.WriteLine($"Unsigned 64-bit integer range {unsignedInteger64Min} - {unsignedInteger64Max}");

            long signedInteger64Min = Int64.MinValue;
            long signedInteger64Max = Int64.MaxValue;
            Console.WriteLine($"Signed 64-bit integer range {signedInteger64Min} - {signedInteger64Max}");

            float floatingPoint16Min = Single.MinValue;
            float floatingPoint16Max = Single.MaxValue;
            Console.WriteLine($"Single precision 16-bit range {floatingPoint16Min} - {floatingPoint16Max}");

            double floatingPoint32Min = Double.MinValue;
            double floatingPoint32Max = Double.MaxValue;
            Console.WriteLine($"Double precision 32-bit range {floatingPoint32Min} - {floatingPoint32Max}");

            decimal floatingPoint128Min = Decimal.MinValue;
            decimal floatingPoint128Max = Decimal.MaxValue;
            Console.WriteLine($"Decimal 128-bit range {floatingPoint128Min} - {floatingPoint128Max}");

            Guid guid = Guid.NewGuid();
            Console.WriteLine($"Globally Unique Identifier (GUID) {guid}");

            DateTime dateTime = DateTime.Now;
            Console.WriteLine($"Date and Time {dateTime}");

            Console.Read();
        }
    }
}
