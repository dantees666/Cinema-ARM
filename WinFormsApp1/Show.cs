using System;
using System.Collections.Generic;
using System.Text;

namespace CinemaARM
{
    /// <summary>
    /// Абстрактный класс,являющийся базовым для фильмов и сериалов, хранящий общую информацию о них.
    /// </summary>
    public abstract class Show
    {
        /// <summary>
        /// Название фильма или сериала.
        /// </summary>
        protected string title; 
        /// <summary>
        /// Жанр фильма или сериала.
        /// </summary>
        protected string genre;
        /// <summary>
        /// Возрастное ограничение фильма или сериала.
        /// </summary>
        protected int age_limit;
        /// <summary>
        /// Зал, в котором производится показ.
        /// </summary>
        protected int hall;
        /// <summary>
        /// Минимальная цена билета.
        /// </summary>
        protected const int minimal_ticket_price = 150;
        /// <summary>
        /// Конструктор для Show.
        /// </summary>
        /// <param name="title"></param>
        /// <param name="genre"></param>
        /// <param name="age_limit"></param>
        /// <param name="hall"></param>
        public Show(string title = "",
                    string genre = "",
                    int age_limit = 0,
                    int hall = 0)
        {
            Title = title;
            Genre = genre;
            Age_limit = age_limit;
            Hall = hall;
        }

        public string Title
        {
            get { return title; }
            private set { title = value; }
        }
        public string Genre
        {
            get { return genre; }
            private set { genre = value; }
        }
        public int Age_limit
        {
            get { return age_limit; }
            private set { age_limit = value; }
        }

        public int Hall
        {
            get { return hall; }
            private set { hall = value; }
        }
        /// <summary>
        /// Метод, возвращающий массив сеансов данного фильма или сериала.
        /// </summary>
        public abstract Session[] Sessions { get; }

        /// <summary>
        /// Функция для автозаполенния сеансов.
        /// </summary>
        protected abstract void fill_in_sessions();
    }
}
