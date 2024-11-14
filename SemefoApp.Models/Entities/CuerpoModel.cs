using System;
using System.ComponentModel.DataAnnotations;

namespace SemefoApp.Models.Entities
{
    public class CuerpoModel
    {
        public int ID { get; set; }
        public string Procesamiento { get; set; }
        public int OrdenFiscalia { get; set; }
        public string NumeroCaso { get; set; }
        public string FiscaliaRemitente { get; set; }
        public string MedicoLegista { get; set; }
        public string NumeroCertificado { get; set; }
        public string Dictamen { get; set; }
        public string Identificacion { get; set; }
        public string Disposicion { get; set; }
        public string SenasParticulares { get; set; }
        public DateTime FechaCreacion { get; set; }
        public DateTime FechaModificacion { get; set; }
        public string ModificadoPor { get; set; }
    }


}
