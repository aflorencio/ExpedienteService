using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpedienteService
{
    [BsonIgnoreExtraElements]
    class MExpediente
    {
        [BsonId]
        public ObjectId _id { get; set; }
        [BsonIgnoreIfNull]
        public List<ObjectId> contactoServiceID { get; set; }
        [BsonIgnoreIfNull]
        public List<ObjectId> rastreoServiceID { get; set; }
        [BsonIgnoreIfNull]
        public List<ObjectId> presupuestoServiceID { get; set; }
        [BsonIgnoreIfNull]
        public List<ObjectId> documentoServiceID { get; set; }
        [BsonIgnoreIfNull]
        public List<ObjectId> ticketServiceID { get; set; }
        //Falta gestores y trabajadores que estan encargados del expediente

        // CONTRATO 

        public DateTime fechaCreacion { get; set; }
        public DateTime fechaUpdate { get; set; } //Cada vez que se haga un cambio en el expediente cambiara.
        public int status { get; set; } // 0 descartado (motivo en ticket service deberia estar) 1 Pendiente por contacto 2 Pendiente de Rastreo 3 pendiente de presupuesto 4 pendiente de contrato 5 pendiente gestion 6 pendiente pago 7 otra gestion personalizada
        public string statusInfo { get; set; } // 5/150 Enlaces borrados y separar despues. 

    }
}
