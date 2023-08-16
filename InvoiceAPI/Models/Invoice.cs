using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Runtime.Intrinsics.X86;
using InvoiceAPI.Enums;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.Extensions.Options;

namespace InvoiceAPI.Models
{
    public class Invoice
    {
        // UUID
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid UUID { get; set; }
        // Datum vytvo�en�
        public DateTime DatumVytvoreni { get; set; }
        // Datum posledn� �pravy
        public DateTime DatumPosledniVyzvy { get; set; }
        // ��stka
        public Double Castka { get; set; }
        // Jm�no dodavatele
        public string JmenoDodavatele { get; set; }
        // I�O dodavatele
        public string IcoDodavatele { get; set; }
        // Jm�no odb�ratele
        public string JmenoOdberatele { get; set; }
        // I�O odb�ratele
        public string IcoOdberatele { get; set; }
        // Datum vystaven�
        public DateTime DatumVystaveni { get; set; }
        // Datum splatnosti
        public DateTime DatumSplatnosti { get; set; }
        // Datum uskute�n�n� pln�n�
        public DateTime DatumUskutecneniPlneni { get; set; }
        // Forma �hrady(enum) � hodnoty: P��kazem/Kartou/Hotov�
        public string FormaUhrady { get; set; }


    }
}