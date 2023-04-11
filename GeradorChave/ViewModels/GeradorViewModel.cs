using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Collections.ObjectModel;

namespace GeradorChave.ViewModels
{
    public partial class GeradorViewModel : ObservableObject
    {
        public GeradorViewModel() 
        {
            Items = new ObservableCollection<string>();
        }
                
        [ObservableProperty]
        ObservableCollection<string> items;


        [ObservableProperty]
        DateTime firstData = DateTime.Now;
        [ObservableProperty]
        DateTime secondData = DateTime.Now;
        [ObservableProperty]
        string numero;
        [ObservableProperty]
        string cnpj;


        

        [RelayCommand]
        void Add()
        {
            string firstDataString = FirstData.ToString("dd/MM/yyyy");
            string secondDataString = SecondData.ToString("dd/MM/yyyy");
            Items?.Clear();
            Items.Add(firstDataString); Items.Add(secondDataString); Items.Add(Numero); Items.Add(Cnpj);
            Numero = string.Empty;
            Cnpj = string.Empty;
        }
    }
}
