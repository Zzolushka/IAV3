using Syncfusion.SfDataGrid.XForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinApplicationV3
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainTablePage : ContentPage
    {
        public MainTablePage()
        {
            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("NzEzOTBAMzEzNjJlMzQyZTMwb2ZIQXUwcXpPY2NTRDFCaFc1aCtjdHpWcGhDcExjNlVwbnFxY2xMWWFiUT0=");
            InitializeComponent();
            dataGrid.GridStyle.AlternatingRowColor = Color.Fuschia;
            dataGrid.GridStyle = new CustomDataGridStyle();
        }

         
            private void DataGrid_ColumnResizing(object sender, GridResizingEventArgs e)
        {
            //Code to end resizing if ColumnIndex is 2
            if (e.Index == 2)
                e.Cancel = true;
            if (e.Index == 1)
                e.Cancel = true;
        }
    }

    public class CustomDataGridStyle : DataGridStyle
    {
        public CustomDataGridStyle()
        {

        }

        public override Color GetAlternatingRowBackgroundColor()
        {
            return Color.LightYellow;
        }
    }
}