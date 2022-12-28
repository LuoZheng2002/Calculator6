using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator6.Models
{
    internal class Model
    {
        public AddModel AddModel { get; }
        public AmplifyModel AmplifyModel { get; }
        public Model()
        {
            AddModel = new AddModel();
            AmplifyModel = new AmplifyModel();
        }
    }
}
