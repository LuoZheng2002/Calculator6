using Calculator6.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator6.ViewModels
{
    internal class MainViewModel:ViewModelBase
    {
        private Model _model;
        private ViewModelBase _currentViewModel;
        public ViewModelBase CurrentViewModel
        {
            get { return _currentViewModel; }
            set { _currentViewModel = value; 
                OnCurrentViewModelChanged();
            }
        }
        public void NavigateToAdd(object obj)
        {
            AddViewModel addViewModel = new AddViewModel(_model);
            addViewModel.ToggleCommand.Called += NavigateToAmplify;
            CurrentViewModel = addViewModel;
        }
        public void NavigateToAmplify(object obj)
        {
            AmplifyViewModel amplifyViewModel = new AmplifyViewModel(_model);
            amplifyViewModel.ToggleCommand.Called += NavigateToAdd;
            CurrentViewModel = amplifyViewModel;
        }
        public MainViewModel(Model model)
        {
            _model = model;
            NavigateToAdd(null);
        }
        public void OnCurrentViewModelChanged()
        {
            OnPropertyChanged(nameof(CurrentViewModel));
        }
    }
}
