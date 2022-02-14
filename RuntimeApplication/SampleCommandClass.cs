using Autodesk.AutoCAD.ApplicationServices;
using Autodesk.AutoCAD.Runtime;
using RuntimeApplication;
using Newtonsoft.Json;

[assembly: CommandClass(typeof(SampleCommandClass))]
namespace RuntimeApplication
{
    public class SampleCommandClass
    {
        [CommandMethod("SAMPLE", "SAMPLE_TestWPFCommand", CommandFlags.NoPaperSpace)]
        public static void TestWPFMethod()
        {
        }
    }
}
