﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Data;
using System.Data.SqlClient;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _23MSIT059
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        public static SqlConnection con;
        public static SqlCommand cmd;

        protected void Page_Load(object sender, EventArgs e)
        {
            con = new SqlConnection();
            cmd = new SqlCommand();

            con.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\student\Documents\23MSIT059.mdf;Integrated Security=True;Connect Timeout=30";

            cmd.Connection = con;
            cmd.CommandText = "StudentProcedure";

            cmd.CommandType = System.Data.CommandType.StoredProcedure;
        }

        protected void tbnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                cmd.Parameters.AddWithValue("@sid", txtsid.Text);
                cmd.Parameters.AddWithValue("@sname", txtsname.Text);
                cmd.Parameters.AddWithValue("@sprog", txtprog.Text);
                cmd.Parameters.AddWithValue("@ssem", txtsem.Text);
                cmd.Parameters.AddWithValue("@ss1m", txts1m.Text);
                cmd.Parameters.AddWithValue("@ss2m", txts2m.Text);
                cmd.Parameters.AddWithValue("@ss3m", txts3m.Text);
                cmd.Parameters.AddWithValue("@op", 1);

                con.Open();
                int i = cmd.ExecuteNonQuery();
                con.Close();

                if (i > 0)
                {
                    Response.Write("Record Inserted.");
                }

                else
                {
                    Response.Write("Something Went Wrong.");
                }

                txtsid.Text = "";
                txtsname.Text = "";
                txtprog.Text = "";
                txtsem.Text = "";
                txts1m.Text = "";
                txts2m.Text = "";
                txts3m.Text = "";
            }

            catch (SqlException Sqlex)
            {
                Response.Write(Sqlex.Message);
            }

            catch (Exception Ex)
            {
                Response.Write(Ex.Message);
            }
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                cmd.Parameters.AddWithValue("@sid", txtsid.Text);
                cmd.Parameters.AddWithValue("@sname", txtsname.Text);
                cmd.Parameters.AddWithValue("@sprog", txtprog.Text);
                cmd.Parameters.AddWithValue("@ssem", txtsem.Text);
                cmd.Parameters.AddWithValue("@ss1m", txts1m.Text);
                cmd.Parameters.AddWithValue("@ss2m", txts2m.Text);
                cmd.Parameters.AddWithValue("@ss3m", txts3m.Text);
                cmd.Parameters.AddWithValue("@op", 2);

                con.Open();
                int i = cmd.ExecuteNonQuery();
                con.Close();

                if (i > 0)
                {
                    Response.Write("Record Updated.");
                }

                else
                {
                    Response.Write("Something Went Wrong.");
                }

                txtsid.Text = "";
                txtsname.Text = "";
                txtprog.Text = "";
                txtsem.Text = "";
                txts1m.Text = "";
                txts2m.Text = "";
                txts3m.Text = "";
            }

            catch (SqlException Sqlex)
            {
                Response.Write(Sqlex.Message);
            }

            catch (Exception Ex)
            {
                Response.Write(Ex.Message);
            }
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                cmd.Parameters.AddWithValue("@sid", txtsid.Text);
                cmd.Parameters.AddWithValue("@op", 3);

                con.Open();
                int i = cmd.ExecuteNonQuery();
                con.Close();

                if (i > 0)
                {
                    Response.Write("Record Deleted.");
                }

                else
                {
                    Response.Write("Something Went Wrong.");
                }

                txtsid.Text = "";
            }

            catch (SqlException Sqlex)
            {
                Response.Write(Sqlex.Message);
            }

            catch (Exception Ex)
            {
                Response.Write(Ex.Message);
            }
        }

        protected void btnSelect_Click(object sender, EventArgs e)
        {
            try
            {
                cmd.Parameters.AddWithValue("@op", 4);

                SqlDataReader r;
                con.Open();
                r = cmd.ExecuteReader();

                gridvStudent.DataSource = r;
                gridvStudent.DataBind();
                con.Close();
            }
            catch (SqlException sqlex)
            {
                Response.Write(sqlex.Message);
            }

            catch (Exception Ex)
            {
                Response.Write(Ex.Message);
            }
        }
    }
}