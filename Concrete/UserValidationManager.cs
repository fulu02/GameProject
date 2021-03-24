using GameProject.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Concrete
{
	public class UserValidationManager : IUserValidationService
	{
		public bool Validate(Gamer gamer)
		{
			if (gamer.BirthYear == 2001 && gamer.FirstName == "Fatma" && gamer.LastName == "Ulu" && gamer.IdNumber == 098765)
			{
				return true;
			}
			else
			{
				return false;
			}
		}
	}
}
