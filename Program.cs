using System;
using Microsoft.ReportingServices.RdlObjectModel;
using Microsoft.ReportingServices.RdlObjectModel.Serialization;
using System.IO;
using System.Reflection;
using System.Xml;
using System.Xml.Schema;
namespace HelloWorld;

class Program
{
    static void Main(string[] args)
    {
        // Assembly a = Assembly.GetExecutingAssembly();
        // Stream s = a.GetManifestResourceStream("Microsoft.ReportingServices.RdlObjectModel.Serialization.ReportDefinition.xsd");
        // Console.WriteLine(s == null);
    // FileStream fs = File.OpenRead("ReportDefinition.xsd");
    // Console.WriteLine(XmlSchema.Read(fs, null));
    // Console.WriteLine(fs.Length);
    Report _report = Report.Load(@"/workspaces/codespaces-blank/a.rdl");
    // Report _report = new Report();
    RdlSerializer serializer = new RdlSerializer();
    MemoryStream ms = new MemoryStream();
    serializer.Serialize(ms, _report);
    ms.Position = 0;
    StreamReader reader = new StreamReader(ms);
    string text = reader.ReadToEnd();
    Console.WriteLine(text);
    }
}