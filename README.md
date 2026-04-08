# How to Exporting-DataGrid to PDF Made Easy in .NET-MAUI?
This Sample demonstrates how to Exporting DataGrid to PDF Made Easy in Syncfusion [.NET Maui DataGrid](https://help.syncfusion.com/maui/datagrid/overview)(SfDataGrid).

## Xaml
```
 <ContentPage.BindingContext>
     <local:OrderInfoRepository x:Name="viewModel" />
 </ContentPage.BindingContext>
 <ContentPage.Content>
     <StackLayout>
         <Button Text="Export To PDF" WidthRequest="200" HeightRequest="50" 
              Clicked="ExportToPdf_Clicked" />
         <syncfusion:SfDataGrid x:Name="dataGrid"
                            Margin="20"
                            ItemsSource="{Binding OrderInfoCollection}"
                            GridLinesVisibility="Both"
                            HeaderGridLinesVisibility="Both"
                            AutoGenerateColumnsMode="None"
                            SelectionMode="Multiple"
                            ColumnWidthMode="Auto">
             <syncfusion:SfDataGrid.DefaultStyle>
                 <syncfusion:DataGridStyle RowBackground="LightBlue" HeaderRowBackground="LightGoldenrodYellow"/>
             </syncfusion:SfDataGrid.DefaultStyle>
             <syncfusion:SfDataGrid.Columns>
                 <syncfusion:DataGridNumericColumn Format="D"
                                               HeaderText="Order ID"
                                               MappingName="OrderID">
                 </syncfusion:DataGridNumericColumn>
                 <syncfusion:DataGridTextColumn HeaderText="Customer ID"
                                            MappingName="CustomerID">
                 </syncfusion:DataGridTextColumn>
                 <syncfusion:DataGridTextColumn MappingName="Customer"
                                            HeaderText="Customer">
                 </syncfusion:DataGridTextColumn>
                 <syncfusion:DataGridTextColumn HeaderText="Ship City"
                                            MappingName="ShipCity">
                 </syncfusion:DataGridTextColumn>
                 <syncfusion:DataGridTextColumn HeaderText="Ship Country"
                                            MappingName="ShipCountry">
                 </syncfusion:DataGridTextColumn>
             </syncfusion:SfDataGrid.Columns>
         </syncfusion:SfDataGrid>
     </StackLayout>
 </ContentPage.Content>
```

## Xaml.cs
```
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
```

You can download this example on [GitHub](https://github.com/SyncfusionExamples/Exporting-DataGrid-to-PDF-Made-Easy-in-.NET-MAUI).

Take a moment to explore this [documentation](https://help.syncfusion.com/maui/datagrid/overview), where you can find more information about Syncfusion .NET MAUI DataGrid (SfDataGrid) with code examples. Please refer to this [link](https://www.syncfusion.com/maui-controls/maui-datagrid) to learn about the essential features of Syncfusion .NET MAUI DataGrid (SfDataGrid).

### Conclusion
I hope you enjoyed learning about How to bind a dynamic data object in SfDataGrid.

You can refer to our [.NET MAUI DataGrid’s feature tour](https://www.syncfusion.com/maui-controls/maui-datagrid) page to learn about its other groundbreaking feature representations. You can also explore our [.NET MAUI DataGrid Documentation](https://help.syncfusion.com/maui/datagrid/getting-started) to understand how to present and manipulate data. For current customers, you can check out our .NET MAUI components on the [License and Downloads](https://www.syncfusion.com/sales/teamlicense) page. If you are new to Syncfusion, you can try our 30-day [free trial](https://www.syncfusion.com/downloads/maui) to explore our .NET MAUI DataGrid and other .NET MAUI components.

If you have any queries or require clarifications, please let us know in the comments below. You can also contact us through our [support forums](https://www.syncfusion.com/forums),[Direct-Trac](https://support.syncfusion.com/create) or [feedback portal](https://www.syncfusion.com/feedback/maui?control=sfdatagrid), or the feedback portal. We are always happy to assist you!
