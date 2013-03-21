using System.Collections.ObjectModel;
using System.Linq;
using LL.SearchContracts.DataModel;
using Metro.LL.Common;

namespace LL.SearchContracts.ViewModels
{
    public class SearchResultsViewModel : BaseViewModel
    {
        private readonly Repository _repository;
        public SearchResultsViewModel() : this(new Repository())
        {
            
        }

        public SearchResultsViewModel( Repository repository )
        {
            _repository = repository;
        }

        
        private SearchItemModel _selectedItem;
        public SearchItemModel SelectedItem
        {
            get { return _selectedItem; }
            set
            {
                _selectedItem = value;

                PageTitle = value.Name;

                OnPropertyChanged("SelectedItem");
            }
        }

        private ObservableCollection<SearchItemModel> _items = new ObservableCollection<SearchItemModel>();
        public ObservableCollection<SearchItemModel> Items
        {
            get { return _items; }
            set
            {
                _items = value;
                OnPropertyChanged("Items");
            }
        }

        public string SearchString { get; set; }
    }
}
