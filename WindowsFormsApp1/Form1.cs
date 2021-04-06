using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            double tst,t3,tstt,tsh,madtsh;
            string sonuc;
            tst = Convert.ToDouble(TextBox1.Text);
            t3 = Convert.ToDouble(TextBox2.Text);
            tstt = Convert.ToDouble(TextBox3.Text);
            tsh = Convert.ToDouble(TextBox4.Text);
            madtsh = Convert.ToDouble(TextBox5.Text);
            if (tst <= 5.650)
            {
                if (madtsh > 1.8)
                {
                    sonuc = "HYPO";
                    textBox6.Text=Convert.ToString(sonuc);
                    
                }
                else
                {
                    sonuc = "NORMAL";
                    textBox6.Text = Convert.ToString(sonuc);
                }

            }
            else
            {
                if (tst > 14)
                {
                    if (madtsh > 1.050)
                    {
                        sonuc = "NORMAL";
                        textBox6.Text = Convert.ToString(sonuc);
                    }
                    else
                    {
                        sonuc = "HYPER";
                        textBox6.Text = Convert.ToString(sonuc);
                    }

                }
                else
                {
                    if (tstt > 2.950)
                    {
                        sonuc = "HYPER";
                        textBox6.Text = Convert.ToString(sonuc);
                    }
                    else
                    {
                        if (tst <= 6.400)
                        {
                            sonuc = "NORMAL";
                            textBox6.Text = Convert.ToString(sonuc);
                        }
                        else
                        {
                            if (madtsh > -0.150)
                            {
                                sonuc = "NORMAL";
                                textBox6.Text = Convert.ToString(sonuc);
                            }
                            else
                            {
                                if (tst > 10.75)
                                {
                                    sonuc = "HYPER";
                                    textBox6.Text = Convert.ToString(sonuc);
                                }
                                else
                                {
                                    sonuc = "NORMAL";
                                    textBox6.Text = Convert.ToString(sonuc);
                                }
                            }
                        }

                    }
                }




            }
        }

        
    }
}
