using System.Windows.Controls;

namespace AgDataGrid_TotalSummary {
    public partial class MainPage : UserControl {
        public MainPage() {
            InitializeComponent();
            grid.DataSource = ProductList.GetData();
        }
    }
}
