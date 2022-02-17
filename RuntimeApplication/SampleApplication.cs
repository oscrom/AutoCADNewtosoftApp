using System.Windows;
using Newtonsoft.Json;
using Autodesk.AutoCAD.Runtime;
using RuntimeApplication;

[assembly: ExtensionApplication(typeof(SampleApplication))]
namespace RuntimeApplication
{
  public class SampleApplication : IExtensionApplication
  {
    public void Initialize()
    {
      try
      {
        var json = "{\"menu\":{\"id\":\"file\",\"value\":\"File\",\"popup\":{\"menuitem\":[{\"value\":\"New\",\"onclick\":\"CreateNewDoc()\"},{\"value\":\"Open\",\"onclick\":\"OpenDoc()\"},{\"value\":\"Close\",\"onclick\":\"CloseDoc()\"}]}}}";
        MessageBox.Show($"RuntimeApplication1: {JsonConvert.DeserializeObject(json)}");
      }
      catch (Exception ex)
      {
        MessageBox.Show($"RuntimeApplication1: {ex.Message}");
      }
    }

    public void Terminate()
    {

    }
  }
}
