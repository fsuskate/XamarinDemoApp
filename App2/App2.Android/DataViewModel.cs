using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace App2
{
    public class DataViewModel : INotifyPropertyChanged
    {
        public DataViewModel()
        {
            UserName = "Test";
            Password = "Pass";
        }

        public string UserName { get; set; }
        public string Password { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged([CallerMemberName]string name = "") =>
           PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
    }
}