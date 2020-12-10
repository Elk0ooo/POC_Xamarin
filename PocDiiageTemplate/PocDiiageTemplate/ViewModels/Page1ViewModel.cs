using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PocDiiageTemplate.ViewModels
{
    public class Page1ViewModel : ViewModelBase
    {
        private string _title;
        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }

        private DelegateCommand _navigateCommand { get; set; }
        private readonly INavigationService _NavigationService;

        public DelegateCommand NavigateCommand => _navigateCommand ?? (_navigateCommand = new DelegateCommand(ExecuteNavigateCommand));


        public Page1ViewModel(INavigationService navigationService)
            : base(navigationService)
        {
            Title = "Pageeeeeeeee 1";
            _NavigationService = navigationService;
        }
        private async void ExecuteNavigateCommand()
        {
            
        }

    }
}
