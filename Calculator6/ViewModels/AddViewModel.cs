using Calculator6.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Calculator6.ViewModels
{
    internal class AddViewModel:ViewModelBase
    {
        private Model _model;
        public int Adder1
        {
            get { return _model.AddModel.Adder1; }
            set { _model.AddModel.Adder1 = value; }
        }
        public int Adder2
        {
            get { return _model.AddModel.Adder2; }
            set { _model.AddModel.Adder2 = value; }
        }
        public int Sum
        {
            get { return _model.AddModel.Sum; }
            set { _model.AddModel.Sum = value; }
        }
        public Command AddCommand { get; }
        public Command ToggleCommand { get; }
        public void OnSumChanged()
        {
            OnPropertyChanged(nameof(Sum));
        }
        public AddViewModel(Model model)
        {
            _model = model;
            AddCommand = new Command(_model.AddModel.Add);
            ToggleCommand = new Command();
            _model.AddModel.SumChanged += OnSumChanged;
        }
    }
}
