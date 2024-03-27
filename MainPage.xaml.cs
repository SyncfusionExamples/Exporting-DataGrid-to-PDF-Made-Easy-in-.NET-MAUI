using Microsoft.Maui.Controls.PlatformConfiguration;
using Syncfusion.Maui.DataGrid;
using Syncfusion.Maui.DataGrid.Exporting;
using System.Collections.ObjectModel;
namespace MauiApp1
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
      
        private void ExportToPdf_Clicked(object sender, EventArgs e)
        {
            MemoryStream stream = new MemoryStream();
            DataGridPdfExportingController pdfExport = new DataGridPdfExportingController();
            DataGridPdfExportingOption option = new DataGridPdfExportingOption();
            //var list = new List<string>();
            //list.Add("OrderID");
            //list.Add("CustomerID");
            // option.ExcludedColumns = list;
            //option.CanFitAllColumnsInOnePage = true;
            //option.CanExportHeader = false;
            //option.GridLineType = GridLineType.Horizontal;
            //option.CanApplyGridStyle = true;
            var pdfDoc = pdfExport.ExportToPdf(this.dataGrid, option);
            pdfDoc.Save(stream);
            pdfDoc.Close(true);
            SaveService saveService = new();
            saveService.SaveAndView("Export Feature.pdf", "application/pdf", stream);
        }
    }
}
