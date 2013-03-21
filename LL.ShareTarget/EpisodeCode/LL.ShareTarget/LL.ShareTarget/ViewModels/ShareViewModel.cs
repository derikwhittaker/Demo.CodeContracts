using System;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using GalaSoft.MvvmLight.Command;
using Metro.LL.Common;
using Metro.LL.Common.Extensions;

using Windows.ApplicationModel.DataTransfer.ShareTarget;
using Windows.Storage;
using Windows.Storage.Streams;
using Windows.UI.Xaml.Media.Imaging;

namespace LL.ShareTarget.ViewModels
{
    public class ShareViewModel : BaseViewModel
    {

        private ShareOperation _shareOperation;
        public ShareViewModel()
        {
            PageTitle = "Share Content";
        }

        public async Task ShareAsync(ShareOperation shareOperation)
        {
           
        }
        
        private void SaveContent()
        {
        }

        private string _textShareValue;
        public string TextShareValue
        {
            get { return _textShareValue; }
            set
            {
                _textShareValue = value;
                OnPropertyChanged("TextShareValue");
            }
        }

        private string _urlShareValue;
        public string UrlShareValue
        {
            get { return _urlShareValue; }
            set
            {
                _urlShareValue = value;
                OnPropertyChanged("UrlShareValue");
            }
        }
        
        private BitmapImage _imageShareValue;
        public BitmapImage ImageShareValue
        {
            get { return _imageShareValue; }
            set
            {
                _imageShareValue = value;
                OnPropertyChanged("ImageShareValue");
            }
        }

        private bool _isTextRequest;
        public bool IsTextRequest
        {
            get { return _isTextRequest; }
            set
            {
                _isTextRequest = value;
                OnPropertyChanged("IsTextRequest");
            }
        }

        private bool _isUrlRequest;
        public bool IsUrlRequest
        {
            get { return _isUrlRequest; }
            set
            {
                _isUrlRequest = value;
                OnPropertyChanged("IsUrlRequest");
            }
        }

        private bool _isImageRequest;
        public bool IsImageRequest
        {
            get { return _isImageRequest; }
            set
            {
                _isImageRequest = value;
                OnPropertyChanged("IsImageRequest");
            }
        }

        private bool _isStorageRequest;
        public bool IsStorageRequest
        {
            get { return _isStorageRequest; }
            set
            {
                _isStorageRequest = value;
                OnPropertyChanged("IsStorageRequest");
            }
        }

        public string StorageFileName
        {
            get { return _storageFileName; }
            set
            {
                _storageFileName = value;
                OnPropertyChanged("StorageFileName");
            }
        }

        private string _requestTitle;
        public string RequestTitle
        {
            get { return _requestTitle; }
            set { _requestTitle = value; OnPropertyChanged("RequestTitle"); }
        }

        private string _requestDescription;
        public string RequestDescription
        {
            get { return _requestDescription; }
            set { _requestDescription = value; OnPropertyChanged("RequestDescription"); }
        }

        private RelayCommand _saveShareContentCommand;
        private string _storageFileName;

        public RelayCommand SaveShareContentCommand
        {
            get { return _saveShareContentCommand ?? ( _saveShareContentCommand = new RelayCommand(SaveContent) ); }
        }

    }
}
