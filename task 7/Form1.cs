using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace task_7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            char[] correctAnswers = { 'B', 'D', 'A', 'A', 'C', 'A', 'B', 'A', 'C', 'D',
                                  'B', 'C', 'D', 'A', 'D', 'C', 'C', 'B', 'D', 'A' };
            string[] lines = File.ReadAllLines("studentAnswers.txt");
            char[] studentAnswers = lines[0].ToUpper().ToCharArray();

            int correctCount = 0;
            string wrongQuestions = "";

            for (int i = 0; i < correctAnswers.Length; i++)
            {
                if (studentAnswers[i] == correctAnswers[i])
                {
                    correctCount++;
                }
                else
                {
                    wrongQuestions += (i + 1) + " ";
                }
            }

            string result = correctCount >= 15 ? "Pass" : "Fail";
            label2.Text = result + " - Correct: " + correctCount + ", Incorrect: " + (20 - correctCount);
            label3.Text = "Incorrect Questions: " + wrongQuestions;
        }
    }
}
