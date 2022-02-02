using System.Windows.Forms;
using Autodesk.Navisworks.Api;
using Autodesk.Navisworks.Api.Plugins;

namespace CustomTabSample
{
    // plugin constructor - custom tab attributes
    [Plugin("CustomTabSample", "TwentyTwo", DisplayName = "CustomTabSample")]
    // xaml file - layout of custom ribbon (panel & buttons)
    [RibbonLayout("CustomTabSample.xaml")]
    // ribbon tab ID from xaml file
    [RibbonTab("TwentyTwoTab")]
    // ribbon button ID & icon files
    [Command("Button_One", Icon ="1_16.png", LargeIcon = "1_32.png")]
    [Command("Button_Two", Icon = "2_16.png", LargeIcon = "2_32.png")]
    // split button with (btn-3 & btn-4) 
    [Command("Split_Button_1")]
    [Command("Button_Three", Icon = "3_16.png", LargeIcon = "3_32.png")]
    [Command("Button_Four", Icon = "4_16.png", LargeIcon = "4_32.png")]

    public class MainClass : CommandHandlerPlugin
    {
        public override int ExecuteCommand(string name, params string[] parameters)
        {
            switch (name)
            {
                case "Button_One":
                    MessageBox.Show("There is just one life for each of us: our own.\n-Euripides", 
                        "Sample - Button One");
                    break;
                case "Button_Two":
                    MessageBox.Show("The two most powerful warriors are patience and time.\n-Leo Tolstoy",
                        "Sample - Button Two");
                    break;
                case "Button_Three":
                    MessageBox.Show("In three words I can sum up everything I've learned" +
                        " about life: it goes on.\n-Robert Frost",
                        "Sample - Button Three");
                    break;
                case "Button_Four":
                    MessageBox.Show("Four things for success: work and pray, " +
                        "think and believe.\n-Norman Vincent Peale", "Sample - Button Four");
                    break;
            }
            return 0;
        }
    }
}
