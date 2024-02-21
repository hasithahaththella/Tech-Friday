using System.Web.Services;

namespace AsmxWebService3_5
{
    // Use "Namespace" attribute with an unique name, to make service uniquely discoverable
    [WebService(Namespace = "http://tempuri.org/")]
    // To indicate service confirms to "WsiProfiles.BasicProfile1_1" standard, 
    // if not, it will throw compile time error
    [WebServiceBinding(ConformsTo = WsiProfiles.None)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    [System.Web.Script.Services.ScriptService]
    public class MyService : WebService
    {
        // Takes 2 int values & returns their summation
        [WebMethod]
        public int SumOfNums(int first, int second)
        {
            return first + second;
        }
    }
}