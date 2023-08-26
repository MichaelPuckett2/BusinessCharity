using Charity;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace CharityDesktop.ViewModel
{
    public class ManagerViewModel : INotifyPropertyChanged
    {
        private readonly Manager manager;

        public event PropertyChangedEventHandler? PropertyChanged;
        public void Notify([CallerMemberName] string? property = null) 
            => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(property));

        public ManagerViewModel()
        {
            manager = new Manager();
        }

        public ObservableCollection<Transaction> Credits => manager.Credits;
        public ObservableCollection<Transaction> Debits => manager.Debits;
    }
}
