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
    //Внимание!!!! Проест очень очень сырой большинсто исключений не обработоно. Не старайтесь сломать программу, я вам говрю:у вас это получится!!!
    //Внимание!!!! Проест очень очень сырой большинсто исключений не обработоно. Не старайтесь сломать программу, я вам говрю:у вас это получится!!!
    public partial class mainForm : Form
    {
        //лист входных данных
        List<string> listOfIntput = new List<string>();
         static int SelectedLevel = 1;
         public bool answerTruthCheck = false;



        public mainForm()           
        {
            InitializeComponent();
            buttonToAnswer.Left = panelMain.Width / 2 - buttonToAnswer.Width/2;
            buttonToAnswer.Top = panelMain.Height / 2-buttonToAnswer.Height/2;
            textBoxInput.Left = buttonToAnswer.Left - textBoxInput.Width - 20;
            textBoxOutput.Left = buttonToAnswer.Left + buttonToAnswer.Width + 20;
            textBoxInput.Top = buttonToAnswer.Top;
            textBoxOutput.Top = buttonToAnswer.Top;
           
           
        }
        
        private double OutputLvl(string input)
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
                        return Convert.ToDouble(input) *2; 
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
            buttonToAnswer.Left = panelMain.Width / 2 - buttonToAnswer.Width / 2;
            buttonToAnswer.Top = panelMain.Height / 2 - buttonToAnswer.Height / 2;
            textBoxInput.Left = buttonToAnswer.Left - textBoxInput.Width - 20;
            textBoxOutput.Left = buttonToAnswer.Left + buttonToAnswer.Width + 20;
            textBoxInput.Top = buttonToAnswer.Top;
            textBoxOutput.Top = buttonToAnswer.Top;
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
    }
}
