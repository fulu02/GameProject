using GameProject.Concrete;
using GameProject.Entity;
using System;
using System.Collections.Generic;

namespace GameProject
{
    class Program
    {
        static void Main(string[] args)
        {
			GamerManager gamerManager = new GamerManager(new UserValidationManager());
            Gamer gamer1 = new Gamer
            {
                Id = 1;
                BirthYear = 2001;
			    FirstName = "Fatma";
			    LastName = "Ulu";
			    IdentityNumber = 098765;
			}
			gamerManager.Add(gamer1);
			gamerManager.Delete(gamer1);
			gamerManager.Update(gamer1);

			Game game1 = new Game();
			game1.GameId = 1;
			game1.GameName = " FIFA 21 ";
			game1.GamePrice = 200;

			Game game2 = new Game();
			game2.GameId = 2;
			game2.GameName = " MineCraft ";
			game2.GamePrice = 50;

			GameManager gameManager = new GameManager();
            gameManager.Add(game1);
			gameManager.Update(game2);
			gameManager.Delete(game1);

			SalesManager sales1 = new SalesManager();
			sales1.Sell(gamer1, game1);
			sales1.Sell(gamer1, game2);

			Campaign campaign1 = new Campaign();
			campaign1.CampaignName = "Çocuk Bayramı";
			campaign1.CampaignId = 1;
			campaign1.Discount = 50;

			Campaign campaign2 = new Campaign();
			campaign2.CampaignName = "Bayram Kampanyası";
			campaign2.CampaignId = 2;
			campaign2.Discount = 40;

			CampaignManager campaignManager = new CampaignManager();

        public static int BirthYear { get; private set; }
        public static string FirstName { get; private set; }
        public static string LastName { get; private set; }
        public static int IdentityNumber { get; private set; }

        campaignManager.AddNewCampaign(campaign1);
			campaignManager.AddNewCampaign(campaign2);
			campaignManager.UpdateCampaignNewStruct;
			campaignManager.DeleteCampaign(campaign1);
			sales1.SellWithDiscount(gamer1, game1, campaign1);
			sales1.SellWithDiscount(gamer1, game2, campaign2);


		}

    internal struct NewStruct
    {
        public campaign1 Item1;
        public object Item2;

        public NewStruct(campaign1 ıtem1, object ıtem2)
        {
            Item1 = ıtem1;
            Item2 = ıtem2;
        }

        public override bool Equals(object obj)
        {
            return obj is NewStruct other &&
                   EqualityComparer<campaign1>.Default.Equals(Item1, other.Item1) &&
                   EqualityComparer<object>.Default.Equals(Item2, other.Item2);
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Item1, Item2);
        }

        public void Deconstruct(out campaign1 ıtem1, out object ıtem2)
        {
            ıtem1 = Item1;
            ıtem2 = Item2;
        }

        public static implicit operator (campaign1, object)(NewStruct value)
        {
            return (value.Item1, value.Item2);
        }

        public static implicit operator NewStruct((campaign1, object) value)
        {
            return new NewStruct(value.Item1, value.Item2);
        }
    }
}
}
