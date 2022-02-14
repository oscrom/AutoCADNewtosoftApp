using System.Windows;
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
      try
      {
        var json = "{\"menu\":{\"id\":\"file\",\"value\":\"File\",\"popup\":{\"menuitem\":[{\"value\":\"New\",\"onclick\":\"CreateNewDoc()\"},{\"value\":\"Open\",\"onclick\":\"OpenDoc()\"},{\"value\":\"Close\",\"onclick\":\"CloseDoc()\"}]}}}";
        MessageBox.Show(JsonConvert.DeserializeObject(json)?.ToString());
      }
      catch (Exception ex)
      {
        MessageBox.Show(ex?.Message);
      }
    }
  }
}
