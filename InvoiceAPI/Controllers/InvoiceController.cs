using InvoiceAPI.Data;
using InvoiceAPI.Models;
using InvoiceAPI.Models.Dto;
using Microsoft.AspNetCore.Mvc;

namespace InvoiceAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class InvoiceController : ControllerBase
    {
        //private static readonly string[] Summaries = nuil;

        //private readonly ILogger<InvoiceController> _logger;

        //public InvoiceController(ILogger<InvoiceController> logger)
        //{
        //    _logger = logger;
        //}
        private readonly ApplicationDbContext _db;
        public InvoiceController(ApplicationDbContext db) { _db = db; }


        [HttpGet]
        public ActionResult<IEnumerable<InvoiceDto>> GetInvoices()
        {
            return Ok(_db.Invoices.ToList());
        }

        [HttpGet("UUID: Guid")]
        public ActionResult<InvoiceDto> GetInvoice(Guid UUID)
        {
            if (UUID == Guid.Empty)
                return BadRequest();

            Invoice invoice = _db.Invoices.FirstOrDefault(i => i.UUID == UUID);

            if (invoice == null)
                return NotFound();

            return Ok(invoice);
        }

        [HttpPost]
        public ActionResult<InvoiceDto> CreateInvoice([FromBody] InvoiceDto invoiceDto)
        {
            if (invoiceDto == null)
                return BadRequest();
           
                //bylo by lepsi pouzit nejaky mapper 
                Invoice invoice = new()
                {
                    DatumVytvoreni = invoiceDto.DatumPosledniVyzvy,
                    DatumPosledniVyzvy = invoiceDto.DatumPosledniVyzvy,
                    Castka = invoiceDto.Castka,
                    JmenoDodavatele = invoiceDto.JmenoDodavatele,
                    IcoDodavatele = invoiceDto.IcoDodavatele,
                    JmenoOdberatele = invoiceDto.JmenoOdberatele,
                    IcoOdberatele = invoiceDto.IcoOdberatele,
                    DatumVystaveni = invoiceDto.DatumVystaveni,
                    DatumSplatnosti = invoiceDto.DatumSplatnosti,
                    DatumUskutecneniPlneni = invoiceDto.DatumUskutecneniPlneni,
                    FormaUhrady = invoiceDto.FormaUhrady,
                };
            try
            {
                _db.Invoices.Add(invoice);
                _db.SaveChanges();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
            return Ok();
        }

        [HttpPut("Invoice: Invoice")]
        public IActionResult UpdateInvoice(Guid UUID, [FromBody]InvoiceDto invoiceDto)
        {
            if (invoiceDto == null || UUID == Guid.Empty)
                return BadRequest();

            //bylo by lepsi pouzit nejaky mapper 
            Invoice invoice = new()
            {
                DatumVytvoreni = invoiceDto.DatumPosledniVyzvy,
                DatumPosledniVyzvy = invoiceDto.DatumPosledniVyzvy,
                Castka = invoiceDto.Castka,
                JmenoDodavatele = invoiceDto.JmenoDodavatele,
                IcoDodavatele = invoiceDto.IcoDodavatele,
                JmenoOdberatele = invoiceDto.JmenoOdberatele,
                IcoOdberatele = invoiceDto.IcoOdberatele,
                DatumVystaveni = invoiceDto.DatumVystaveni,
                DatumSplatnosti = invoiceDto.DatumSplatnosti,
                DatumUskutecneniPlneni = invoiceDto.DatumUskutecneniPlneni,
                FormaUhrady = invoiceDto.FormaUhrady,
            };

            try
            {
                _db.Invoices.Update(invoice);
                _db.SaveChanges();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
    
            return Ok();
        }

        [HttpDelete("UUID: Guid")]
        public IActionResult DeleteInvoice(Guid UUID)
        {

            if (UUID == Guid.Empty)
                return BadRequest();

            Invoice invoice = _db.Invoices.FirstOrDefault(i => i.UUID == UUID);

            if (invoice == null)
                return NotFound();

            try
            {
                _db.Invoices.Remove(invoice);
                _db.SaveChanges();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

            return Ok();
        }
    }
}