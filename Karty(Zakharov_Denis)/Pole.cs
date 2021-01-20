using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Karty_Zakharov_Denis_
{
    public partial class Pole : Form
    {
        Random myRnd = new Random();
        List<int> lstPovtor = new List<int>();
        public Pole()
        {
            InitializeComponent();
        }
        //Переход в Настройки
        private void button1_Click(object sender, EventArgs e)
        {
            Settings myForm = new Settings();
            this.Visible = false;
            myForm.Show();
        }
        //Правила Игры
        private void brtPravila_Click(object sender, EventArgs e)
        {
            MessageBox.Show("У пользователя на отдельной форме запрашивается имя, которое далее используется для обозначения карт игрока и определения имени победителя. По щелчку на кнопке Раздать игроку Папа Джонни верхнее поле заполняется изображениями 6-ти карт и становится доступ-ной кнопка Себе. По щелчку на кнопке Себе карты раздаются пользователю. После раздачи карт становятся доступными функции Разложить и Определить победителя. По кнопке Разложить карты сортируются и выкладываются для каждого игрока по возрастанию. По кнопке Опреде-лить победителя суммируются очки, присущие каждой карте (шестерка=1, семерка=2, восьмер-ка=3 и т.д.), и определяется победитель в данной игре. Кнопка Сначала начинает игру заново. Жалаем Побед!", "Правила и Описание игры");
        }
        //Раздать компьютеру
        private void btnRzdComp_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            lstPovtor.Clear();
            //Генерация 6 чисел от 11 до 50 без повторения
            for (int i = 1; i <= 6; i++)
            {
                int t;
                do
                {
                    t = myRnd.Next(11, 50);

                } while ((lstPovtor.Contains(t)) && (t!=20)&&(t!=30)&&(t!=40));
                lstPovtor.Add(t);
                listBox1.Items.Add(t);
                
            }
            // Генирация картинок для копьютера из списка в picturebox
            //for (int i = 1; i <= 6; i++)
            //{
            //    string resName =i.ToString();
            //    object resObj = Properties.Resources.ResourceManager.GetObject(resName);
               

            //}
            
            
            btnRzdIgr.Enabled = true;
        }
        //Отсортировать
        private void btnSort_Click(object sender, EventArgs e)
        {

            int k = 0;

            k = 0;
            for (int i = 0; i < listBox1.Items.Count - 1; i++)
            {
                if ((int)listBox1.Items[i] > (int)listBox1.Items[i + 1])
                {
                    int t = (int)listBox1.Items[i];
                    listBox1.Items[i] = listBox1.Items[i + 1];
                    listBox1.Items[i + 1] = t;
                    k++;
                }
            }
            int r = 0;

            r = 0;
            for (int i = 0; i < listBox2.Items.Count - 1; i++)
            {
                if ((int)listBox2.Items[i] > (int)listBox2.Items[i + 1])
                {
                    int d = (int)listBox2.Items[i];
                    listBox2.Items[i] = listBox2.Items[i + 1];
                    listBox2.Items[i + 1] = d;
                    r++;
                }
            }
            btnPob.Enabled = true;
        }
        //Раздать игроку
        private void btnRzdIgr_Click(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
            lstPovtor.Clear();
            for (int i = 1; i <= 6; i++)
            {
                int t;
                do
                {
                    t = myRnd.Next(11, 50);

                } while (lstPovtor.Contains(t));
                lstPovtor.Add(t);
                listBox2.Items.Add(t);

                btnSort.Enabled = true;
            }
        }

        private void btnPob_Click(object sender, EventArgs e)
        {
            int igrok, comp;
            igrok = 10;
                comp=5;
            if (igrok > comp) 
            {
                MessageBox.Show("Вы победили, мои поздравления !!!", "Победа");
                btnSort.Enabled = false;
                btnRzdComp.Enabled = false;
                btnRzdIgr.Enabled = false;

            }
        }

        private void btnAgain_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            btnRzdComp.Enabled = true;
            btnRzdIgr.Enabled = false;
            btnSort.Enabled = false;
            btnPob.Enabled = false;
            foreach (PictureBox ee in groupBox1.Controls)
            {
                ee.Image = Properties.Resources.card7;
            }
            foreach (PictureBox ee in groupBox2.Controls)
            {
                ee.Image = Properties.Resources.card7;
            }



        }
    }
}
