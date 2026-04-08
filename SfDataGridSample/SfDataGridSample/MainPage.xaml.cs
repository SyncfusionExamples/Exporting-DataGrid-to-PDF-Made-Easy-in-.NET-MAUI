using Syncfusion.Maui.DataGrid.Exporting;

namespace SfDataGridSample
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
            var pdfDoc = pdfExport.ExportToPdf(this.dataGrid, option);
            pdfDoc.Save(stream);
            pdfDoc.Close(true);
            SaveService saveService = new();
            saveService.SaveAndView("Export Feature.pdf", "application/pdf", stream);
        }
    }
}
