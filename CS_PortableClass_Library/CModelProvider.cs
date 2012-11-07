using CS_PortableClass_Library.MyRef;
using System.ComponentModel;

namespace CS_PortableClass_Library
{
    public class CModelProvider : INotifyPropertyChanged
    {

        public IServiceAdapter Adapter { get; set; }
        public CModelProvider() : this(new CServiceAdapter())
        {

        }
        public CModelProvider(IServiceAdapter adapter)
        {
            if (adapter != null)
            {
                Adapter = adapter;
                EmployeesCommand = new CommandRespository(GetEmployees); 
            }
        }

        EmployeeInfo[] _Employees;

        public EmployeeInfo[] Employees
        {
            get { return _Employees; }
            set
            {
                _Employees = value;
                onPropertyChanged("Employees");
            }
        }

        public void GetEmployees()
        {
            Adapter.GetEmployees((s, args) => Employees = args.Result); 
        }


        public CommandRespository EmployeesCommand { get; private set; }

        public event PropertyChangedEventHandler PropertyChanged;

        void onPropertyChanged(string pName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(pName)); 
            }
        }
    }
}
