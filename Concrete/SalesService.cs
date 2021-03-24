using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Concrete
{
	public class SalesManager : ISalesService
	{
		public void Sell(Gamer gamer, Game game)
		{
			Console.WriteLine(gamer.FirstName + "  " + gamer.LastName + game.GameName +  " Satın Aldı. " + "  Ödenen Tutar: " + game.GamePrice + "  TL " + '\n');
		}

		public void SellWithDiscount(Gamer gamer, Game game, Campaign campaign)
		{
			Console.WriteLine(game.GameName + gamer.FirstName + gamer.LastName  + campaign.CampaignName + "   Kampanyası Üzerinden Satıldı ." + '\n');
		}
	}
}
