# Blazor Sample Browser

## Adding a new sample

1.  Create a folder with your Repository name inside the Pages folder.
 e.g. for button components Pages => Buttons
2. Create a folder in control name inside the Repository name folder.
e.g. Pages => Buttons => Button

3. Add your samples inside the control name folder. e.g. Pages => Buttons => Button => Default.cshtml

4. Add SampleList.cs file inside the Repository folder name.
e.g Buttons => SampleList.cs

## Declaring Samples in SampleList.cs file

5. Configure your SampleList.cs file as like below code snippet and refer this [link](https://gitlab.syncfusion.com/essential-studio/ej2-blazor-samples/blob/development/ej2-blazor-samples/Pages/Buttons/SampleList.cs).

```
namespace BlazorDemos
{
    internal partial class SampleConfig
    {
        public List<Sample> Button { get; set; } = new List<Sample>{
            new Sample
            {
                Name = "Default Functionalites",
                Category = "Button",
                Directory = "Buttons/Button",
                Url = "Button/DefaultFunctionalities",
                FileName = "DefaultFunctionalities.cshtml",
                Type = SampleType.New
            }
        };
        public List<Sample> Radio { get; set; } = new List<Sample>{
            new Sample
            {
                Name = "Default Functionalites",
                Category = "Default",
                Directory = "Buttons/Radio",
                Url = "Radio/DefaultFunctionalities",
                FileName = "DefaultFunctionalities.cshtml",
                Type = SampleType.New
            }
        };
}
```

6. And then group Samples in following SampleList.cs file and refer this [link](https://gitlab.syncfusion.com/essential-studio/ej2-blazor-samples/blob/development/ej2-blazor-samples/Pages/SampleList.cs)

e.g Pages=> SampleList.cs

```
        internal SampleConfig()
        {
            SampleBrowser.SampleList.Add(new SampleList
            {
                Name = "Button",
                Category = "Editors",
                Directory = "Buttons",
                Type = SampleType.New,
                UID = 002,
                Order = 01,
                Samples = Button
            });
'''

7. Add Your sample route path in your cshtml page e.g 

```
@page "/Button/DefaultFunctionalities"

```

8. Also, you need to specify the following details in your sample cshtml page

```
@*Hidden:Lines*@
@using BlazorDemos
@{
    SampleBrowser.CurrentSampleName = "Default Functionalities";
    SampleBrowser.CurrentControlName = "Button";
    SampleBrowser.CurrentControlCategory = "Default";
    SampleBrowser.CurrentControl = SampleBrowser.Config.Button;
}
@*End:Hidden*@

```
