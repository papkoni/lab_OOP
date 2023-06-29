namespace first_lab;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Input bool variable");
        bool BoolVariable = Convert.ToBoolean(Console.ReadLine());

        Console.WriteLine("Input byte variable");
        byte ByteVariable = Convert.ToByte(Console.ReadLine());

        Console.WriteLine("Input sbyte variable");
        sbyte SByteVariable = Convert.ToSByte(Console.ReadLine());

        Console.WriteLine("Input char variable");
        char CharVariable = Convert.ToChar(Console.ReadLine());

        Console.WriteLine("Input float variable");
        float FloatVariable = Convert.ToSingle(Console.ReadLine());

        Console.WriteLine("Input double variable");
        double DoubleVarible = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Input decimal variable");
        decimal DecimalVariable = Convert.ToDecimal(Console.ReadLine());

        Console.WriteLine("Input int variable");
        int IntVariable  = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Input uint variable");
        uint UintVariable = Convert.ToUInt32(Console.ReadLine());


        Console.WriteLine("variables:");
        Console.WriteLine(" bool variable: {0}", BoolVariable);
        Console.WriteLine(" byte variable: {0}", ByteVariable);
        Console.WriteLine(" sbyte variable: {0}", SByteVariable);
        Console.WriteLine(" char variable: {0}", CharVariable);
        Console.WriteLine(" double variable: {0}", DoubleVarible);
        Console.WriteLine(" decimal variable: {0}", DecimalVariable);
        Console.WriteLine(" int variable: {0}", IntVariable);
        Console.WriteLine(" uint variable: {0}", UintVariable);




    }
}

