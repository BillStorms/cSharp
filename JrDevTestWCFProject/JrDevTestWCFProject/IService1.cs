using System.Collections.Generic;
using System.ServiceModel;


namespace JrDevTestWCFProject
{
    [ServiceContract]
    public interface IService1
    {
        [OperationContract]
        string DisplayProjectName();

        [OperationContract]
        string[] DisplayCurrentDateTime();

        [OperationContract]
        string EchoInput(int input);

    }
}