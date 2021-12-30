using Adapter.Interfaces;
using System;

namespace Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            ILumiaXMLTarget lumiaXMLTarget = new LumiaXMLAdapter();
            var xmlLumiaMobile = lumiaXMLTarget.GetLumiaMobilesXMLSpecifications();
            Console.WriteLine(xmlLumiaMobile.InnerText);

            Console.Read();
        }
    }
}
