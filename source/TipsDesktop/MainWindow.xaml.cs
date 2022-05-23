using System.Windows;

namespace TipsDesktop {

  /// <summary>
  /// Interaction logic for MainWindow.xaml
  /// </summary>
  public partial class MainWindow : Window {

    public MainWindow() {
      InitializeComponent();
      var repo = new DataLib.DataRepository();
      CustomerGrid.DataContext = repo.Customers;

      MusicGrid.DataContext = repo.Songs;

      ProductGrid.DataContext = repo.Products;
    }
  }
}