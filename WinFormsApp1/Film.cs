using System;
using System.Collections.Generic;
using System.Text;

namespace CinemaARM
{
    /// <summary>
    /// Клас, для работы с фильмами.
    /// </summary>
    public class Film : Show
    {
        /// <summary>
        /// Длительность фильма в минутах.
        /// </summary>
        private int film_duration;
        /// <summary>
        /// Массив сеансов для фильма.
        /// По умолчанию количество сеансов - 5.
        /// </summary>
        private Session[] sessions = new Session[5];
        /// <summary>
        /// Конструктор для Film.
        /// </summary>
        /// <param name="title"></param>
        /// <param name="genre"></param>
        /// <param name="age_limit"></param>
        /// <param name="hall"></param>
        /// <param name="film_duration"></param>
        public Film(string title = "",
                    string genre = "",
                    int age_limit = 0,
                    int hall = 0,
                    int film_duration = 0) : base(title, genre, age_limit, hall)
        {
            Film_duration = film_duration;
            fill_in_sessions();
        }
        public int Film_duration
        {
            get { return film_duration; }
            private set { film_duration = value; }
        }

        public override Session[] Sessions
        {
            get { return sessions;  }
        }

        protected override void fill_in_sessions()
        {
            DateTime session_time = new DateTime(2021, 8, 8, 9, 0, 0);
            DateTime default_session_time = new DateTime(2021, 8, 8, 9, 0, 0);
            int ticket_price = minimal_ticket_price;

            for (int i = 0; i < sessions.Length; i++)  //Заполняем сенасы по умолчанию. Цена билета зависит от времени сеанса.
            {
                if (session_time < default_session_time.AddHours(3))
                    ticket_price = 150;
                else if ((session_time < default_session_time.AddHours(9)) && (session_time >= default_session_time.AddHours(3)))
                    ticket_price = 250;
                else if (session_time >= default_session_time.AddHours(9))
                    ticket_price = 350;                                         
                sessions[i] = new Session(ticket_price, session_time);
                session_time = session_time.AddHours(3);
            }
        }
    }
}
