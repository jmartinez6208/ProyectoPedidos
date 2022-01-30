﻿using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

using Negocio;

namespace ServiciosWCF
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "TiendaWCF" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select TiendaWCF.svc or TiendaWCF.svc.cs at the Solution Explorer and start debugging.
    public class TiendaWCF : ITiendaWCF
    {
        public TiendaEntidades DevolverTiendaPorId(int identificador)
        {
            return TiendaNegocio.DevolverTiendaPorId(identificador);
        }
    }
}
