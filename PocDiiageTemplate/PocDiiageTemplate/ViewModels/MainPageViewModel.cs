using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PocDiiageTemplate.ViewModels
{
    public class MainPageViewModel : ViewModelBase
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
      

        public MainPageViewModel(INavigationService navigationService)
            : base(navigationService)
        {
            Title = "Main Pageeeeeeeee";
            _NavigationService = navigationService;
        }
        private async void ExecuteNavigateCommand()
        {
            await _NavigationService.NavigateAsync("Page1");
        }

    }
}
