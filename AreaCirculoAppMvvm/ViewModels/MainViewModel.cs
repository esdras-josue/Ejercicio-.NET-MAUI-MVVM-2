using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace AreaCirculoAppMvvm.ViewModels
{
    public partial class MainViewModel : ObservableObject
    {
        public const double PI = 3.1415926535897931;

        [ObservableProperty]
        private double radio;

        [ObservableProperty]
        private double value;

        [RelayCommand]
        private void CalcularArea()
        {
            Value = PI * Math.Pow(Radio, 2);
        }

        [RelayCommand]
        private void LimpiarCampos()
        {
            Radio = 0; Value = 0;
        }
    }
}
