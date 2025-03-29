using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.IO;


namespace Proba.Properties
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
                ListName = " ",
                itemsList = new ObservableCollection<Item>()
                {
                    new Item { ItemName = " " }
                }
            };
            mainList = new ObservableCollection<ItemsList>();
            mainList.Add(itemsList);
            string temp = File.ReadAllText("purchase_list.txt");
            List<string> strs = temp.Split('#').Where(t => t.Trim().Any()).ToList();
            var first = strs[0].Trim().Split('\n');
            for (int i = 0; i < strs.Count; i++)
            {
                var currentItems = strs[i].Trim().Split('\n');
                ObservableCollection<Item> items = new ObservableCollection<Item>();
                for (int j = 1; j < currentItems.Length; j++)
                {
                    items.Add(new Item { ItemName = currentItems[j] });
                }
                ItemsList currentItemsList = new ItemsList() { ListName = currentItems[0], itemsList = items };
                mainList.Add(currentItemsList);
            }
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
                         ItemsList itemsList = new ItemsList() { ListName = " ", itemsList = new ObservableCollection<Item>() { new Item { ItemName = " " } } }; ;
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
