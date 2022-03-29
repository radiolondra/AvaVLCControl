using Avalonia;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;

namespace AvaVLCControl.Views
{
    public partial class Controls : UserControl
    {
        public Controls()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }

        private void StartPlay(object? sender, RoutedEventArgs e)
        {
            var tmp = PlayerControl.GetInstance();
            tmp.viewModel.Play();
        }

        private void StopPlay(object? sender, RoutedEventArgs e)
        {
            var tmp = PlayerControl.GetInstance();
            tmp.viewModel.Stop();
        }
    }
}
