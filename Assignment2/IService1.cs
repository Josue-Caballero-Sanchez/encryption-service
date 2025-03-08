using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace Assignment2
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {
        // Encrypt operation
        [OperationContract]
        [WebGet(UriTemplate = "encrypt?text={enstr}&seed={seed}", ResponseFormat = WebMessageFormat.Json)]
        string Cypherencrypt(string enstr, int seed);

        // Decrypt operation 
        [OperationContract]
        [WebGet(UriTemplate = "decrypt?text={destr}&seed={seed}", ResponseFormat = WebMessageFormat.Json)]
        string Cypherdecrypt(string destr, int seed);
    }
}
