using System;
using System.Collections.Generic;
using System.Text;

namespace CinemaARM
{
    /// <summary>
    /// Класс для работы с сеансами.
    /// </summary>
    public class Session
    {
        /// <summary>
        /// Цена билета.
        /// </summary>
        private int ticket_price;
        /// <summary>
        /// Дата сеанса.
        /// </summary>
        private DateTime session_date;
        /// <summary>
        /// Матрица мест.
        /// </summary>
        private bool[,] seats = new bool[10, 10];
        /// <summary>
        /// Конструктор для Session.
        /// </summary>
        /// <param name="ticket_price"></param>
        /// <param name="session_time"></param>
        public Session(int ticket_price = 0,
                       DateTime session_time = default(DateTime))
        {
            Session_date = session_time;
            Ticket_price = ticket_price;
            for (int i = 0; i < seats.Length / 10; i++) // Делаем все места по умолчанию свободными.
                for (int j = 0; j < seats.Length / 10; j++)
                    seats[i, j] = true;
        }

        public int Ticket_price
        {
            get { return ticket_price; }
            private set { ticket_price = value; }
        }
        public DateTime Session_date
        {
            get { return session_date; }
            private set { session_date = value; }
        }

        public bool[,] Seats
        {
            get { return seats; }
        }
        /// <summary>
        /// Метод устанавливает значение false для выбранного элемента seats.
        /// </summary>
        /// <param name="place"> Место </param> 
        /// <param name="row"> Ряд </param>
        public void sellTicket(int place, int row)
        {
            seats[place,row] = false;
        }

    }
}
