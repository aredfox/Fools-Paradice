namespace Client.WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow
    {
        public MainWindow() {
            this.DataContext = new MainWindowViewModel();
            InitializeComponent();
        }

        private void HandleSlider() {
            int[] values = new int[] {
                (int)slider1.Value, (int)slider2.Value, (int)slider3.Value,
                (int)slider4.Value, (int)slider5.Value
            };
            (this.DataContext as MainWindowViewModel).SliderChange(values);
        }

        private void slider1_ValueChanged(object sender, System.Windows.RoutedPropertyChangedEventArgs<double> e) {
            HandleSlider();
        }

        private void slider2_ValueChanged(object sender, System.Windows.RoutedPropertyChangedEventArgs<double> e) {
            HandleSlider();
        }

        private void slider3_ValueChanged(object sender, System.Windows.RoutedPropertyChangedEventArgs<double> e) {
            HandleSlider();
        }

        private void slider4_ValueChanged(object sender, System.Windows.RoutedPropertyChangedEventArgs<double> e) {
            HandleSlider();
        }

        private void slider5_ValueChanged(object sender, System.Windows.RoutedPropertyChangedEventArgs<double> e) {
            HandleSlider();
        }
    }
}
