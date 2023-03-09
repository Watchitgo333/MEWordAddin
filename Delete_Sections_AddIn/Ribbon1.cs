using Microsoft.Office.Interop.Word;
using Microsoft.Office.Tools.Ribbon;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace Delete_Sections_AddIn
{
    public partial class Ribbon1
    {
        private void Ribbon1_Load(object sender, RibbonUIEventArgs e)
        {

        }

        private void button1_Click(object sender, RibbonControlEventArgs e)
        {
            Document doc = Globals.ThisAddIn.Application.ActiveDocument;
            Application app = Globals.ThisAddIn.Application;
            DeleteSectionWindow deleteSectionWindow = new DeleteSectionWindow();
            deleteSectionWindow.ShowDialog();
        }
    }
}