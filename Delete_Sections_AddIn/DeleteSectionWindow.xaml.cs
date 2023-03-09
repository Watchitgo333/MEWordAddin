using Microsoft.Office.Interop.Word;
using System.Diagnostics;
using System.Windows;
using Application = Microsoft.Office.Interop.Word.Application;
using WindowsWindow = System.Windows.Window;

namespace Delete_Sections_AddIn
{

    public partial class DeleteSectionWindow : WindowsWindow
    {
        Document doc = Globals.ThisAddIn.Application.ActiveDocument;
        Application app = Globals.ThisAddIn.Application;

        public DeleteSectionWindow()
        {
            InitializeComponent();
        }

        private void Select_All_Click(object sender, RoutedEventArgs e)
        {
            Selection selection = app.Selection;
            selection.Find.Execute("Howdy", Forward: true, Wrap: WdFindWrap.wdFindContinue);
            Trace.WriteLine(selection.Paragraphs[1].Range.Text);
            Trace.WriteLine(doc.Name);

        }
    }
}
