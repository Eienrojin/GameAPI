using System;
namespace GameAPI
{
	public class Word
	{
        public Word(int id, string russian, string english)
        {
            Id = id;
            Russian = russian;
            English = english;
        }

        public Word()
        {

        }

        public int Id { get; set; }
		public string Russian { get; set; }
        public string English { get; set; }
    }
}

