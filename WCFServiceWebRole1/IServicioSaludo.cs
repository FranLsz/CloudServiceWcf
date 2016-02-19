using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WCFServiceWebRole1
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IServicioSaludo" in both code and config file together.
    [ServiceContract]
    public interface IServicioSaludo
    {

        [OperationContract]
        string GetSaludo(string idioma);

    }





}
