using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Text.Json;

namespace CinemaARM
{
    public partial class InterForm : Form
    {
        //Список показов
        private List<Show> shows = new List<Show>();

        public InterForm()
        {
            InitializeComponent();
            //Выводим,что в данный момент не добавлено ни одного показа
            countBox.Text = shows.Count.ToString();
        }
        
        //Функия,вызываемая при выборе типа показа. Отрисовывает необходимые для заполнения поля,
        //в соответствии с типом показа
        private void seanseType_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton seanseType = (RadioButton)sender;
            if(seanseType.Checked)
            {
                if(seanseType.TabIndex == 1)
                {
                    Label[] lables = new Label[5];
                    TextBox[] textBoxes = new TextBox[5];

                    data_Panel.Controls.Clear(); 

                    lables[0] = new Label();
                    lables[0].Text = "Введите название фильма:";
                    lables[0].AutoSize = true;
                    lables[0].Location = new Point(5, 10);
                    data_Panel.Controls.Add(lables[0]);

                    textBoxes[0] = new TextBox();
                    textBoxes[0].Location = new Point(10, 30);
                    textBoxes[0].Width = 178;
                    data_Panel.Controls.Add(textBoxes[0]);

                    lables[1] = new Label();
                    lables[1].Text = "Введите жанр фильма:";
                    lables[1].AutoSize = true;
                    lables[1].Location = new Point(5, 60);
                    data_Panel.Controls.Add(lables[1]);

                    textBoxes[1] = new TextBox();
                    textBoxes[1].Location = new Point(10, 80);
                    textBoxes[1].Width = 178;
                    data_Panel.Controls.Add(textBoxes[1]);

                    lables[2] = new Label();
                    lables[2].Text = "Введите возрастное ограничение:";
                    lables[2].AutoSize = true;
                    lables[2].Location = new Point(5, 110);
                    data_Panel.Controls.Add(lables[2]);
                    
                    textBoxes[2] = new TextBox();
                    textBoxes[2].Location = new Point(10, 130);
                    textBoxes[2].Width = 178;
                    data_Panel.Controls.Add(textBoxes[2]);

                    lables[3] = new Label();
                    lables[3].Text = "Введите зал:";
                    lables[3].AutoSize = true;
                    lables[3].Location = new Point(5, 160);
                    data_Panel.Controls.Add(lables[3]);

                    textBoxes[3] = new TextBox();
                    textBoxes[3].Location = new Point(10, 180);
                    textBoxes[3].Width = 178;
                    data_Panel.Controls.Add(textBoxes[3]);

                    lables[4] = new Label();
                    lables[4].Text = "Введите длительность фильма:";
                    lables[4].AutoSize = true;
                    lables[4].Location = new Point(5, 210);
                    data_Panel.Controls.Add(lables[4]);

                    textBoxes[4] = new TextBox();
                    textBoxes[4].Location = new Point(10, 230);
                    textBoxes[4].Width = 178;
                    data_Panel.Controls.Add(textBoxes[4]);
                }
                if (seanseType.TabIndex == 2)
                {
                    Label[] lables = new Label[6];
                    TextBox[] textBoxes = new TextBox[6];

                    data_Panel.Controls.Clear();

                    lables[0] = new Label();
                    lables[0].Text = "Введите название сериала:";
                    lables[0].AutoSize = true;
                    lables[0].Location = new Point(5, 10);
                    data_Panel.Controls.Add(lables[0]);

                    textBoxes[0] = new TextBox();
                    textBoxes[0].Location = new Point(10, 30);
                    textBoxes[0].Width = 178;
                    data_Panel.Controls.Add(textBoxes[0]);

                    lables[1] = new Label();
                    lables[1].Text = "Введите жанр сериала:";
                    lables[1].AutoSize = true;
                    lables[1].Location = new Point(5, 60);
                    data_Panel.Controls.Add(lables[1]);

                    textBoxes[1] = new TextBox();
                    textBoxes[1].Location = new Point(10, 80);
                    textBoxes[1].Width = 178;
                    data_Panel.Controls.Add(textBoxes[1]);

                    lables[2] = new Label();
                    lables[2].Text = "Введите возрастное ограничение:";
                    lables[2].AutoSize = true;
                    lables[2].Location = new Point(5, 110);
                    data_Panel.Controls.Add(lables[2]);

                    textBoxes[2] = new TextBox();
                    textBoxes[2].Location = new Point(10, 130);
                    textBoxes[2].Width = 178;
                    data_Panel.Controls.Add(textBoxes[2]);

                    lables[3] = new Label();
                    lables[3].Text = "Введите зал:";
                    lables[3].AutoSize = true;
                    lables[3].Location = new Point(5, 160);
                    data_Panel.Controls.Add(lables[3]);

                    textBoxes[3] = new TextBox();
                    textBoxes[3].Location = new Point(10, 180);
                    textBoxes[3].Width = 178;
                    data_Panel.Controls.Add(textBoxes[3]);

                    lables[4] = new Label();
                    lables[4].Text = "Введите количество серий:";
                    lables[4].AutoSize = true;
                    lables[4].Location = new Point(5, 210);
                    data_Panel.Controls.Add(lables[4]);

                    textBoxes[4] = new TextBox();
                    textBoxes[4].Location = new Point(10, 230);
                    textBoxes[4].Width = 178;
                    data_Panel.Controls.Add(textBoxes[4]);

                    lables[5] = new Label();
                    lables[5].Text = "Введите длительность сериала:";
                    lables[5].AutoSize = true;
                    lables[5].Location = new Point(5, 260);
                    data_Panel.Controls.Add(lables[5]);

                    textBoxes[5] = new TextBox();
                    textBoxes[5].Location = new Point(10, 280);
                    textBoxes[5].Width = 178;
                    data_Panel.Controls.Add(textBoxes[5]);
                }
            }
        }

