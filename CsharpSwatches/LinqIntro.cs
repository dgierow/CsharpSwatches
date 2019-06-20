using System.Collections.Generic;
using System.Linq;

namespace CsharpSwatches
{
    internal static class LinqIntro
    {
        internal static IEnumerable<int> GetEvenQuery(int[] numbers)
        {
            var numQuery =
                from num in numbers
                where (num % 2) == 0
                select num;

            return numQuery;
        }

        private class Customer
        {
            public string Name { get; set; }
            public string Address { get; set; }
            public string PhoneNumber { get; set; }

        }

        private static void SampleCode()
        {
            List<Customer> customers = new List<Customer>();

            var floridaCustomers = from c in customers
                                   where c.Address.EndsWith(" FL")
                                   select new { c.Name, c.PhoneNumber };

        }
    }
}
