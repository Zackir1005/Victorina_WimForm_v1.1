using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Victorina_WimForm_v1._1
{
    public partial class Form1 : Form
    {
        public static int Count { get; set; }
        public static int Goal { get; set; }
        public static string UserName { get; set; }
        public Form1()
        {
            InitializeComponent();
        }
        public void AddFile()
        {
            string q = "Quest.rtf";
            var newFile = File.Create(q);
            StreamWriter sw = new StreamWriter(newFile);
            sw.WriteLine("1.Единица измерения скорости.\r\na) кг b) литр c) км/ч.\r\n\n" +
                "2.Какой по счету от Солнца является Земля?\r\na) Третья. b) Пятая c) Вторая\r\n\n" +
                "3.Как называется прямая, ограниченная точками? \r\na) Луч b) Отрезок. c) Плоскость\r\n\n" +
                "4.Сколько звуков в слове «конь»? \r\na) Четыре b) Три. c) Пять\r\n\n" +
                "5.Выберите верное утверждение из перечисленных. \r\n" +
                "a) Согласная буква не образует слог. b) Согласная образует слог c) Согласная в некоторых случаях образует слог\r\n\n" +
                "6.Какой из этих цветов больше всего любят комары? \r\na) Желтый b) Синий. c) Красный\r\n\n" +
                "7.Если смешать краску красного и синего цвета, получится… \r\na) Зеленый b) Фиолетовый. c) Черный");
            sw.Close();
            newFile.Close();
        }

        private void RTB_Click(object sender, EventArgs e)
        {
            AddFile();
            RTB.LoadFile("QV.rtf");
            comboBox1.Enabled = true;
            comboBox2.Enabled = true;
            comboBox3.Enabled = true;
            comboBox4.Enabled = true;
            comboBox5.Enabled = true;
            comboBox6.Enabled = true;
            comboBox7.Enabled = true;
            btnResult.Enabled = true;
        }

        private void btnFinish_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAcceptUserName_Click(object sender, EventArgs e)
        {
            UserName = txtBoxUserName.Text;
            if (txtBoxUserName.Text != " ")
            {
                RTB.Enabled = true;
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            txtBoxUserName.Enabled = true;
            btnAcceptUserName.Enabled = true;
            btnStart.Enabled = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                string q = "Data.txt";
                StreamWriter sw = File.AppendText(q);
                sw.WriteLine(DateTime.Now);
                sw.WriteLine($"Результаты пользователя {UserName}:\r\nПравильных ответов - {Count}\r\nВаша оценка - {Goal}\r\n");
                sw.Close();
                MessageBox.Show("Результаты сохранены в файл!");
            }
            catch
            {
                MessageBox.Show("Результаты несохранены в файл!");
            }
        }

        public void IsRigth()
        {
            if (comboBox1.Text == "c")
            {
                Count++;
            }
            if (comboBox2.Text == "a")
            {
                Count++;
            }
            if (comboBox3.Text == "b")
            {
                Count++;
            }
            if (comboBox4.Text == "b")
            {
                Count++;
            }
            if (comboBox5.Text == "a")
            {
                Count++;
            }
            if (comboBox6.Text == "b")
            {
                Count++;
            }
            if (comboBox7.Text == "b")
            {
                Count++;
            }
            btnFinish.Enabled = true;
        }

        public void Evaluations()
        {
            if (Count == 0)
            {
                Goal = 0;
            }
            if (Count == 1 || Count == 2 || Count == 3 || Count == 4)
            {
                Goal = 1;
            }
            if (Count == 5 || Count == 6 || Count == 7 || Count == 8)
            {
                Goal = 2;
            }
            if (Count == 9 || Count == 10 || Count == 11 || Count == 12)
            {
                Goal = 3;
            }
            if (Count == 13 || Count == 14 || Count == 15 || Count == 16)
            {
                Goal = 4;
            }
            if (Count == 17 || Count == 18 || Count == 19 || Count == 20)
            {
                Goal = 5;
            }
            labelResult.Text = $"Результаты пользователя {UserName}:\r\nПравильных ответов - {Count}\r\nВаша оценка - {Goal}\r\n";
        }

        private void btnResult_Click(object sender, EventArgs e)
        {
            IsRigth();
            Evaluations();
            comboBox1.Enabled = false;
            comboBox2.Enabled = false;
            comboBox3.Enabled = false;
            comboBox4.Enabled = false;
            comboBox5.Enabled = false;
            comboBox6.Enabled = false;
            comboBox7.Enabled = false;
            txtBoxUserName.Enabled = false;
            btnResult.Enabled = false;
            btnSave.Enabled = true;
        }
    }
}

/// <summary>
/// 1.Единица измерения скорости.
/// a) кг b) литр c) км/ч.
/// 2.Какой по счету от Солнца является Земля?
/// a) Третья.b) Пятая c) Вторая
/// 3.Как называется прямая, ограниченная точками? 
/// a) Луч b) Отрезок.c) Плоскость
/// 4.Сколько звуков в слове «конь»? 
/// a) Четыре b) Три.c) Пять
/// 5.Выберите верное утверждение из перечисленных.
/// a) Согласная буква не образует слог.b) Согласная образует слог c) Согласная в некоторых случаях образует слог
/// 6.Какой из этих цветов больше всего любят комары? 
/// a) Желтый b) Синий.c) Красный
/// 7.Если смешать краску красного и синего цвета, получится… 
/// a) Зеленый b) Фиолетовый.c) Черный
/// </summary>