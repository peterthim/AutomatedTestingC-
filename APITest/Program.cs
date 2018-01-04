using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace APITest
{
    class Program
    {
        static void Main(string[] args)
        {

            var client = new Client();
            client.EndPoint = @"https://restcountries.eu";
            client.Method = HttpVerb.GET;
            var pdata = client.PostData;
            var response = client.Request("/rest/v1/currency/eur");
        }
    }
}
