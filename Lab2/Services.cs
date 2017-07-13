using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceProcess;
namespace Lab2
{
    class Services
    {
        private ServiceController _service;
        public String Name { get; set; }
        public String DispalyName { get; set; }
        public String Status { get
            {
                if (_service != null)
                    return _service.Status.ToString();
                else return "не найдено";
            }
        }
        public Services(ServiceController s)
        {
            this.Name = s.ServiceName;
            this.DispalyName = s.DisplayName;
            _service = s;
        }   
        public void StopService()
        {
            if (_service.Status != ServiceControllerStatus.Stopped)
                _service.Stop();
            _service.WaitForStatus(ServiceControllerStatus.Stopped, new TimeSpan(0, 0, 30));
        }
        public void StartService()
        {
            if (_service.Status != ServiceControllerStatus.Running)
                _service.Start();
            _service.WaitForStatus(ServiceControllerStatus.Running, new TimeSpan(0, 0, 30));
        }  
        public void Refresh()
        {
            if(_service !=null)
                _service.Refresh();
        }
    }
}
