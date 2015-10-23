using System;
using MerchToolAccess.MerchManagementService;

namespace MerchToolAccess
{
    class Program
    {
        static void Main()
        {
            var merch = new MerchManagementServiceClient();
            var ptn = merch.GetProductTypeById(GetPtn()).ProductType;
            var productId = ptn.Id;
            var cap = ptn.Caption;

            Console.WriteLine("The caption for your product PTN {0} is {1}", productId, cap);
            Console.WriteLine("Hit any key to close.");
            Console.ReadLine();
        }

        static int GetPtn()
        {
            Console.Write("Which PTN are you looking for?");
            var theptn = Convert.ToInt32(Console.ReadLine());
            return theptn;
        }
    }
}
