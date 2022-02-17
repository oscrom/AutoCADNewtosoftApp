using System.Windows;
using Autodesk.AutoCAD.Runtime;
using Newtonsoft.Json;
using RuntimeApplication2;

[assembly: ExtensionApplication(typeof(SampleApplication2))]
namespace RuntimeApplication2
{
  public class SampleApplication2 : IExtensionApplication
  {
    public void Initialize()
    {
      try
      {
        var json = "{\"menu\":{\"id\":\"file\",\"value\":\"File\",\"popup\":{\"menuitem\":[{\"value\":\"New\",\"onclick\":\"CreateNewDoc()\"},{\"value\":\"Open\",\"onclick\":\"OpenDoc()\"},{\"value\":\"Close\",\"onclick\":\"CloseDoc()\"}]}}}";
        MessageBox.Show($"RuntimeApplication2: {JsonConvert.DeserializeObject(json)}");
      }
      catch (Exception ex)
      {
        MessageBox.Show($"RuntimeApplication2: {ex.Message}");
      }
    }

    public void Terminate()
    {

    }
  }
}
