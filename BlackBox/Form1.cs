using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlackBox
{
    //Внимание!!!! Проест очень очень сырой большинсто исключений не обработоно. Не старайтесь сломать программу, я вам говрю:у вас это получится!!!
    public partial class mainForm : Form
    {
        //лист входных данных
        List<string> listOfIntput = new List<string>();
         static int SelectedLevel = 1;
         public bool answerTruthCheck = false;

        void locationChange()
        {
            buttonToAnswer.Left = panelMain.Width / 2 - buttonToAnswer.Width / 2;
            buttonToAnswer.Top = panelMain.Height / 2 - buttonToAnswer.Height / 2;
            buttonRemoveAll.Left = panelMain.Width / 2 - buttonRemoveAll.Width / 2;
            buttonRemoveAll.Top = panelMain.Height / 2 - buttonToAnswer.Height / 2 + 5 + buttonToAnswer.Height;
            textBoxInput.Left = buttonToAnswer.Left - textBoxInput.Width - 20;
            textBoxOutput.Left = buttonToAnswer.Left + buttonToAnswer.Width + 20;
            textBoxInput.Top = buttonToAnswer.Top;
            textBoxOutput.Top = buttonToAnswer.Top;
            labelForClues.Left =panelMain.Width - labelForClues.Width;
            labelForClues.Top = panelMain.Height - labelForClues.Height;
        }

        public mainForm()           
        {
            InitializeComponent();
            locationChange();
        }
        
        private double OutputLvl(string input)
        {
            
            try
            {
                //для каждого уровня своё возвращаемое число
                switch (SelectedLevel)
                {
                    case 1:
                        {
                            return Convert.ToDouble(input) + 1;
                        }

                    case 2:
                        {
                            return Convert.ToDouble(input) + 5;
                        }

                    case 3:
                        {
                            return Convert.ToDouble(input) + 15;
                        }

                    case 4:
                        {
                            return Convert.ToDouble(input) * 2;
                        }

                    case 5:
                        {
                            return Convert.ToDouble(input) * 3;
                        }

                    case 6:
                        {
                            return Convert.ToDouble(input) * 2 + 1;
                        }

                    case 7:
                        {
                            return Convert.ToDouble(input) * 2 - 2;
                        }

                    case 8:
                        {
                            return Convert.ToDouble(input) / 2;
                        }

                    case 9:
                        {
                            return Convert.ToDouble(input) / 2 + 1;
                        }
                    case 10:
                        {
                            return Math.Pow(Convert.ToDouble(input), 2);
                        }

                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Вводите только цифры и без пустых строк между ними!");
            }
            return 0;
        }



        private void buttonToAnswer_Click(object sender, EventArgs e)
        {           
            listOfIntput.Clear();
            textBoxOutput.Clear();
            listOfIntput.AddRange(textBoxInput.Text.Split('\n'));

            
            for (int i = 0; i < listOfIntput.Count(); i++)
            {
                if (listOfIntput[i] != "")
                {    
                    textBoxOutput.Text += (OutputLvl(listOfIntput[i]) + "\r\n");
                } 
                else
                {
                    break;
                }               
            }      

        }

        internal void outputLvl1()
        {
            throw new NotImplementedException();
        }

        //выбор уровня (по-другому не смог)
        private void toolStripButtonLvl1_Click(object sender, EventArgs e)
        {
            SelectedLevel = 1;
            toolStripButtonLvl1.Checked = true;
            toolStripButtonLvl2.Checked = false;
            toolStripButtonLvl3.Checked = false;
            toolStripButtonLvl4.Checked = false;
            toolStripButtonLvl5.Checked = false;
            toolStripButtonLvl6.Checked = false;
            toolStripButtonLvl7.Checked = false;
            toolStripButtonLvl8.Checked = false;
            toolStripButtonLvl9.Checked = false;
            toolStripButtonLvl10.Checked = false;
        }

        private void toolStripButtonLvl2_Click(object sender, EventArgs e)
        {
            SelectedLevel = 2;
            toolStripButtonLvl1.Checked = false;
            toolStripButtonLvl2.Checked = true;
            toolStripButtonLvl3.Checked = false;
            toolStripButtonLvl4.Checked = false;
            toolStripButtonLvl5.Checked = false;
            toolStripButtonLvl6.Checked = false;
            toolStripButtonLvl7.Checked = false;
            toolStripButtonLvl8.Checked = false;
            toolStripButtonLvl9.Checked = false;
            toolStripButtonLvl10.Checked = false;
        }

        private void toolStripButtonLvl3_Click(object sender, EventArgs e)
        {
            SelectedLevel = 3;
            toolStripButtonLvl1.Checked = false;
            toolStripButtonLvl2.Checked = false;
            toolStripButtonLvl3.Checked = true;
            toolStripButtonLvl4.Checked = false;
            toolStripButtonLvl5.Checked = false;
            toolStripButtonLvl6.Checked = false;
            toolStripButtonLvl7.Checked = false;
            toolStripButtonLvl8.Checked = false;
            toolStripButtonLvl9.Checked = false;
            toolStripButtonLvl10.Checked = false;

        }

        private void toolStripButtonLvl4_Click(object sender, EventArgs e)
        {
            SelectedLevel = 4;
            toolStripButtonLvl1.Checked = false;
            toolStripButtonLvl2.Checked = false;
            toolStripButtonLvl3.Checked = false;
            toolStripButtonLvl4.Checked = true;
            toolStripButtonLvl5.Checked = false;
            toolStripButtonLvl6.Checked = false;
            toolStripButtonLvl7.Checked = false;
            toolStripButtonLvl8.Checked = false;
            toolStripButtonLvl9.Checked = false;
            toolStripButtonLvl10.Checked = false;
        }

        private void toolStripButtonLvl5_Click(object sender, EventArgs e)
        {
            SelectedLevel = 5;
            toolStripButtonLvl1.Checked = false;
            toolStripButtonLvl2.Checked = false;
            toolStripButtonLvl3.Checked = false;
            toolStripButtonLvl4.Checked = false;
            toolStripButtonLvl5.Checked = true;
            toolStripButtonLvl6.Checked = false;
            toolStripButtonLvl7.Checked = false;
            toolStripButtonLvl8.Checked = false;
            toolStripButtonLvl9.Checked = false;
            toolStripButtonLvl10.Checked = false;
        }

        private void toolStripButtonLvl6_Click(object sender, EventArgs e)
        {
            SelectedLevel = 6;
            toolStripButtonLvl1.Checked = false;
            toolStripButtonLvl2.Checked = false;
            toolStripButtonLvl3.Checked = false;
            toolStripButtonLvl4.Checked = false;
            toolStripButtonLvl5.Checked = false;
            toolStripButtonLvl6.Checked = true;
            toolStripButtonLvl7.Checked = false;
            toolStripButtonLvl8.Checked = false;
            toolStripButtonLvl9.Checked = false;
            toolStripButtonLvl10.Checked = false;
        }

        private void toolStripButtonLvl7_Click(object sender, EventArgs e)
        {
            SelectedLevel = 7;
            toolStripButtonLvl1.Checked = false;
            toolStripButtonLvl2.Checked = false;
            toolStripButtonLvl3.Checked = false;
            toolStripButtonLvl4.Checked = false;
            toolStripButtonLvl5.Checked = false;
            toolStripButtonLvl6.Checked = false;
            toolStripButtonLvl7.Checked = true;
            toolStripButtonLvl8.Checked = false;
            toolStripButtonLvl9.Checked = false;
            toolStripButtonLvl10.Checked = false;
        }

        private void toolStripButtonLvl8_Click(object sender, EventArgs e)
        {
            SelectedLevel = 8;
            toolStripButtonLvl1.Checked = false;
            toolStripButtonLvl2.Checked = false;
            toolStripButtonLvl3.Checked = false;
            toolStripButtonLvl4.Checked = false;
            toolStripButtonLvl5.Checked = false;
            toolStripButtonLvl6.Checked = false;
            toolStripButtonLvl7.Checked = false;
            toolStripButtonLvl8.Checked = true;
            toolStripButtonLvl9.Checked = false;
            toolStripButtonLvl10.Checked = false;
        }

        private void toolStripButtonLvl9_Click(object sender, EventArgs e)
        {
            SelectedLevel = 9;
            toolStripButtonLvl1.Checked = false;
            toolStripButtonLvl2.Checked = false;
            toolStripButtonLvl3.Checked = false;
            toolStripButtonLvl4.Checked = false;
            toolStripButtonLvl5.Checked = false;
            toolStripButtonLvl6.Checked = false;
            toolStripButtonLvl7.Checked = false;
            toolStripButtonLvl8.Checked = false;
            toolStripButtonLvl9.Checked = true;
            toolStripButtonLvl10.Checked = false;
        }

        private void toolStripButtonLvl10_Click(object sender, EventArgs e)
        {
            SelectedLevel = 10;
            toolStripButtonLvl1.Checked = false;
            toolStripButtonLvl2.Checked = false;
            toolStripButtonLvl3.Checked = false;
            toolStripButtonLvl4.Checked = false;
            toolStripButtonLvl5.Checked = false;
            toolStripButtonLvl6.Checked = false;
            toolStripButtonLvl7.Checked = false;
            toolStripButtonLvl8.Checked = false;
            toolStripButtonLvl9.Checked = false;
            toolStripButtonLvl10.Checked = true;
        }

        //кнопка ответа
        private void toolStripButtonForAnswer_Click(object sender, EventArgs e)
        {
                   
            FormForAnswer answerForm = new FormForAnswer();
            answerForm.SelectedLevel2 = SelectedLevel;
            answerForm.ShowDialog();
            ToolStripButton[] lvlButtons = { toolStripButtonLvl1, toolStripButtonLvl2, toolStripButtonLvl3, toolStripButtonLvl4,toolStripButtonLvl5,toolStripButtonLvl6, toolStripButtonLvl7,toolStripButtonLvl8,toolStripButtonLvl9, toolStripButtonLvl10};
            if (answerForm.answerTruthCheck && SelectedLevel != 10)
            {
                lvlButtons[SelectedLevel].Enabled = true;
            }
            else if (answerForm.answerTruthCheck && SelectedLevel == 10)
            {
                MessageBox.Show("Мои поздравление, вы выйграли!");
            }
        }





        //изменение позиции элементов при изменении размеров формы
        private void mainForm_SizeChanged(object sender, EventArgs e)
        {
            locationChange();
        }

        private void начатьЗановоToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ToolStripButton[] lvlButtons = { toolStripButtonLvl1, toolStripButtonLvl2, toolStripButtonLvl3, toolStripButtonLvl4, toolStripButtonLvl5, toolStripButtonLvl6, toolStripButtonLvl7, toolStripButtonLvl8, toolStripButtonLvl9, toolStripButtonLvl10 };
            for (int i = 1; i < lvlButtons.Length; i++)
            {
                lvlButtons[i].Enabled = false;
            }
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonRemoveAll_Click(object sender, EventArgs e)
        {
            textBoxInput.Text = null;
            textBoxOutput.Text = null;
        }
        //Подсказка для учителя
        private void labelForClues_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            MessageBox.Show("Подсказка для учителя :) \r\n 1 уровень: а+1 \r\n 2 уровень: а+5 \r\n 3 уровeнь: а+15 " +
            "\r\n 4 уровень: а*2 \r\n 5 уровень: а*3 \r\n 6 уровень: а*2+1 \r\n 7 уровeнь: а*2-2\r\n 8 уровeнь: а/2" +
            "\r\n 9 уровeнь: а/2+1 \r\n 10 уровeнь: а в степени 2.");
        }
        //Руководство к игре
        private void руководствоToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Как играть в BlackBox:\r\n" +
                "1. Введите несколько чисел в левую белую колонку\r\n" +
                "(Не больше 4)начиная каждое число с новой строки\r\n" +
                "2. Нажмите на кнопку \"Считать\". Каждому числу с\r\n" +
                " левой коланки в правую будет записанно число,\r\n" +
                " результат работы алгоритма\r\n" +
                "3. Если вы догадались, какой алгоритм используется\r\n" +
                " для обработки числа, то нажмите на кнопку с\r\n" +
                " восклицательным Знаком\r\n" +
                "4. Перед вами появится окно для Ответа. В столбце \r\n" +
                "номер 1 записанно несколько чисел\r\n" +
                "5. Для того ,чтобы дать ответ , вам необходимо\r\n" +
                " обработать числа с столбцы 1 по алгоритму который\r\n" +
                " вы считаете верным и записать ответ в столбец 2,\r\n" +
                " каждый ответ должен находиться на против числа,для\r\n" +
                " ответа нажмите на кнопку между столбцами" +
                "6. Если ваш ответ верный, вам станет доступен\r\n" +
                " следующий уровень с другим, более сложным алгоритмом,\r\n" +
                " и так до тех пор, пока вы не пройдёте все уровни\r\n" +
                "*Для того, чтобы начать игру сначало, в верхнем меню\r\n" +
                " выберите пункт игра->Начать заново");
        }
    }
}
