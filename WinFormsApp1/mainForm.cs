using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CinemaARM
{
    /// <summary>
    /// Структура для хранении информации о месте в зале кинотеатра
    /// </summary>
    public struct Seat
    {
        //Ряд
        public int Row { get; }
        //Место
        public int Place { get; }
        //Конструктор
        public Seat(int _row = 0, int _place = 0)
        {
            Row = _row;
            Place = _place;
        }
    }
    /// <summary>
    /// Главное окно, в котором происходит покупка билетов.
    /// </summary>
    public partial class MainForm : Form
    {
        /// <summary>
        /// Список,хранящий все фильмы и сериалы.
        /// </summary>
        private List<Show> films = new List<Show>();
        /// <summary>
        /// Индекс выбранного покупателем фильма.
        /// </summary>
        private byte selected_film_index;
        /// <summary>
        /// Индекс сеанса, выбранного покупателем.
        /// </summary>
        private byte selected_session_index;
        /// <summary>
        /// Общая цена всех выбранных билетов.
        /// </summary>
        private int total_price;
        /// <summary>
        /// Общий доход за смену
        /// </summary>
        private double totalIncome;
        /// <summary>
        /// Корзина,куда помещаются выбранные места для покупки билетов.
        /// </summary>
        private List<Seat> basket = new List<Seat>();

        /// <summary>
        /// Конструктор формы.
        /// </summary>
        public MainForm(List<Show> shows)
        {
            InitializeComponent();
            //Получаем список показов в прокате
            films = shows;
            //Выводим название и жанр для каждого элемента films в showList 
            for (int i = 0; i < films.Count; i++)
            {
                showList.Items.Insert(i, films[i].Title + " | Жанр: " + films[i].Genre);
            }
        }
        /// <summary>
        /// Метод, вызываемый при выборе фильма, для отображения доступных сеансов.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void showList_SelectedIndexChanged(object sender, EventArgs e)
        {
            selected_film_index = (byte)showList.SelectedIndex;
            showList.Enabled = false; //Делаем недоступным поле с выбором фильма
            sessionList.Items.Clear(); //Очищаем выведенное прежде сеансы в sessionList
            //Для каждого сеанса выводим дату сеанса и цену билета
            for (int i = 0; i < films[showList.SelectedIndex].Sessions.Length; i++)
            {
                sessionList.Items.Insert(i, films[selected_film_index].Sessions[i].Session_date + " Цена билета:" + 
                                         films[selected_film_index].Sessions[i].Ticket_price + " рублей.");
            }
        }
        /// <summary>
        /// Метод, вызываемый при выборе сеанса для отображения мест в зале.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void sessionList_SelectedIndexChanged(object sender, EventArgs e) 
        {
            selected_session_index = (byte)sessionList.SelectedIndex;
            sessionList.Enabled = false; //Делаем недоступным поле с выбором сеанса
            print_seatsMatrix(); //Выводим места
        }
        /// <summary>
        /// Метод для визуализации мест в кинотеатре
        /// </summary>
        private void print_seatsMatrix()
        {
            seatsPanel.Controls.Clear(); //Очищаем отрисованые ранее кнопки
         
            int standart_space = 10; //Стандартный отступ от края
            int standart_between_space = 20; //Стандартный отступ между кнопками
            int button_size = 30; //Стандартный размер кнопки
            Button[,] _buttons = new Button[10, 10]; //Матрица кнопок, по размерам совпадающая с матрицей мест
            Label[] _lables = new Label[10];//

            //Создаем кнопки для визуализации мест
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    //Создаем новую кнопку
                    _buttons[i,j] = new Button();
                    _buttons[i, j].Width = button_size;
                    _buttons[i, j].Height = button_size;

                    //Проверяем доступно ли место для покупки. Если да - делаем кнопку зеленой,
                    //если нет - делаем кнопку серой и недоступной для нажатия
                    if (films[selected_film_index].Sessions[selected_session_index].Seats[i, j] == true)
                        _buttons[i, j].BackColor = Color.LightGreen;
                    else
                    {
                        _buttons[i, j].BackColor = Color.LightGray;
                        _buttons[i, j].Enabled = false; //Делаем кнопку недоступной для нажатия
                    }
                    _buttons[i, j].ForeColor = Color.Red;
                    //Задаем положение кнопки на поле seatsPanel
                    _buttons[i, j].Location = new Point(standart_space + i * standart_between_space + button_size * i,
                                                        standart_space + j * standart_between_space + button_size * j);
                    _buttons[i, j].Text = (i + 1).ToString(); //Делаем надпись с номером места на кнопке
                    //Добавляем кнопку на seatsPanel
                    seatsPanel.Controls.Add(_buttons[i, j]);

                    if (j == 9)
                    {
                        _lables[i] = new Label();
                        _lables[i].Width = 20;
                        _lables[i].Height = 20;
                        _lables[i].ForeColor = Color.Black;
                        _lables[i].Location = new Point(500, 17 + i * standart_between_space + button_size * i);
                        _lables[i].Text = (i + 1).ToString();
                        seatsPanel.Controls.Add(_lables[i]);
                    }
                }
            }
            //Добавляем каждой кнопке взаимодействие по клику
            foreach (Button btn in _buttons)
            {
                btn.Click += (b, eArgs) =>
                {
                    var button = (Button)b;
                    var button_j = ((button.Location.Y - 10) / (20 + button.Height)); //Вычисляем ряд места 
                    var button_i = ((button.Location.X - 10) / (20 + button.Width)); //Вычисляем номер места
                    //Добавляем выбранное место в корзину
                    basket.Add(new Seat(button_j, button_i));
                    //Меняем цвет кнопки на желтый и делаем ее недоступной для повторного выбора
                    button.BackColor = Color.Yellow;
                    button.Enabled = false;
                    //Выводим выбранное место на basketTextBox
                    basketTextBox.AppendText("Добавлен билет: ряд - " + (button_j + 1) + " ; место - " + (button_i + 1) + "\r\n");
                    //Добавляем стоимость места к общей стоимости билетов и выводим ее на totalCostTextBox
                    total_price += films[selected_film_index].Sessions[selected_session_index].Ticket_price;
                    totalCostTextBox.Clear();
                    totalCostTextBox.AppendText("Общая стоимость: " + total_price + " рублей.");
                };
            }
        }
        /// <summary>
        /// Метод для кнопки,отменяющей все выбранные позиции.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void returnButton_Click(object sender, EventArgs e)
        {
            returnAll();
        }
        /// <summary>
        /// Метод для кнопки, вызывающий покупку билетов и печать чека.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buyButton_Click(object sender, EventArgs e)
        {
            //Проверяем пуста ли корзина. Если пуста - выводим сообщение на экран. Иначе - покупаем билеты.
            if (!(basket.Count() == 0))
            {
                //Делаем недоступными для дальнейшей продажи все купленные билеты
                foreach (var ticket in basket)
                {
                    films[selected_film_index].Sessions[selected_session_index].sellTicket(ticket.Place, ticket.Row);
                }
                totalIncome += total_price;
                //Создаем форму для печчати текста и выводим ее
                CheckForm checkBox = new CheckForm(basket, films, selected_film_index, selected_session_index);
                checkBox.Show();
                //Очищаем все выбранные позиции.
                returnAll();
            }
            else
            {
                MessageBox.Show("Корзина пуста!");
            }
        }
        /// <summary>
        /// Метод очищающий все вспомогательные переменные и очищающий текстовые поля.
        /// </summary>
        public void returnAll()
        {
            //Очищаем вспомогательные переменные
            selected_film_index = 0;
            selected_session_index = 0;
            total_price = 0;
            //Очищаем корзину
            for (int i = 0; i < basket.Count; i++)
            {
                basket.RemoveAt(i);
                i--;
            }
            //Очищаем все поля
            sessionList.Items.Clear();
            seatsPanel.Controls.Clear();
            totalCostTextBox.Clear();
            basketTextBox.Clear();
            //Делаем доступными для выбора поля showList и sessionList
            showList.Enabled = true;
            sessionList.Enabled = true;
        }

        private void endButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Смена закрыта!\nДоход составил: " + totalIncome + " рублей.");
            Application.Exit();
        }
    }
}
