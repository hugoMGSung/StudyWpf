using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace BikeShop
{
    public class TestDBViewModel : Conductor<IScreen>.Collection.OneActive
    {
        private readonly IMessageProvider msgProvider;

    }
}
