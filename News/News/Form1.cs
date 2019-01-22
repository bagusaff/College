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
    public partial class Form1 : Form
    {
        WebClient wc = null;
        public static int currentIdBerita;
        private int label_x_position, label_y_position;
        private int button_x_position;

        bool btnTampilClickedStatus = false;
        public Form1()
        {
            InitializeComponent();
            wc = new WebClient();
        }

        private void btnTampilOnClick(object sender, EventArgs e)
        {
            if (btnTampilClickedStatus == false)
            {
                label_x_position = 19;
                label_y_position = 80;
                button_x_position = 500;
                
                try
                {
                    for (int i = 1; i < 10; i++)
                    {
                        currentIdBerita = i;
                        var data = wc.DownloadString("https://jsonplaceholder.typicode.com/posts/"+i);
                        JObject obj = JObject.Parse(data);
                        Label labelBerita = new Label();
                        String result = "";
                        result += obj["title"];
                        labelBerita.Name = "lblBerita" + i;
                        labelBerita.Text = result;
                        labelBerita.Location = new Point(label_x_position, label_y_position);
                        labelBerita.AutoSize = true;
                        Button buttonBerita = new Button();                 
                        buttonBerita.Name = "btnBerita" + i;
                        buttonBerita.Text = "Detail";
                        buttonBerita.Location = new Point(button_x_position, label_y_position);
                        buttonBerita.Click += delegate 
                        {
                            Form2 form = new Form2();
                            form.Show();
                        };
                        label_y_position += 30;
                        Controls.Add(labelBerita);
                        Controls.Add(buttonBerita);
                        
                    }
                    
                }
                catch (Exception ex) {
                    MessageBox.Show(ex.Message);
                }
            }
          
        }
    }
}
