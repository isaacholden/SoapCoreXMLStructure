using SoapCore_Test.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Threading.Tasks;

namespace SoapCore_Test.Services
{
    [ServiceContract]
    public interface IProcessPerson
    {
        [OperationContract]
        void Process(CalculatorRequest calculatorRequest);
    }
}
