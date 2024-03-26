using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Lab05;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    private int _counter = 0;
    public MainWindow()
    {
        InitializeComponent();
        TargetLenghtUnit.ItemsSource = Enum.GetNames<LenghtUnit>();
        SourceLenghtUnit.ItemsSource = Enum.GetNames<LenghtUnit>();
    }
    private void ButtonBase_OnClick(object sender, RoutedEventArgs e)
    {
        if (decimal.TryParse(Lenght.Text, out var parsed))
        {
            string unita = (string)SourceLenghtUnit.SelectedItem;
            string unitb = (string)TargetLenghtUnit.SelectedItem;
            if (Enum.TryParse<LenghtUnit>(unitb, out var targetUnit) && Enum.TryParse<LenghtUnit>(unita, out var fromUnit))
            {
                Result.Content = $"{parsed * fromUnit.ToDecimal() / targetUnit.ToDecimal()}";
            }
        }
    }
}