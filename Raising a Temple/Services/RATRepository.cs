using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using Dapper;
using Raising_a_Temple.Models;

namespace MyHumidor.Services
{
    public class RATRepository
    {
        private static SqlConnection GetConnection()
        {
            return new SqlConnection(ConfigurationManager.ConnectionStrings["RaisingATemple"].ConnectionString);
        }

        public bool Create(RATDto rat)
        {
            using (var db = GetConnection())
            {


                db.Open();
                var add = db.Execute();

                return add == 1;
            }
        }
