using KirtasiyeDunayasi.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KirtasiyeDunayasi.Controllers
{

    public class PaymentViewModel
    {
        public string CreditCardNumber { get; set; }
        public DateTime ExpiryDate { get; set; }
    }
    public class SiparisController : Controller
    {
        

        KirtasiyeParkEntities1 db = new KirtasiyeParkEntities1();

       



        
    }
}