using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace test_camera_arduino
{
    public partial class Default : System.Web.UI.Page
    {
        SerialPort ardo;
        protected void Page_Load(object sender, EventArgs e)
        {
            ardo = new SerialPort();
            ardo.PortName = "COM6";
            ardo.BaudRate = 9600;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string slow = "1";
            ardo.Open();
            ardo.Write(slow);
            ardo.Close();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            string fast = "2";
            ardo.Open();
            ardo.Write(fast);
            ardo.Close();
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Response.Redirect("Camera.aspx");
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            string fast = "3";
            ardo.Open();
            ardo.Write(fast);
            ardo.Close();
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            string fast = "4";
            ardo.Open();
            ardo.Write(fast);
            ardo.Close();
        }
    }
}