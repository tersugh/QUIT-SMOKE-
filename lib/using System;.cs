using System;

using System.Collections.Generic;

using System.ComponentModel;

using System.Data;

using System.Drawing;

using System.Linq;

using System.Text;

using System.Threading.Tasks;

using System.Windows.Forms;



namespace ЛРТОАУ_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            panel1.VerticalScroll.Maximum = 1000;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double P2 = double.Parse(textBox10.Text);

            double K2_min = double.Parse(textBox8.Text);

            double K2_max = double.Parse(textBox7.Text);

            double P1L_min = double.Parse(textBox6.Text);

            double P1L_max = double.Parse(textBox5.Text);



            Pen newPen = new Pen(Color.Black, 2);

            Graphics myGraphics = panel1.CreateGraphics();



            //--------------------------------------------------------------Таблица Наборов---------------------------------------------------------------------------------------------------------------- 



            myGraphics.DrawLine(newPen, 100, 20, 600, 20);

            myGraphics.DrawLine(newPen, 100, 40, 600, 40);

            myGraphics.DrawString("При производительности " + P2.ToString() + " получим следующие наборы:", new Font("Times New Roman", 10, System.Drawing.FontStyle.Regular), Brushes.Black, 100, 0);

            myGraphics.DrawString("№ набора", new Font("Times New Roman", 10, System.Drawing.FontStyle.Regular), Brushes.Black, 130, 22);

            myGraphics.DrawString("Р2^Л, т/ч", new Font("Times New Roman", 10, System.Drawing.FontStyle.Regular), Brushes.Black, 260, 22);

            myGraphics.DrawString("К2", new Font("Times New Roman", 10, System.Drawing.FontStyle.Regular), Brushes.Black, 400, 22);

            myGraphics.DrawString("Р2, т/ч", new Font("Times New Roman", 10, System.Drawing.FontStyle.Regular), Brushes.Black, 520, 22);



            double[] arrayPIL = new double[0];

            double[] arrayK2 = new double[0];

            int c;



            if ((P2 / K2_max >= P1L_min) && (P2 / K2_max <= P1L_max))

            {

                double counter = Math.Round(P2 / K2_max, 2);

                c = 0;

                while (counter < P1L_max)

                {

                    myGraphics.DrawString((c + 1).ToString(), new Font("Times New Roman", 10, System.Drawing.FontStyle.Regular), Brushes.Black, 160, 42 + c * 20);

                    myGraphics.DrawString(Math.Round(counter, 2).ToString(), new Font("Times New Roman", 10, System.Drawing.FontStyle.Regular), Brushes.Black, 270, 42 + c * 20);

                    myGraphics.DrawString(Math.Round(P2 / counter, 2).ToString(), new Font("Times New Roman", 10, System.Drawing.FontStyle.Regular), Brushes.Black, 400, 42 + c * 20);

                    myGraphics.DrawLine(newPen, 100, 60 + c * 20, 475, 60 + c * 20);



                    double[] copyArrayPIL = arrayPIL;

                    arrayPIL = new double[arrayPIL.Length + 1];

                    for (int i = 0; i < copyArrayPIL.Length; i++)

                        arrayPIL[i] = copyArrayPIL[i];

                    arrayPIL[arrayPIL.Length - 1] = counter;



                    double[] copyArrayK2 = arrayK2;

                    arrayK2 = new double[arrayK2.Length + 1];

                    for (int i = 0; i < copyArrayK2.Length; i++)

                        arrayK2[i] = copyArrayK2[i];

                    arrayK2[arrayK2.Length - 1] = Math.Round(P2 / counter, 2);



                    counter += 0.2;

                    c += 1;

                }

                myGraphics.DrawLine(newPen, 100, 20, 100, (c + 2) * 20);

                myGraphics.DrawLine(newPen, 225, 20, 225, (c + 2) * 20);

                myGraphics.DrawLine(newPen, 350, 20, 350, (c + 2) * 20);

                myGraphics.DrawLine(newPen, 475, 20, 475, (c + 2) * 20);

                myGraphics.DrawLine(newPen, 600, 20, 600, (c + 2) * 20);

                myGraphics.DrawLine(newPen, 475, (c + 2) * 20, 600, (c + 2) * 20);

                myGraphics.DrawString(Math.Round(P2, 2).ToString(), new Font("Times New Roman", 10, System.Drawing.FontStyle.Regular), Brushes.Black, 525, 40 + ((c + 1) * 10) - 20);



            }

            else

            {

                double counter = Math.Round(P2 / P1L_min, 2);

                c = 0;

                while (counter < K2_max)

                {

                    myGraphics.DrawString((c + 1).ToString(), new Font("Times New Roman", 10, System.Drawing.FontStyle.Regular), Brushes.Black, 160, 42 + c * 20);

                    myGraphics.DrawString(Math.Round(counter, 2).ToString(), new Font("Times New Roman", 10, System.Drawing.FontStyle.Regular), Brushes.Black, 400, 42 + c * 20);

                    myGraphics.DrawString(Math.Round(P2 / counter, 2).ToString(), new Font("Times New Roman", 10, System.Drawing.FontStyle.Regular), Brushes.Black, 270, 42 + c * 20);

                    myGraphics.DrawLine(newPen, 100, 60 + c * 20, 475, 60 + c * 20);



                    double[] copyArrayPIL = arrayPIL;

                    arrayPIL = new double[arrayPIL.Length + 1];

                    for (int i = 0; i < copyArrayPIL.Length; i++)

                        arrayPIL[i] = copyArrayPIL[i];

                    arrayPIL[arrayPIL.Length - 1] = Math.Round(P2 / counter, 2);



                    double[] copyArrayK2 = arrayK2;

                    arrayK2 = new double[arrayK2.Length + 1];

                    for (int i = 0; i < copyArrayK2.Length; i++)

                        arrayK2[i] = copyArrayK2[i];

                    arrayK2[arrayK2.Length - 1] = counter;



                    counter += 0.2;

                    c += 1;

                }

                myGraphics.DrawLine(newPen, 100, 20, 100, (c + 2) * 20);

                myGraphics.DrawLine(newPen, 225, 20, 225, (c + 2) * 20);

                myGraphics.DrawLine(newPen, 350, 20, 350, (c + 2) * 20);

                myGraphics.DrawLine(newPen, 475, 20, 475, (c + 2) * 20);

                myGraphics.DrawLine(newPen, 600, 20, 600, (c + 2) * 20);

                myGraphics.DrawLine(newPen, 475, (c + 2) * 20, 600, (c + 2) * 20);

                myGraphics.DrawString(Math.Round(P2, 2).ToString(), new Font("Times New Roman", 10, System.Drawing.FontStyle.Regular), Brushes.Black, 525, 40 + ((c + 1) * 10) - 20);

            }



            //--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- 



            double[] arrayLam = new double[arrayPIL.Length];



            //--------------------------------------------------------------Таблица производственных затрат------------------------------------------------------------------------------------------------ 



            int coorlam = (c + 3) * 20;



            myGraphics.DrawString("Производственные затраты каждого набора:", new Font("Times New Roman", 10, System.Drawing.FontStyle.Regular), Brushes.Black, 100, coorlam);

            myGraphics.DrawLine(newPen, 100, coorlam + 20, 600, coorlam + 20);

            myGraphics.DrawLine(newPen, 100, coorlam + 40, 600, coorlam + 40);

            myGraphics.DrawLine(newPen, 100, coorlam + 20, 100, coorlam + coorlam - 20);

            myGraphics.DrawLine(newPen, 350, coorlam + 20, 350, coorlam + coorlam - 20);

            myGraphics.DrawLine(newPen, 600, coorlam + 20, 600, coorlam + coorlam - 20);

            myGraphics.DrawString("№ набора", new Font("Times New Roman", 10, System.Drawing.FontStyle.Regular), Brushes.Black, 195, coorlam + 22);

            myGraphics.DrawString("Производственные затраты", new Font("Times New Roman", 10, System.Drawing.FontStyle.Regular), Brushes.Black, 400, coorlam + 22);



            for (int i = 0; i < arrayPIL.Length; i++)

            {

                myGraphics.DrawString((i + 1).ToString(), new Font("Times New Roman", 10, System.Drawing.FontStyle.Regular), Brushes.Black, 220, (coorlam + 42) + i * 20);

                double lam = Math.Round(197.219 - 27.503 * arrayPIL[i] - 185 * arrayK2[i] + 4.888 * arrayPIL[i] * arrayPIL[i] + 260 * arrayK2[i] * arrayK2[i] - 45.9 * arrayPIL[i] * arrayK2[i], 2);

                myGraphics.DrawString(Math.Round(lam, 2).ToString(), new Font("Times New Roman", 10, System.Drawing.FontStyle.Regular), Brushes.Black, 460, (coorlam + 42) + i * 20);

                myGraphics.DrawLine(newPen, 100, (coorlam + 60) + i * 20, 600, (coorlam + 60) + i * 20);



                arrayLam[i] = lam;

            }



            int coor = (coorlam + 60) + arrayLam.Length * 20;



            myGraphics.DrawString("Набор с наименьшими затратами - " + (Array.IndexOf(arrayLam, arrayLam.Min()) + 1).ToString(), new Font("Times New Roman", 10, System.Drawing.FontStyle.Regular), Brushes.Black, 100, coor);



            //--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- 



            double[] arrayP1 = new double[arrayPIL.Length];



            //--------------------------------------------------------------Таблица первого участка-------------------------------------------------------------------------------------------------------- 



            myGraphics.DrawString("Рассмотрим область изменения производительности первого участка: ", new Font("Times New Roman", 10, System.Drawing.FontStyle.Regular), Brushes.Black, 100, coor + 20);

            myGraphics.DrawLine(newPen, 100, coor + 40, 600, coor + 40);

            myGraphics.DrawLine(newPen, 100, coor + 60, 600, coor + 60);

            myGraphics.DrawLine(newPen, 100, coor + 40, 100, coor + (arrayPIL.Length + 3) * 20);

            myGraphics.DrawLine(newPen, 350, coor + 40, 350, coor + (arrayPIL.Length + 3) * 20);

            myGraphics.DrawLine(newPen, 600, coor + 40, 600, coor + (arrayPIL.Length + 3) * 20);

            myGraphics.DrawString("P1^Л", new Font("Times New Roman", 10, System.Drawing.FontStyle.Regular), Brushes.Black, 210, coor + 42);

            myGraphics.DrawString("Р1", new Font("Times New Roman", 10, System.Drawing.FontStyle.Regular), Brushes.Black, 460, coor + 42);

            for (int i = 0; i < arrayPIL.Length; i++)

            {

                myGraphics.DrawString(Math.Round(arrayPIL[i], 2).ToString(), new Font("Times New Roman", 10, System.Drawing.FontStyle.Regular), Brushes.Black, 220, (coor + 62) + i * 20);

                double P1 = Math.Round(arrayPIL[i] * 0.7, 3);

                myGraphics.DrawString(Math.Round(P1, 2).ToString(), new Font("Times New Roman", 10, System.Drawing.FontStyle.Regular), Brushes.Black, 460, (coor + 62) + i * 20);

                myGraphics.DrawLine(newPen, 100, (coor + 80) + i * 20, 600, (coor + 80) + i * 20);



                arrayP1[i] = P1;

            }



            //--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- 



            double K1_min = double.Parse(textBox4.Text);

            double K1_max = double.Parse(textBox3.Text);

            double P0_min = double.Parse(textBox1.Text);

            double P0_max = double.Parse(textBox2.Text);



            double[] arrayP0 = new double[arrayP1.Length * 3];

            double[] arrayK1 = new double[arrayP1.Length * 3];

            double[] arrayF1 = new double[arrayP1.Length * 3];





            //--------------------------------------------------------------Таблица наборов и их затрат---------------------------------------------------------------------------------------------------- 



            myGraphics.DrawString("Построим таблицу наборов по P1 и их затраты: ", new Font("Times New Roman", 10, System.Drawing.FontStyle.Regular), Brushes.Black, 700, 0);

            myGraphics.DrawString("№ набора", new Font("Times New Roman", 10, System.Drawing.FontStyle.Regular), Brushes.Black, 720, 22);

            myGraphics.DrawString("Р1", new Font("Times New Roman", 10, System.Drawing.FontStyle.Regular), Brushes.Black, 840, 22);

            myGraphics.DrawString("Р0", new Font("Times New Roman", 10, System.Drawing.FontStyle.Regular), Brushes.Black, 940, 22);

            myGraphics.DrawString("K1", new Font("Times New Roman", 10, System.Drawing.FontStyle.Regular), Brushes.Black, 1040, 22);

            myGraphics.DrawString("φ2", new Font("Times New Roman", 10, System.Drawing.FontStyle.Regular), Brushes.Black, 1140, 22);

            myGraphics.DrawLine(newPen, 700, 20, 1200, 20);

            myGraphics.DrawLine(newPen, 700, 40, 1200, 40);

            myGraphics.DrawLine(newPen, 700, 20, 700, 40 + arrayPIL.Length * 60);

            myGraphics.DrawLine(newPen, 800, 20, 800, 40 + arrayPIL.Length * 60);

            myGraphics.DrawLine(newPen, 900, 20, 900, 40 + arrayPIL.Length * 60);

            myGraphics.DrawLine(newPen, 1000, 20, 1000, 40 + arrayPIL.Length * 60);

            myGraphics.DrawLine(newPen, 1100, 20, 1100, 40 + arrayPIL.Length * 60);

            myGraphics.DrawLine(newPen, 1200, 20, 1200, 40 + arrayPIL.Length * 60);



            for (int i = 0; i < arrayPIL.Length; i++)

            {

                myGraphics.DrawString((i + 1).ToString(), new Font("Times New Roman", 10, System.Drawing.FontStyle.Regular), Brushes.Black, 745, 62 + i * 60);

                myGraphics.DrawString(arrayP1[i].ToString(), new Font("Times New Roman", 10, System.Drawing.FontStyle.Regular), Brushes.Black, 835, 62 + i * 60);

                myGraphics.DrawLine(newPen, 900, 60 + i * 60, 1200, 60 + i * 60);

                myGraphics.DrawLine(newPen, 900, 80 + i * 60, 1200, 80 + i * 60);

                myGraphics.DrawLine(newPen, 700, 100 + i * 60, 1200, 100 + i * 60);

                myGraphics.DrawString(Math.Round(arrayP1[i] / K1_max, 2).ToString(), new Font("Times New Roman", 10, System.Drawing.FontStyle.Regular), Brushes.Black, 935, 42 + i * 60);

                myGraphics.DrawString(Math.Round(K1_max, 2).ToString(), new Font("Times New Roman", 10, System.Drawing.FontStyle.Regular), Brushes.Black, 1035, 42 + i * 60);



                arrayP0[i * 3] = Math.Round(arrayP1[i] / K1_max, 2);

                arrayK1[i * 3] = Math.Round(K1_max, 2);





                double thirdP0 = Math.Round(arrayP1[i] / K1_max, 2);

                double K1 = Math.Round(K1_max, 2);

                while ((thirdP0 < P0_max) && (K1 > K1_min))

                {

                    K1 -= 0.001;

                    thirdP0 = arrayP1[i] / K1;

                }



                myGraphics.DrawString(Math.Round(thirdP0, 2).ToString(), new Font("Times New Roman", 10, System.Drawing.FontStyle.Regular), Brushes.Black, 935, 82 + i * 60);

                myGraphics.DrawString(Math.Round(K1, 2).ToString(), new Font("Times New Roman", 10, System.Drawing.FontStyle.Regular), Brushes.Black, 1035, 82 + i * 60);



                arrayP0[i * 3 + 2] = Math.Round(thirdP0, 2);

                arrayK1[i * 3 + 2] = Math.Round(K1, 2);



                double secP0 = Math.Round((arrayP1[i] / K1_max) + ((thirdP0 - (arrayP1[i] / K1_max)) / 2), 2);

                myGraphics.DrawString(Math.Round(secP0, 2).ToString(), new Font("Times New Roman", 10, System.Drawing.FontStyle.Regular), Brushes.Black, 935, 62 + i * 60);

                myGraphics.DrawString(Math.Round(arrayP1[i] / secP0, 2).ToString(), new Font("Times New Roman", 10, System.Drawing.FontStyle.Regular), Brushes.Black, 1035, 62 + i * 60);



                arrayP0[i * 3 + 1] = Math.Round(secP0, 2);

                arrayK1[i * 3 + 1] = Math.Round(arrayP1[i] / secP0, 2);

            }



            for (int i = 0; i < arrayP0.Length; i++)

            {

                double f1 = 8882.46 + 164.962 * arrayP0[i] - 18620 * arrayK1[i] + 17.593 * arrayP0[i] * arrayP0[i] + 10155 * arrayK1[i] * arrayK1[i] - 328.271 * arrayP0[i] * arrayK1[i];

                myGraphics.DrawString(Math.Round(f1, 2).ToString(), new Font("Times New Roman", 10, System.Drawing.FontStyle.Regular), Brushes.Black, 1135, 42 + i * 20);

                arrayF1[i] = Math.Round(f1, 2);

            }



            //--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- 



            //--------------------------------------------------------------Наименьшее значение ф1 и общий минимум----------------------------------------------------------------------------------------- 



            int zone = 1;

            while (zone * 3 < Array.IndexOf(arrayF1, arrayF1.Min()))

            {

                zone += 1;

            }



            myGraphics.DrawString("Наименьшее значение ф1 = " + arrayF1.Min().ToString() + " - участок №" + (zone + 1).ToString(), new Font("Times New Roman", 10, System.Drawing.FontStyle.Regular), Brushes.Black, 700, (arrayF1.Length + 3) * 20);



            myGraphics.DrawString("Общий минимум: ", new Font("Times New Roman", 10, System.Drawing.FontStyle.Regular), Brushes.Black, 700, (arrayF1.Length + 4) * 20);

            myGraphics.DrawString("Ф = ф1 + ф2 = " + Math.Round((arrayLam.Min() + arrayF1.Min()), 2).ToString(), new Font("Times New Roman", 10, System.Drawing.FontStyle.Regular), Brushes.Black, 700, (arrayF1.Length + 5) * 20);





            //--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- 



            //--------------------------------------------------------------Таблица общих затрат----------------------------------------------------------------------------------------------------------- 





            myGraphics.DrawString("Общие затраты:  ", new Font("Times New Roman", 10, System.Drawing.FontStyle.Regular), Brushes.Black, 1300, 0);

            myGraphics.DrawLine(newPen, 1300, 20, 1700, 20);

            myGraphics.DrawString("P1^Л", new Font("Times New Roman", 10, System.Drawing.FontStyle.Regular), Brushes.Black, 1335, 22);

            for (int i = 0; i < arrayPIL.Length; i++)

                myGraphics.DrawString(Math.Round(arrayPIL[i], 2).ToString(), new Font("Times New Roman", 10, System.Drawing.FontStyle.Regular), Brushes.Black, 1410 + i * 50, 22);

            myGraphics.DrawLine(newPen, 1300, 40, 1700, 40);

            myGraphics.DrawLine(newPen, 1300, 80, 1700, 80);

            myGraphics.DrawLine(newPen, 1300, 20, 1300, 80);

            myGraphics.DrawLine(newPen, 1400, 20, 1400, 80);

            myGraphics.DrawLine(newPen, 1450, 20, 1450, 80);

            myGraphics.DrawLine(newPen, 1500, 20, 1500, 80);

            myGraphics.DrawLine(newPen, 1550, 20, 1550, 80);

            myGraphics.DrawLine(newPen, 1600, 20, 1600, 80);

            myGraphics.DrawLine(newPen, 1650, 20, 1650, 80);

            myGraphics.DrawLine(newPen, 1700, 20, 1700, 80);

            myGraphics.DrawLine(newPen, 1300, 40, 1400, 80);

            myGraphics.DrawString("P1", new Font("Times New Roman", 10, System.Drawing.FontStyle.Regular), Brushes.Black, 1375, 42);

            myGraphics.DrawString("P0", new Font("Times New Roman", 10, System.Drawing.FontStyle.Regular), Brushes.Black, 1305, 62);

            for (int i = 0; i < arrayPIL.Length; i++)

                myGraphics.DrawString(Math.Round(arrayP1[i], 2).ToString(), new Font("Times New Roman", 10, System.Drawing.FontStyle.Regular), Brushes.Black, 1405 + i * 50, 52);



            double[] sortedArrayP0 = new double[arrayP0.Length];

            for (int i = 0; i < arrayP0.Length; i++)

                sortedArrayP0[i] = arrayP0[i];



            Array.Sort(sortedArrayP0);



            double[] newArrayP0 = new double[0];



            for (int i = 0; i < sortedArrayP0.Length - 1; i++)

            {

                if (sortedArrayP0[i] != sortedArrayP0[i + 1])

                {

                    double[] copyNewArrayP0 = newArrayP0;

                    newArrayP0 = new double[newArrayP0.Length + 1];

                    for (int j = 0; j < copyNewArrayP0.Length; j++)

                        newArrayP0[j] = copyNewArrayP0[j];

                    newArrayP0[newArrayP0.Length - 1] = sortedArrayP0[i];

                }

            }



            double[] copyNewArrayP01 = newArrayP0;

            newArrayP0 = new double[newArrayP0.Length + 1];

            for (int j = 0; j < copyNewArrayP01.Length; j++)

                newArrayP0[j] = copyNewArrayP01[j];

            newArrayP0[newArrayP0.Length - 1] = sortedArrayP0[sortedArrayP0.Length - 1];



            int z;

            for (z = 0; z < newArrayP0.Length; z++)

            {

                myGraphics.DrawString(Math.Round(newArrayP0[z], 2).ToString(), new Font("Times New Roman", 10, System.Drawing.FontStyle.Regular), Brushes.Black, 1335, 82 + z * 20);

                myGraphics.DrawLine(newPen, 1300, 100 + z * 20, 1700, 100 + z * 20);



                for (int j = 0; j < arrayP0.Length; j++)

                {

                    if (arrayP0[j] == newArrayP0[z])

                    {

                        zone = j / 3;

                        myGraphics.DrawString(Math.Round(arrayLam[zone] + arrayF1[j], 2).ToString(), new Font("Times New Roman", 10, System.Drawing.FontStyle.Regular), Brushes.Black, 1405 + zone * 50, 82 + z * 20);

                    }

                }

            }





            myGraphics.DrawLine(newPen, 1300, 80, 1300, 80 + z * 20);

            myGraphics.DrawLine(newPen, 1400, 80, 1400, 80 + z * 20);

            myGraphics.DrawLine(newPen, 1450, 80, 1450, 80 + z * 20);

            myGraphics.DrawLine(newPen, 1500, 80, 1500, 80 + z * 20);

            myGraphics.DrawLine(newPen, 1550, 80, 1550, 80 + z * 20);

            myGraphics.DrawLine(newPen, 1600, 80, 1600, 80 + z * 20);

            myGraphics.DrawLine(newPen, 1650, 80, 1650, 80 + z * 20);

            myGraphics.DrawLine(newPen, 1700, 80, 1700, 80 + z * 20);



            //--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- 
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }
    }
}