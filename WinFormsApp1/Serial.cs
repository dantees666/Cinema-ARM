﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;

namespace CinemaARM
{
    /// <summary>
    /// Класс для работы с сериалами
    /// </summary>
    public class Serial : Show
    {
        /// <summary>
        /// Количество серий в сериале.
        /// </summary>
        public int Count_of_series { get; set; }
        /// <summary>
        /// Длительность сеанса в минутах.
        /// </summary>
        public int Serial_duration { get; set; }
        /// <summary>
        /// Массив сеансов.
        /// Количество сериалов по умолчанию - 2.
        /// </summary>
        public Session[] sessions { get; set; } = new Session[2];
        /// <summary>
        /// Конструктор для Serial.
        /// </summary>
        /// <param name="title"></param>
        /// <param name="genre"></param>
        /// <param name="age_limit"></param>
        /// <param name="hall"></param>
        /// <param name="count_of_series"></param>
        /// <param name="serial_duration"></param>
        //Конструктор без параметров для сериализации
        public Serial() { }
        public Serial(string title = "",
                      string genre = "",
                      int age_limit = 0,
                      int hall = 0,
                      int count_of_series = 0,
                      int serial_duration = 0) : base(title, genre, age_limit, hall)
        {
            Count_of_series = count_of_series;
            Serial_duration = serial_duration;
            fill_in_sessions();
        }

        public override Session[] Sessions
        {
            get { return sessions; }
        }
        protected override void fill_in_sessions()
        {
            DateTime session_time = new DateTime(2021, 8, 8, 9, 0, 0);
            DateTime default_session_time = new DateTime(2021, 8, 8, 9, 0, 0);
            int ticket_price = 150;
            for (int i = 0; i < sessions.Length; i++) //Заполняем сенасы по умолчанию. Цена билета зависит от времени сеанса.
            {
                if (session_time < default_session_time.AddHours(3))
                    ticket_price = 150;
                else if (session_time >= default_session_time.AddHours(9))
                    ticket_price = 350;                                            
                sessions[i] = new Session(ticket_price, session_time);
                session_time = session_time.AddHours(10);
            }
        }
        //Сериализация
        public override string serializeShow()
        {
            return JsonSerializer.Serialize<Serial>(this);
        }
    }
}
