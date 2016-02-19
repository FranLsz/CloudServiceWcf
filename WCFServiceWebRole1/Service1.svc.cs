using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WCFServiceWebRole1
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "ServicioSaludo" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select ServicioSaludo.svc or ServicioSaludo.svc.cs at the Solution Explorer and start debugging.
    public class ServicioSaludo : IServicioSaludo
    {
        Dictionary<String, String> datos = new Dictionary<string, string>
                                {
                                                {   "ingles",   "Hello" },
                                                {"español","hola"},
                                                {"frances","Bon	jour"}
                                };
        public string GetSaludo(string idioma)
        {
            if (datos.ContainsKey(idioma))
                return datos[idioma];

            throw new FaultException("Idioma	" + idioma + "	no	disponible");
        }
    }
}
