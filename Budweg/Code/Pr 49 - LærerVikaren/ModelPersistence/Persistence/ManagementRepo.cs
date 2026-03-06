using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Configuration.Json;
using ModelPersistence.Interfaces;
using ModelPersistence.Models;
using PetParadise;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;



namespace ModelPersistence.Persistence
{
    public class ManagementRepo : DatabaseConnector, IRepository<Management>
    {
        private List<Management> managers;

        public ManagementRepo()
        {
            managers = new List<Management>();
        }

        public void Add(Management manager)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                using (SqlCommand sqlcmd = new SqlCommand("INSERT INTO Management_Gunbritt (Name, Email, Phone" +
                    "VALUES (@Name, @Email, @Phone)" +
                    "SELECT @@IDENTITY", con))
                {
                    sqlcmd.Parameters.AddWithValue("@Name", SqlDbType.NVarChar).Value = manager.Name;
                    sqlcmd.Parameters.AddWithValue("@Email", SqlDbType.NVarChar).Value = manager.Email;
                    sqlcmd.Parameters.AddWithValue("@Phone", SqlDbType.NVarChar).Value = manager.Phone;

                    manager.Id = Convert.ToInt32(sqlcmd.ExecuteScalar());
                }
            }
            managers.Add(manager);
        }

        public List<Management> GetAll()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                SqlCommand sqlcmd = new SqlCommand("SELECT * FROM Management_Gunbritt");

                using (SqlDataReader reader = sqlcmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Management manger = new Management()
                        {
                            Name = reader.IsDBNull("Name") ? null : reader["Name"].ToString()
                        };
                    }
                }
            }
            return managers;
        }

        public Management GetById()
        {
            throw new NotImplementedException();
        }

        public void Remove(Management manager)
        {
            throw new NotImplementedException();
        }

        public void Update(Management manager)
        {
            throw new NotImplementedException();
        }
    }
}
