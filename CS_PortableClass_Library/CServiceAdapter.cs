using System;

namespace CS_PortableClass_Library
{

    public interface IServiceAdapter
    {
        void GetEmployees(EventHandler<MyRef.GetEmployeesCompletedEventArgs> callback);
    }
    
    public class CServiceAdapter : IServiceAdapter
    {
        MyRef.ServiceClient Proxy;

        
        public CServiceAdapter()
        {
            Proxy = new MyRef.ServiceClient(); 
        }

        public void GetEmployees(EventHandler<MyRef.GetEmployeesCompletedEventArgs> callback)
        {
            Proxy.GetEmployeesCompleted += callback;
            Proxy.GetEmployeesAsync(); 
        }
    }
}
