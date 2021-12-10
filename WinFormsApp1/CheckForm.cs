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
    /// <summary>
    /// Вспомогательная форма,для печати чека.
    /// </summary>
    public partial class CheckForm : Form
    {
        //Фиксированное число решеток для отрисовки
        public const int sharpCount = 50;
        /// <summary>
        /// Конструктор формы.
        /// </summary>
        /// <param name="basket"></param>
        /// <param name="films"></param>
        /// <param name="selected_film_index"></param>
        /// <param name="selected_session_index"></param>
        public CheckForm(List<Seat> basket,
                         List<Show> films,
                         int selected_film_index,
                         int selected_session_index)
        {
            InitializeComponent();
            //Отрисовывем декоративную верхнюю часть чека
            for (int i = 0; i < sharpCount; i++)
                checkTextBox.AppendText("#");
            checkTextBox.AppendText("\r\n");
            checkTextBox.AppendText("#");
            for (int i = 0; i < 49; i++)
            {
                checkTextBox.AppendText(" ");
            }
            checkTextBox.AppendText(" Чек ");
            for (int i = 0; i < 52; i++)
            {
                checkTextBox.AppendText(" ");
            }
            checkTextBox.AppendText("#\r\n");
            for (int i = 0; i < sharpCount; i++)
                checkTextBox.AppendText("#");
            checkTextBox.AppendText("\r\n");
            //Выводим информацию о приобретенных билетах
            foreach (var ticket in basket)
            {
                checkTextBox.AppendText("Название: " + films[selected_film_index].Title + "\r\n");
                checkTextBox.AppendText("Жанр: "  + films[selected_film_index].Genre + "\r\n");
                checkTextBox.AppendText("Возрастное ограничение: " + films[selected_film_index].Age_limit + "+\r\n");
                checkTextBox.AppendText("Время сеанса: " + films[selected_film_index].Sessions[selected_session_index].Session_date + "\r\n");
                checkTextBox.AppendText("Зал: " + films[selected_film_index].Hall + "\r\n");
                checkTextBox.AppendText("Билет: Ряд: " + (ticket.Row + 1) + " Место: " + (ticket.Place + 1) + "\r\n");
                checkTextBox.AppendText("Цена билета: " + films[selected_film_index].Sessions[selected_session_index].Ticket_price + "\r\n");
                for (int i = 0; i < sharpCount; i++)
                    checkTextBox.AppendText("#");
                checkTextBox.AppendText("\r\n");
            }
        }
        /// <summary>
        /// Метод для кнопки,закрывающей окно печати чека.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void confirmButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
