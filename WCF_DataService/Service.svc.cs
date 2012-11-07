using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Activation;
using System.ServiceModel.Web;
using System.Text;

namespace WCF_DataService
{
    [AspNetCompatibilityRequirements(RequirementsMode=AspNetCompatibilityRequirementsMode.Required)]
    public class Service : IService
    {
        CompanyEntities objContext;
        public Service()
        {
            objContext = new CompanyEntities(); 
        }
        public EmployeeInfo[] GetEmployees()
        {
            var Employees = objContext.EmployeeInfoes.ToArray();
            return Employees;
        }
    }
}
