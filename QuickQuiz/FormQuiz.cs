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

namespace QuickQuiz
{
    public partial class FormQuiz : Form
    {
        string mode = "";
        string quiz_filename = "quiz.txt";

        int total;//сколько всего вопросов
        string[] questions;
        string[,] answers;
        int current_nr;
        int correct_answers;

        static Random rand = new Random();
        int correct_radio_button_number;


        public FormQuiz()
        {
            InitializeComponent();
            
        }

        private void load_quiz ()
        {
            try
            {
                string[] lines = File.ReadAllLines(quiz_filename, Encoding.UTF8);
                total = lines.Length / 4;
                questions = new string[total]; // массив с количеством элементов равным количеству вопросов
                answers = new string[total, 3]; //масси ответов с тремя элементами на каждый вопрос
                for (int j = 0; j < total; j ++)//пройдем массив от нуля до последнего вопроса
                {
                    questions[j] = lines[j * 4]; //вопрос с номером j взять то что в файле lines
                    for (int k = 0; k < 3; k++)
                        answers[j, k] = lines[j * 4 + k + 1];
                }
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void show_quiz(int nr)
        {
            if (nr < 0 || nr >= total)
                return;
            int[] numbers = { 0, 1, 2 };
            for (int j = 0; j < 100; j ++)
            {
                int a = rand.Next(0, 3);
                int b = rand.Next(0, 3);
                int x = numbers[a];
                numbers[a] = numbers[b];
                numbers[b] = x;
            }
            correct_radio_button_number = Array.IndexOf(numbers, 0);

            label_question.Text = questions[nr];
            radio_answer0.Text = answers[nr, numbers[0]];
            radio_answer1.Text = answers[nr, numbers[1]];
            radio_answer2.Text = answers[nr, numbers[2]];
            radio_answer0.Checked = false;
            radio_answer1.Checked = false;
            radio_answer2.Checked = false;
        }

        private void FormQuiz_Shown(object sender, EventArgs e)
        {
            load_quiz();
            init_quiz();
        }

        private void init_quiz()
        {
            mode = "quiz";
            button_next.Text = "Следующий вопрос >>";
            radio_answer0.Visible = true;
            radio_answer1.Visible = true;
            radio_answer2.Visible = true;
            label_message.Text = "Всего будет " + total.ToString() + " вопросов";
            current_nr = 0;
            correct_answers = 0;
            show_quiz(current_nr);
        }
            
        

        private void button_next_Click(object sender, EventArgs e)
        {
            if (mode == "quiz")
            {
                if (!(radio_answer0.Checked ||
                  radio_answer1.Checked ||
                  radio_answer2.Checked))
                {
                    label_message.Text = "Необходимо выбрать вариант ответа!";
                    return;
                }
                label_message.Text = "";
                check_answer();
                if (current_nr + 1 < total)
                {
                    current_nr++;
                    show_quiz(current_nr);
                }
                else
                    calc_results();
            }
            else
                init_quiz();

            
        }

        private void check_answer ()
        {
            switch (correct_radio_button_number)
            {
                case 0 : if (radio_answer0.Checked)
                        correct_answers++;
                        break;
                case 1:  if (radio_answer1.Checked)
                        correct_answers++;
                    break;
                case 2:  if (radio_answer2.Checked)
                        correct_answers++;
                    break;
            }
            
        }

        private void calc_results ()
        {
            mode = "result";
            label_question.Text = "РЕЗУЛЬТАТЫ";
            radio_answer0.Visible = false;
            radio_answer1.Visible = false;
            radio_answer2.Visible = false;
            button_next.Text = "Повторить тест заново?";
            int result = (correct_answers * 100) / total;
            label_message.Text = "Вы набрали " + result.ToString() + "%";
        }
    }

}
