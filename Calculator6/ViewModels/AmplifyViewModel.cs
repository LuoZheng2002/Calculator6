using Calculator6.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Calculator6.ViewModels
{
    internal class AmplifyViewModel:ViewModelBase
    {
        private Model _model;
        public int Number1
        {
            get { return _model.AmplifyModel.Number1; }
            set { _model.AmplifyModel.Number1 = value; }
        }
        public int Number2
        {
            get { return _model.AmplifyModel.Number2; }
            set { _model.AmplifyModel.Number2 = value; }
        }
        public Command ToggleCommand { get; }
        public Command Number1ChangedCommand { get; }
        public Command Number2ChangedCommand { get; }
        public void OnNumber1Changed()
        {
            OnPropertyChanged(nameof(Number1));
        }
        public void OnNumber2Changed()
        {
            OnPropertyChanged(nameof(Number2));
        }
        public AmplifyViewModel(Model model)
        {
            _model = model;
            ToggleCommand = new Command();
            Number1ChangedCommand = new Command(_model.AmplifyModel.CalculateNumber2);
            Number2ChangedCommand = new Command(_model.AmplifyModel.CalculateNumber1);
            // ViewModel subscribes to Model
            _model.AmplifyModel.Number1Changed += OnNumber1Changed;
            _model.AmplifyModel.Number2Changed += OnNumber2Changed;
        }
    }
}
