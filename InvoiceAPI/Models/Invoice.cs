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
        // Datum vytvoøení
        public DateTime DatumVytvoreni { get; set; }
        // Datum poslední úpravy
        public DateTime DatumPosledniVyzvy { get; set; }
        // Èástka
        public Double Castka { get; set; }
        // Jméno dodavatele
        public string JmenoDodavatele { get; set; }
        // IÈO dodavatele
        public string IcoDodavatele { get; set; }
        // Jméno odbìratele
        public string JmenoOdberatele { get; set; }
        // IÈO odbìratele
        public string IcoOdberatele { get; set; }
        // Datum vystavení
        public DateTime DatumVystaveni { get; set; }
        // Datum splatnosti
        public DateTime DatumSplatnosti { get; set; }
        // Datum uskuteènìní plnìní
        public DateTime DatumUskutecneniPlneni { get; set; }
        // Forma úhrady(enum) – hodnoty: Pøíkazem/Kartou/Hotovì
        public string FormaUhrady { get; set; }


    }
}