using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Week5Assignment
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
        }

        void Log_Error(Exception e)
        {
            string trace = e.StackTrace.ToString();
            string message = e.Message;
            string newMessage = message.Replace("'", "");
            newMessage.ToString();

            System.Data.SqlClient.SqlConnection sqlConnection1 = new SqlConnection("Server=localhost\\SQLEXPRESS; Trusted_Connection=True; Initial Catalog=Week5Assignment;");
            SqlCommand cmd = new System.Data.SqlClient.SqlCommand
            {
                CommandType = System.Data.CommandType.Text,
                CommandText = @"Insert into ErrorLog(ErrorDateTime, ErrorMessage, StackTrace) " + "Values(GETDATE(), '" + newMessage + "', '" + trace + "')",
                Connection = sqlConnection1
            };
            sqlConnection1.Open();
            cmd.ExecuteNonQuery();
            sqlConnection1.Close();
        }

        [HandleError]
        void Application_Error(object sender, EventArgs e)
        {
            Exception exc = Server.GetLastError();
            Response.Redirect("~/Error/NotFound");
            Log_Error(exc);
            Server.ClearError();
        }

        [HandleError]
        void Custom_Error(object sender, EventArgs e)
        {
            Exception exc = Server.GetLastError();
            Response.Redirect("~/Shared/Error");
            Log_Error(exc);
            Server.ClearError();
        }
    }
}
