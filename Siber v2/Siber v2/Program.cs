using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace Siber_v2
{
    class Program
    {

        static void Main(string[] command)
        {
            XElement doc = XElement.Load("script1.xml");
            XElement doc2 = XElement.Load("script2.xml");
            XElement doc3 = XElement.Load("script3.xml");
            XElement doc4 = XElement.Load("script4.xml");
            XElement doc5 = XElement.Load("script5.xml");
            XElement script1 = doc.Element("script");
            XElement setting = doc.Element("output");
            XElement script2 = doc2.Element("script");
            XElement setting2 = doc2.Element("output");
            XElement script3 = doc3.Element("script");
            XElement setting3 = doc3.Element("output");
            XElement script4 = doc4.Element("script");
            XElement setting4 = doc4.Element("output");
            XElement script5 = doc5.Element("script");
            XElement setting5 = doc5.Element("output");
            Console.WriteLine(script1);
            Console.WriteLine(setting);
            Console.WriteLine(script2);
            Console.WriteLine(setting2);
            Console.WriteLine(script3);
            Console.WriteLine(setting3);
            Console.WriteLine(script4);
            Console.WriteLine(setting4);
            Console.WriteLine(script5);
            Console.WriteLine(setting5);
            a();

        }
        static void a() 
        {
            using (StreamWriter writer = new StreamWriter("outputsss.xml"))
            {
                Console.SetOut(writer);
                Act();
            }

        }
        static void Act()
        {
            XElement doc = XElement.Load("script1.xml");
            XElement doc2 = XElement.Load("script2.xml");
            XElement doc3 = XElement.Load("script3.xml");
            XElement doc4 = XElement.Load("script4.xml");
            XElement doc5 = XElement.Load("script5.xml");
            //XElement s = doc.Element("scaninfo");
            XElement script1 = doc.Element("script");
            XElement setting = doc.Element("output");
            XElement script2 = doc2.Element("script");
            XElement setting2 = doc2.Element("output");
            XElement script3 = doc3.Element("script");
            XElement setting3 = doc3.Element("output");
            XElement script4 = doc4.Element("script");
            XElement setting4 = doc4.Element("output");
            XElement script5 = doc5.Element("script");
            XElement setting5 = doc5.Element("output");
            Console.WriteLine(script1);
            Console.WriteLine(setting);
            Console.WriteLine(script2);
            Console.WriteLine(setting2);
            Console.WriteLine(script3);
            Console.WriteLine(setting3);
            Console.WriteLine(script4);
            Console.WriteLine(setting4);
            Console.WriteLine(script5);
            Console.WriteLine(setting5);
            Console.ReadKey();
        }
        
       

        }
    

    }
