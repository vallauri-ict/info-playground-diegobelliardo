using _07_WebApi.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using System.Collections;
using System.Collections.Generic;
using System.Data;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace _07_WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RecipesController : ControllerBase
    {
        string connStr = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\fenic\\Desktop\\info-playground-diegobelliardo\\2024-5binf\\07-WebApi\\07-WebApi\\App_Data\\Recipes.mdf;Integrated Security=True;Connect Timeout=30";
        // GET: api/<RecipesController>
        [HttpGet]
        public IEnumerable<RecipItem> Get()
        {
            //SqlDataReader reader = null;
            //SqlConnection myConnection = new SqlConnection();
            //myConnection.ConnectionString = connStr;

            //SqlCommand sqlCmd = new SqlCommand();
            //sqlCmd.CommandType = CommandType.Text;
            //sqlCmd.CommandText = "Select * from Recipes";
            //sqlCmd.Connection = myConnection;

            //myConnection.Open();
            //reader = sqlCmd.ExecuteReader();
            //List<RecipItem> list = new List<RecipItem>();
            //RecipItem reciptItem;
            //while (reader.Read())
            //{
            //    reciptItem = new RecipItem();
            //    reciptItem.Id = Convert.ToInt32(reader.GetValue(0));
            //    reciptItem.Name = reader.GetValue(1).ToString();
            //    reciptItem.Description = reader.GetValue(2).ToString();
            //    reciptItem.ImagePath = reader.GetValue(3).ToString();
            //    list.Add(reciptItem);
            //}

            //myConnection.Close();

            List<RecipItem> list = new List<RecipItem>();
            using (SqlConnection myConnection = new SqlConnection(connStr))
            {
                myConnection.Open();
                using (SqlCommand sqlCmd = new SqlCommand("SELECT * FROM Recipes", myConnection))
                using (SqlDataReader reader = sqlCmd.ExecuteReader())
                {
                    RecipItem reciptItem;
                    
                    while (reader.Read())
                    {
                        reciptItem = new RecipItem();
                        reciptItem.Id = Convert.ToInt32(reader.GetValue(0));
                        reciptItem.Name = reader.GetValue(1).ToString();
                        reciptItem.Description = reader.GetValue(2).ToString();
                        reciptItem.ImagePath = reader.GetValue(3).ToString();
                        list.Add(reciptItem);
                    }
                }
            }

            return list;
        }

        // GET api/<RecipesController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<RecipesController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<RecipesController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<RecipesController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
