using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Proyecto.items;
using System.IO;

namespace Proyecto
{
    public partial class Form1 : Form
    {
        public int id = 1;
        public string ref1, ref2;
        Scene sc;
        public Form1(int ID)
        {
            InitializeComponent();
            // Path.cs
            PathData.genPath(ID.ToString());

            try
            {
                sc = new Scene(ID);
                id = ID;
                pictureBox1.Image = Image.FromFile(@"C:\Users\Sebastian\source\repos\Proyecto\items\imgs\" + sc.img + ".png");
                Analyzer a = new Analyzer(sc.opcion1);
                button1.Text = a.opcionText;
                Analyzer b = new Analyzer(sc.opcion2);
                button2.Text = b.opcionText;
                textBox1.Text = sc.Dialog;
                this.ref1 = a.referencia;
                this.ref2 = b.referencia;
                sc = null;
                
            }
            catch (Exception e)
            {

            }
        }

        public Form1(int ID, int final)
        {
            InitializeComponent();
            // Path.cs

            try
            {
                sc = new Scene(ID);
                id = ID;
                pictureBox1.Image = Image.FromFile(@"C:\Users\Sebastian\source\repos\Proyecto\items\imgs\" + sc.img + ".png");
                button1.Text = " ";
                button2.Text = " ";
                textBox1.Text = sc.Dialog;
                sc = null;
                
            }
            catch (Exception e)
            {

            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            try {
                this.Hide();
                Form1 a = new Form1(Int32.Parse(ref1));
                a.Show();
            }
            catch(Exception exception) {
                
                Form1 a = new Form1(id, 0);
                a.Show();
                System.Threading.Thread.Sleep(100);
                PathData.genPath("END("+id+")");

                
                //MessageBox.Show("Terminaste!!!!!!!!!");

                System.Windows.Forms.Application.Exit();
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            try {
                this.Hide();
                Form1 a = new Form1(Int32.Parse(ref2));
                a.Show();
            }
            catch(Exception exception) {
                Form1 a = new Form1(id, 0);
                a.Show();
                System.Threading.Thread.Sleep(100);
                PathData.genPath("END("+id+")");
                
                //MessageBox.Show("Terminaste!!!!!!!!!");

                System.Windows.Forms.Application.Exit();
            }
           
        }
    }
}
