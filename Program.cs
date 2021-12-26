using System;

namespace _15_Casting_And_Type_Conversion
{
    class Program
    {
        static void Main(string[] args)
        {
            int serialNo = 100;
            string accountNo = "";
            float anyNo = 3.5f;

            //accountNo = serialNo.ToString();
            accountNo = Convert.ToString(serialNo);
            

            Console.WriteLine("Account Number = " + accountNo);

            //serialNo = Convert.ToInt32(anyNo);
            serialNo = (int)anyNo;
            Console.WriteLine("Serial Number = " + serialNo);
        }
    }
}
