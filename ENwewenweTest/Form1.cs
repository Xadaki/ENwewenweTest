using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ENwewenweTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        
        string im1 = "D:/123/Image.jpg"; //im1 - переменная для хранения пути изображения 1
        string im2= ""; //im2- переменная для хранения пути изображения 2



        
        public void Test(string one) //метод принимает строку, которая является путём к изображению. Внутри метода переменно one присваивается эта строка, и впоследствии её можно использовать для "вызова" этой строк
        {
            pictureBox1.Image = Image.FromFile(one);

        }

        

        private void Form1_Load(object sender, EventArgs e) //Загрузка формы, на неё можно забить
        {
            
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e) //событие изменения заничения в dateTimePicker
        {
            switch (dateTimePicker1.Value.ToShortDateString()) //dateTimePicker1.Value - значение в dateTimePicker1. ".ToShortDateString()" - преобразование типа данных в string
            {
                case "05.12.2022": //В случае если выбранная дата - 05.12.2022
                    Test(im1); //Выводится картинка, по пути, прописанный в переменной im1
                    break;

            }
        }
    }
}
