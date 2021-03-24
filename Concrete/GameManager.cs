using GameProject.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Concrete
{
	public class GameManager : IGameService
	{
		public void Add(Game game)
		{
			Console.WriteLine(game.GameName + "oyunu eklendi...");
		}

		public void Delete(Game game)
		{
			Console.WriteLine(game.GameName + "Silindi.");
		}

		public void Update(Game game)
		{
			Console.WriteLine(game.GameName + "Yenilendi.");
		}
	}
}