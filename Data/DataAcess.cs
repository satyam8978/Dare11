using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;
using CricketBooking.Models;
using System.Web.Mvc;

namespace CricketBooking.Data
{
    public class DataAcess
    {
        public SqlConnection sConn = new SqlConnection(ConfigurationManager.ConnectionStrings["CricketBookingContext"].ConnectionString);
        public string InsertData(venue objvenue)
        {
            string result = "";
            try
            {
                if (sConn.State == ConnectionState.Open)
                {
                    sConn.Close();
                }
                sConn.Open();
                SqlCommand cmd = new SqlCommand("Sp_VenueIns", sConn);
                cmd.CommandType = CommandType.StoredProcedure;
                //cmd.Parameters.AddWithValue("@CustomerID", 0);    
                cmd.Parameters.AddWithValue("@lid", objvenue.ilId);
                cmd.Parameters.AddWithValue("@vname",objvenue.sname);
                cmd.Parameters.AddWithValue("@createdby",objvenue.iCId);


                cmd.ExecuteNonQuery();
                 result="Sucess";
                return result;
            }
            catch(Exception ex)
            {
                return result = "Failed";
            }
            finally
            {
                sConn.Close();
            }
        }
        public  List<SelectListItem> LocationGet()
        {
           
            List<SelectListItem> items = new List<SelectListItem>();

            try
            {
                if (sConn.State == ConnectionState.Open)
                {
                    sConn.Close();
                }
                sConn.Open();
                SqlCommand cmd = new SqlCommand("sp_locationsget", sConn);
                cmd.CommandType = CommandType.StoredProcedure;

                using (SqlDataReader sdr = cmd.ExecuteReader())
                {
                    while (sdr.Read())
                    {
                        items.Add(new SelectListItem
                        {
                            Text = sdr["name"].ToString(),
                            Value = sdr["id"].ToString()
                        });
                    }
                   
                   
                }
            }
            catch
            {


            }
            finally
            {

                sConn.Close();

            }
            return items;
        }
        public List<venue> VenuesGet()
        {
            List<venue> venuelist = null;
            try
            {
               
                if (sConn.State == ConnectionState.Open)
                {
                    sConn.Close();
                }
                sConn.Open();
                SqlCommand cmd = new SqlCommand("sp_venuesGet", sConn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter();
                DataSet ds = null;
                da.SelectCommand = cmd;
                ds = new DataSet();
                da.Fill(ds);
                venuelist = new List<venue>();
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    venue cobj = new venue();
                    cobj.iId = Convert.ToInt32(ds.Tables[0].Rows[i]["id"].ToString());
                    cobj.sname = ds.Tables[0].Rows[i]["name"].ToString();
                    cobj.slname = ds.Tables[0].Rows[i]["lname"].ToString();

                    venuelist.Add(cobj);
                }
                return venuelist;
            }
            catch (Exception ex)
            {
                return venuelist;
            }
            finally
            {
                sConn.Close();

            }
            

        }

        public venue VenuesGetById(int id)
        {
         
            try
            {

                if (sConn.State == ConnectionState.Open)
                {
                    sConn.Close();
                }
                sConn.Open();
                SqlCommand cmd = new SqlCommand("Sp_VenueGetById", sConn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", id);
                SqlDataAdapter da = new SqlDataAdapter();
                DataSet ds = null;
                da.SelectCommand = cmd;
                ds = new DataSet();
                da.Fill(ds);
                venue cobj = new venue();
                if ( ds.Tables[0].Rows.Count>0)
                {
                   
                    cobj.iId = Convert.ToInt32(ds.Tables[0].Rows[0]["id"].ToString());
                    cobj.sname = ds.Tables[0].Rows[0]["name"].ToString();
                    cobj.slname = ds.Tables[0].Rows[0]["lname"].ToString();

                   
                }
                return cobj;
            }
            catch (Exception ex)
            {
                throw (ex);
            }
            finally
            {
                sConn.Close();

            }


        }
        public string VenuesUpd(venue objvenue)
        {
            string result = "";

            try
            {

                if (sConn.State == ConnectionState.Open)
                {
                    sConn.Close();
                }
                sConn.Open();
                SqlCommand cmd = new SqlCommand("Sp_VenueUpd", sConn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", objvenue.iId);
                cmd.Parameters.AddWithValue("@name", objvenue.sname);
                cmd.ExecuteNonQuery();
                return result = "Success";
            }
            catch (Exception ex)
            {
                return result = "Failed";
            }
            finally
            {
                sConn.Close();

            }


        }

        public string VenuesDel(int id)
        {
            string result = "";

            try
            {

                if (sConn.State == ConnectionState.Open)
                {
                    sConn.Close();
                }
                sConn.Open();
                SqlCommand cmd = new SqlCommand("Sp_VenueDel", sConn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();
                return result = "Success";
            }
            catch (Exception ex)
            {
                return result = "Failed";
            }
            finally
            {
                sConn.Close();

            }


        }

        public List<SelectListItem> venueGetByLid(int lid)
        {

            List<SelectListItem> items = new List<SelectListItem>();

            try
            {
                if (sConn.State == ConnectionState.Open)
                {
                    sConn.Close();
                }
                sConn.Open();
                SqlCommand cmd = new SqlCommand("sp_VenuesgetByLid", sConn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@lid", lid);

                using (SqlDataReader sdr = cmd.ExecuteReader())
                {
                    while (sdr.Read())
                    {
                        items.Add(new SelectListItem
                        {
                            Text = sdr["name"].ToString(),
                            Value = sdr["id"].ToString()
                        });
                    }


                }
            }
            catch
            {


            }
            finally
            {

                sConn.Close();

            }
            return items;
        }
    }
}