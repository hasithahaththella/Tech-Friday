using System.ServiceModel;

namespace WcfServiceLibraryNet3_0
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IMyService
    {
        [OperationContract]
        int SumOfNums(int first, int second);
    }
}
