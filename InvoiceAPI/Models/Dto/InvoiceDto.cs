using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace InvoiceAPI.Models.Dto
{
    public class InvoiceDto
    {
        // UUID
        public Guid UUID { get; set; }
        // Datum vytvoření
        public DateTime DatumVytvoreni { get; set; }
        // Datum poslední úpravy
        public DateTime DatumPosledniVyzvy { get; set; }
        // Částka
        public Double Castka { get; set; }
        // Jméno dodavatele
        public string JmenoDodavatele { get; set; }
        // IČO dodavatele
        public string IcoDodavatele { get; set; }
        // Jméno odběratele
        public string JmenoOdberatele { get; set; }
        // IČO odběratele
        public string IcoOdberatele { get; set; }
        // Datum vystavení
        public DateTime DatumVystaveni { get; set; }
        // Datum splatnosti
        public DateTime DatumSplatnosti { get; set; }
        // Datum uskutečnění plnění
        public DateTime DatumUskutecneniPlneni { get; set; }
        // Forma úhrady(enum) – hodnoty: Příkazem/Kartou/Hotově
        public string FormaUhrady { get; set; }
    }
}
