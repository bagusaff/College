using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using Newtonsoft.Json.Linq;

namespace News
{
    public partial class Form2 : Form
    {
        WebClient wc = null;
        public static int idBerita;
        public Form2()
        {
            InitializeComponent();
            wc = new WebClient();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            idBerita = Form1.currentIdBerita;
            try {
            var data = wc.DownloadString("https://jsonplaceholder.typicode.com/posts/" + idBerita);
            JObject obj = JObject.Parse(data);
                String id = "";
                id += obj["id"];
                lblID.Text = id;
                String title = "";
                title += obj["title"];
                lblTitle.Text = title;
                String detail = "";
                detail += obj["body"];
                lblDetail.Text = detail;              
            }
            catch (Exception ex) {

            }

        }
    }
}
