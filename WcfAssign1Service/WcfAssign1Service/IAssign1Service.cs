using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfAssign1Service
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IAssign1Service
    {

        [OperationContract]
        string IsPrimeNumber(int number);

        [OperationContract]
        int SumOfDigits(string number);

        [OperationContract]
        string ReverseString(string text);

        [OperationContract]
        string PrintHTMLTags(string tag, string data);

        [OperationContract]
        string Sort5Numbers(Boolean sortAscending, string data);

    }

}
