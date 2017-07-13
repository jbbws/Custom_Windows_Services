using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class ServiceProvider
    {
        public BindingList<Services> ServiceList;

        public void GetServices()
        {   
            ServiceList = new BindingList<Services>();
            var _localService = ServiceController.GetServices().ToArray();
            foreach (ServiceController ser in _localService)
            {
                ServiceList.Add(new Services(ser));
            }
        }
    }
}
