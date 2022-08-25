using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ovoch
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.textBox5.Text = showTime(DateTime.Now.ToString());


            this.label1.Text = "Пример ввода：" + DateTime.Now.Year.ToString() + "  -год-  " + DateTime.Now.Month.ToString() + "  -месяц-  " + DateTime.Now.Day.ToString() + "  -день-  " + DateTime.Now.Hour.ToString() + "  -час-  " + DateTime.Now.Minute.ToString() + "  -минута-  " + DateTime.Now.Second.ToString() + "  -секунда  \n　　　Пожалуйста, напишите так：  " + showTime(DateTime.Now.ToString());


        }

        public string showTime(string Time)


        {


            if (Time.IndexOf("time") != -1)


                Time = (Time.Remove(Time.IndexOf("time") + 3, 2).Insert(Time.IndexOf("time") + 3, (int.Parse(Time.Substring(Time.IndexOf("time") + 3, 2)) + 12).ToString())).Replace("time", "");


            if (Time.IndexOf("time") != -1)


                Time = (Time.Remove(Time.IndexOf("time") + 3, 2).Insert(Time.IndexOf("time") + 3, (int.Parse(Time.Substring(Time.IndexOf("time") + 3, 2)) + 12).ToString())).Replace("time", "");


            return Time;


        }









        private void button1_Click_1(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())


            {


                if (ofd.ShowDialog() == DialogResult.OK)


                {


                    this.textBox1.Text = ofd.FileName;


                    this.textBox2.Text = showTime(System.IO.File.GetCreationTime(this.textBox1.Text).ToString());


                    this.textBox3.Text = showTime(System.IO.File.GetLastWriteTime(this.textBox1.Text).ToString());


                    this.textBox4.Text = showTime(System.IO.File.GetLastAccessTime(this.textBox1.Text).ToString());


                }


            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            {


                try


                {


                    System.IO.File.SetCreationTime(this.textBox1.Text, DateTime.Parse(textBox2.Text));


                    System.IO.File.SetLastWriteTime(this.textBox1.Text, DateTime.Parse(textBox3.Text));


                    System.IO.File.SetLastAccessTime(this.textBox1.Text, DateTime.Parse(textBox4.Text));


                    MessageBox.Show("Успешно модифицировано");//Успешно модифицировано 修改成功


                }


                catch


                {


                    MessageBox.Show("Вы не выбрали файл!"); //Вы не выбрали файл!您沒有選取檔案！


                }
            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {


            Clipboard.SetData(DataFormats.Text, this.textBox5.Text);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