        private void add_Button_Click(object sender, EventArgs e)
        {
            //Проверяем заполнены ли все поля
            foreach (Control c in data_Panel.Controls)
                if (c is TextBox)
                    if (c.Text == "")
                    {
                        MessageBox.Show("Вы не заполнили все поля!");
                        return;
                    }

            //Если выбран фильм, проверяем правильно ли заполнены все поля. Если да - добавляем в список показов.
            if(filmButton.Checked)
            {
                int temp;
                if (!Int32.TryParse(data_Panel.Controls[5].Text, out temp) || !Int32.TryParse(data_Panel.Controls[7].Text, out temp)
                    || !Int32.TryParse(data_Panel.Controls[9].Text, out temp))
                {
                    MessageBox.Show("Вы ввели неправильные данные! Проверьте правильность ввода!");
                    return;
                }

                shows.Add(new Film(data_Panel.Controls[1].Text, data_Panel.Controls[3].Text,
                    int.Parse(data_Panel.Controls[5].Text), int.Parse(data_Panel.Controls[7].Text),
                    int.Parse(data_Panel.Controls[9].Text)));
            }

            //Если выбран сериал, проверяем правильно ли заполнены все поля. Если да - добавляем в список показов.
            if (serialButton.Checked)
            {
                int temp;
                if (!Int32.TryParse(data_Panel.Controls[5].Text, out temp) || !Int32.TryParse(data_Panel.Controls[7].Text, out temp)
                    || !Int32.TryParse(data_Panel.Controls[9].Text, out temp) || !Int32.TryParse(data_Panel.Controls[11].Text, out temp))
                {
                    MessageBox.Show("Вы ввели неправильные данные! Проверьте правильность ввода!");
                    return;
                }

                shows.Add(new Serial(data_Panel.Controls[1].Text, data_Panel.Controls[3].Text,
                    int.Parse(data_Panel.Controls[5].Text), int.Parse(data_Panel.Controls[7].Text),
                    int.Parse(data_Panel.Controls[9].Text), int.Parse(data_Panel.Controls[11].Text)));
            }

            if(!serialButton.Checked && !filmButton.Checked)
            {
                MessageBox.Show("Выберите тип показа!");
                return;
            }

            countBox.Text = shows.Count.ToString();
            clearAll();
        }
        //При нажатии кнопки "Готово", вызывается основная форма,в которую передается список показов.
        private void start_Button_Click(object sender, EventArgs e)
        {
            //При переходе в основную форму десериализуем объекты прошлого запуска
            StreamReader sw = File.OpenText("TestWrite.json");
            string line;

            while ((line = sw.ReadLine()) != null)
            {
                if (line.Contains("Count_of_series"))
                    shows.Add(JsonSerializer.Deserialize<Serial>(line));
                else
                    shows.Add(JsonSerializer.Deserialize<Film>(line));
            }
            sw.Close();

            Hide();
            MainForm f = new MainForm(shows);
            f.ShowDialog();
            this.Close();
        }
        //Кнопка очищает все введенные данные
        private void return_Button_Click(object sender, EventArgs e)
        {
            clearAll();
        }

        private void clearAll()
        {
            data_Panel.Controls.Clear();
            filmButton.Checked = false;
            serialButton.Checked = false;
        }
        //Кнопка очищает данные прошлого запуска
        private void clearData_Button_Click(object sender, EventArgs e)
        {
            File.WriteAllText("TestWrite.json", string.Empty);
            MessageBox.Show("Данные прошлого запуска удалены!");
        }
    }
}
