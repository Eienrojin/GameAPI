using System;
namespace GameAPI
{
	public class User
	{
		public User()
		{

		}

        public User(int id, string name, string password, int stars)
        {
            Id = id;
            Name = name;
            Password = password;
            Stars = stars;
        }

        public int Id { get; set; }
		public string Name { get; set; }
		public string Password { get; set; }
		public int Stars { get; set; }
	}
}

