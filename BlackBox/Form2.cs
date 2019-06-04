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
    public partial class FormForAnswer : Form
    {
        public bool answerTruthCheck = true;
        Random Ran = new Random();
        double[] examples = new double[5];
        double[] answers = new double[5];
        public  double SelectedLevel2;

        void locationChange()
        {
            buttonForAnswer.Left = panelForAnswer.Width / 2 - buttonForAnswer.Width / 2;
            buttonForAnswer.Top = panelForAnswer.Height / 2 - buttonForAnswer.Height / 2;
            buttonAnotherNumbers.Left = panelForAnswer.Width / 2 - buttonAnotherNumbers.Width / 2;
            buttonAnotherNumbers.Top = buttonForAnswer.Top + buttonForAnswer.Height + 2;
            textBoxForExamples.Left = buttonForAnswer.Left - textBoxForExamples.Width - 20;
            textBoxForAnswers.Left = buttonForAnswer.Left + buttonForAnswer.Width + 20;
            textBoxForExamples.Top = buttonForAnswer.Top - textBoxForExamples.Height / 2 + buttonForAnswer.Height / 2;
            textBoxForAnswers.Top = buttonForAnswer.Top - textBoxForAnswers.Height / 2 + buttonForAnswer.Height / 2;
            label1.Left = textBoxForExamples.Left;
            label1.Top = textBoxForExamples.Top - label1.Height;
            label2.Left = textBoxForAnswers.Left;
            label2.Top = textBoxForAnswers.Top - label2.Height;
        }
        public FormForAnswer()           
        {
            InitializeComponent();
            locationChange();

        }
        private void FormForAnswer_Load(object sender, EventArgs e)
        {
            completionIfTexBoxExample();
        }

        
        private void FormForAnswer_SizeChanged(object sender, EventArgs e)
        {
            locationChange();
        }
        void completionIfTexBoxExample()
        {
            textBoxForAnswers.Text = null;
            textBoxForExamples.Text = null;
            double example;
            bool samecheck = true;
            for (int i = 0; i < examples.Length; i++)
            {
                example = Ran.Next(1, 25);
                //если рандомное число совпадет с уже имеющимися, то пропускаем его               
                {
                    for (int j = 0; j <= i; j++)
                        if (example == examples[j])
                        {
                            i--;
                            samecheck = false;
                            break;
                        }
                }
                if (samecheck)
                {
                    examples[i] = example;
                    textBoxForExamples.Text += (examples[i] + "\r\n");
                }
                samecheck = true;

            }
        }

        private void buttonForAnswer_Click(object sender, EventArgs e)
        {
            mainForm mainF = new mainForm();                    
            string[] stringAnswers = textBoxForAnswers.Text.Split('\n');
            try
            {
                for (int i = 0; i < answers.Length; i++)
                {
                    answers[i] = Convert.ToDouble(stringAnswers[i]);
                }
            }
            catch(FormatException)
            {
                MessageBox.Show("Вводите только цифры, без пустых строк между ними и для выделение целой части используйте запятую.");
            }
            catch (IndexOutOfRangeException)
            {
                MessageBox.Show(" дайте ответ на все числа, представленные в первой колонке.");
            }


            for (int i = 0; i < examples.Length; i++)
            {
                if (OutputLvl(examples[i]) != answers[i])
                {
                    //MessageBox.Show(Convert.ToString(OutputLvl(examples[i])));
                    answerTruthCheck = false;
                    break;
                }
            }
            
            if (answerTruthCheck)
            {
                buttonForAnswer.BackColor = Color.GreenYellow;
                MessageBox.Show("Праильно :)");
                this.Close();               
            }
            else
            {
                buttonForAnswer.BackColor = Color.Red;
                MessageBox.Show("Не правильно :(");
                textBoxForAnswers.Text = null;
                answerTruthCheck = true;
            }
          
        }

        private double OutputLvl(double input)
        {
            //для каждого уровня своё возвращаемое число
            switch (SelectedLevel2)
            {
                case 1:
                    {
                        return (input + 1);
                    }

                case 2:
                    {
                        return (input + 5);
                    }

                case 3:
                    {
                        return (input + 15);
                    }

                case 4:
                    {
                        return (input * 2);
                    }

                case 5:
                    {
                        return (input * 3);
                    }

                case 6:
                    {
                        return (input * 2 + 1);
                    }

                case 7:
                    {
                        return (input * 2 - 2);
                    }

                case 8:
                    {
                        return (input / 2);
                    }

                case 9:
                    {
                        return (input / 2 + 1);
                    }
                case 10:
                    {
                        return Math.Pow(input, 2);
                    }

            }
            return 0;
        }

        private void buttonAnotherNumbers_Click(object sender, EventArgs e)
        {
            textBoxForExamples.Text = null;

        }
    }
}
