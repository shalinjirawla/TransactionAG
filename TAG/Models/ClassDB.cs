using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace TAG.Models
{
    public class ClassDB
    {
        static string sqllocalConnectionString = ConfigurationManager.ConnectionStrings["AZURE"].ConnectionString;
        public static object update(string query)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(sqllocalConnectionString))
                {
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        conn.Open();
                        cmd.CommandTimeout = 0;
                        int res = cmd.ExecuteNonQuery();
                        return res;
                    }
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static object Insert(string query)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(sqllocalConnectionString))
                {
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        conn.Open();
                        cmd.CommandTimeout = 0;
                        var res = cmd.ExecuteScalar();
                        return res;
                    }
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //Select one record from Database table
        public static string CheckRecord(string query)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(sqllocalConnectionString))
                {
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {

                        conn.Open();
                        SqlDataReader reader = cmd.ExecuteReader();
                        var res = "";
                        while (reader.Read())
                        {
                            res = String.Format("{0}", reader[0]);
                        }

                        return res;
                    }
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        //Select multiple records from Database table
        public static DataTable selectRecords(string query, string[] parameterNames = null, Object[] parameterValues = null, string conName = null)
        {
            try
            {
                using (DataTable dt = new DataTable())
                {
                    if (conName == null)
                    {
                        using (SqlConnection conn = new SqlConnection(sqllocalConnectionString))
                        {
                            using (SqlDataAdapter da = new SqlDataAdapter())
                            {
                                using (SqlCommand cmd = new SqlCommand(query, conn))
                                {
                                    if (parameterNames != null)
                                    {

                                        for (int i = 0; i <= parameterNames.Length - 1; i++)
                                        {
                                            cmd.Parameters.AddWithValue(parameterNames[i], parameterValues[i]);
                                        }
                                        cmd.CommandTimeout = 0;
                                        cmd.CommandType = CommandType.StoredProcedure;


                                    }


                                    da.SelectCommand = cmd;
                                    conn.Open();
                                    cmd.CommandTimeout = 0;
                                    da.SelectCommand.ExecuteNonQuery();
                                    da.Fill(dt);

                                    return dt;
                                }

                            }
                        }
                    }
                    else
                    {
                        using (SqlConnection conn = new SqlConnection(sqllocalConnectionString))
                        {
                            using (SqlDataAdapter da = new SqlDataAdapter())
                            {
                                using (SqlCommand cmd = new SqlCommand(query, conn))
                                {
                                    if (parameterNames != null)
                                    {

                                        for (int i = 0; i <= parameterNames.Length - 1; i++)
                                        {
                                            cmd.Parameters.AddWithValue(parameterNames[i], parameterValues[i]);
                                        }

                                        cmd.CommandType = CommandType.StoredProcedure;


                                    }


                                    da.SelectCommand = cmd;
                                    conn.Open();
                                    cmd.CommandTimeout = 0;
                                    da.SelectCommand.ExecuteNonQuery();
                                    da.Fill(dt);

                                    return dt;
                                }

                            }
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
    }
}