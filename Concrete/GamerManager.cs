using GameProject.Abstract;
using GameProject.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Concrete
{
	public class GamerManager : IGamerService
	{
		IUserValidationService _userValidationService;
		private UserValidationManager userValidationManager;

        public GamerManager(IUserValidationService userValidationService)
        {
            _userValidationService = userValidationService;
        }

        public GamerManager(UserValidationManager userValidationManager)
		{
			this.userValidationManager = userValidationManager;
		}

		public void Add(Gamer gamer)
		{
			if (_userValidationService.Validate(gamer) == true)
			{
				Console.WriteLine(gamer.FirstName + "  " + gamer.LastName + " Kayıt Oldu.");
			}
			else
			{
				Console.WriteLine("Kayıt Başarısız .");
			}
		}

		public void Delete(Gamer gamer)
		{
			Console.WriteLine(gamer.FirstName + "  " + gamer.LastName + " Kayıt Silindi.");
		}

		public void Update(Gamer gamer)
		{
			Console.WriteLine(gamer.FirstName + "  " + gamer.LastName + " Kayıt Yenilendi.");
		}
	}
}