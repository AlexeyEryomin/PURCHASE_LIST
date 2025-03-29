using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Proba
{
    internal class ItemsList : INotifyPropertyChanged
    {
        public ObservableCollection<Item> itemsList { get; set; }
        private string listName;
        public string ListName
        {
            get { return listName; }
            set { listName = value; OnPropertyChanged("ListName"); }
        }
        private Item selectedItem;
        public Item SelectedItem
        {
            get { return selectedItem; }
            set
            {
                selectedItem = value;
                OnPropertyChanged(nameof(SelectedItem));
            }
        }
        public RelayCommand removeCommand;
        public RelayCommand RemoveCommand
        {
            get
            {
                return removeCommand ??
                     (removeCommand = new RelayCommand(obj =>
                     {
                         Item item = obj as Item;
                         if (item != null)
                         {
                             itemsList.Remove(item);
                         }
                     },
                     obj => itemsList.Any()));
            }
        }
        public RelayCommand addCommand;
        public RelayCommand AddCommand
        {
            get
            {
                return addCommand ??
                     (addCommand = new RelayCommand(obj =>
                     {
                         Item item = new Item() { ItemName = "" };
                         itemsList.Insert(0, item);
                     }));
            }
        }
        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
            }
        }
    }
}
