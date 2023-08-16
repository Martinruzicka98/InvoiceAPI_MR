using System.ComponentModel;

namespace InvoiceAPI.Enums
{
    enum FormaUhradyEnum
    {
        [Description("Příkazem")]
        Prikazem,
        [Description("Kartou")]
        Kartou,
        [Description("Hotově")]
        Hotove
    }
}
