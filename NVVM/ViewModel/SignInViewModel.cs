using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SweetAsMusic.Core;
using SweetAsMusic.NVVM.ViewModel;

namespace SweetAsMusic.NVVM.View
{
    class SignInViewModel: ObservableObject
    {
        public RelayCommand LoginViewCommand { get; set; }
        public RelayCommand RegisterViewCommand { get; set; }

        public LoginViewModel LoginVM { get; set; }
        public RegisterViewModel RegisterVM { get; set; }

        private object _currentView;
        public object CurrentView
        { 
            get { return _currentView; } 
            set { _currentView = value;
                OnPropertyChanged();}
        }
        
        public SignInViewModel()
        {
        LoginVM = new LoginViewModel();
            CurrentView = LoginVM;

         RegisterVM = new RegisterViewModel();
            CurrentView = RegisterVM;
        }
    }
}
