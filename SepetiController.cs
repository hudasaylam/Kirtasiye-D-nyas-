using KirtasiyeDunayasi.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KirtasiyeDunayasi.Controllers
{
    public class SepetiController : Controller
    {
        private string connectionString = "metadata=res://*/Models.Model1.csdl|res://*/Models.Model1.ssdl|res://*/Models.Model1.msl;provider=System.Data.SqlClient;provider connection string=\"data source=HUDASAYLAM;initial catalog=KirtasiyePark;integrated security=True;multipleactiveresultsets=True;trustservercertificate=True;application name=EntityFramework\"\r\n";
        // GET: Sepeti
        [HttpGet]
        public ActionResult Sepeti()
        {

            return View();

        }


        [HttpPost]
        public ActionResult Sepeti(int siparisId, int urunId, int Miktar, int faturano, float fiyat)
        {

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query1 = "SELECT * FROM Siparis WHERE SiparisID = @siparisId AND UrunID = @urunId";

                string query = "SELECT * FROM SiparisUrun WHERE SiparisID = @siparisId AND UrunID = @urunId";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@siparisId", siparisId);
                command.Parameters.AddWithValue("@urunId", urunId);

                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();


                    if (reader.HasRows)
                    {
                        // Item already exists in the cart, update quantity or take further action
                        reader.Close();

                        string updateQuery = "UPDATE SiparisUrun SET Miktar = Miktar + @Miktar WHERE SiparisID = @siparisId AND UrunId = @urunId";
                        SqlCommand updateCommand = new SqlCommand(updateQuery, connection);
                        updateCommand.Parameters.AddWithValue("@siparisId", siparisId);
                        updateCommand.Parameters.AddWithValue("@urunId", urunId);
                        updateCommand.Parameters.AddWithValue("@Miktar", Miktar);
                        updateCommand.ExecuteNonQuery();

                        ViewBag.Message = "urun sepeteye eklendi";
                    }
                    else
                    {
                        // Item doesn't exist in the cart, add it as a new entry
                        reader.Close();

                        string insertQuery = "INSERT INTO Cart (SiparisId, UrunId, Quantity) VALUES (@siparisId, @urunId, @quantity)";
                        SqlCommand insertCommand = new SqlCommand(insertQuery, connection);
                        insertCommand.Parameters.AddWithValue("@siparisId", siparisId);
                        insertCommand.Parameters.AddWithValue("@urunId", urunId);
                        insertCommand.Parameters.AddWithValue("@Miktar", Miktar);
                        insertCommand.ExecuteNonQuery();

                        ViewBag.Message = "Item added to your cart.";
                    }
                }
                catch (Exception ex)
                {
                    ViewBag.Message = "Error: " + ex.Message;
                }
            }

            return View();
        }



    



    }
}