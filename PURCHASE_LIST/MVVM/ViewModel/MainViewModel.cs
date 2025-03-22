using PURCHASE_LIST.MVVM.Core;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Shapes;

namespace PURCHASE_LIST.MVVM.ViewModel
{
    internal class MainViewModel : INotifyPropertyChanged
    {
        public ICollectionView ListCollectionView { get; set; }
        private string listFilter = string.Empty;
        public string ListFilter
        {
            get
            {
                return listFilter;
            }
            set
            {
                listFilter = value;
                OnPropertyChanged(nameof(ListFilter));
                ListCollectionView.Refresh();
            }
        }
        private bool FilterList(object obj)
        {
            if (obj is ItemsList itemsList)
            {
                return itemsList.ListName.Contains(ListFilter);
            }
            return false;
        }
        private ItemsList selectedMainList;
        public ObservableCollection<ItemsList> mainList { get; set; }
        public ItemsList SelectedMainList
        {
            get { return selectedMainList; }
            set
            {
                selectedMainList = value;
                OnPropertyChanged(nameof(SelectedMainList));
            }
        }
        public MainViewModel()
        {
            ItemsList itemsList = new ItemsList() 
            { 
                ListName = "Суповой набор!", itemsList = new ObservableCollection<Item>() 
                { 
                    new Item { ItemName = "Креветки!" }, 
                    new Item { ItemName = "Грибочки!" }, 
                    new Item { ItemName = "Помидорки!" }, 
                    new Item { ItemName = "Лучок!" }, 
                    new Item { ItemName = "Морковка!" } 
                }            
            };
            mainList = new ObservableCollection<ItemsList>();
            mainList.Add(itemsList);
            string[] temp = File.ReadAllLines("purchase_list.txt");
            

            ListCollectionView = CollectionViewSource.GetDefaultView(mainList);
            ListCollectionView.Filter = FilterList;
        }
        public RelayCommand removeItemsListCommand;
        public RelayCommand RemoveItemsListCommand
        {
            get
            {
                return removeItemsListCommand ??
                     (removeItemsListCommand = new RelayCommand(obj =>
                     {
                         ItemsList itemsList = obj as ItemsList;
                         if (itemsList != null)
                         {
                             mainList.Remove(itemsList);
                         }
                     },
                     obj => mainList.Any()));
            }
        }
        private RelayCommand addItemsListCommand;
        public RelayCommand AddItemsListCommand
        {
            get
            {
                return addItemsListCommand ??
                     (addItemsListCommand = new RelayCommand(obj =>
                     {
                         ItemsList itemsList = new ItemsList() { ListName = "Укажите название списка здесь!", itemsList = new ObservableCollection<Item>() { new Item { ItemName = "Укажите название покупки здесь!" } } }; ;
                         mainList.Insert(0, itemsList);
                     }));
            }
        }
        private RelayCommand saveChangesCommand;
        public RelayCommand SaveChangesCommand
        {
            get
            {
                return saveChangesCommand ??
                     (saveChangesCommand = new RelayCommand(obj =>
                     {
                         File.WriteAllText("purchase_list.txt", "#\n");
                         for (global::System.Int32 i = 0; i < mainList.Count; i++)
                         {                             
                             File.AppendAllText("purchase_list.txt", $"{mainList.ElementAt(i).ListName}\n");
                             for (global::System.Int32 j = 0; j < mainList.ElementAt(i).itemsList.Count; j++)
                             {
                                 File.AppendAllText("purchase_list.txt", $"{mainList.ElementAt(i).itemsList.ElementAt(j).ItemName}\n");
                             }
                             File.AppendAllText("purchase_list.txt", "#\n");
                         }                         
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
