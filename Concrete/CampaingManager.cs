using GameProject.Abstract;
using GameProject.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Concrete
{
	public class CampaignManager : ICampaignService
	{
		public void AddNewCampaign(Campaign campaign)
		{
			Console.WriteLine(campaign.CampaignName + "Eklendi");
		}



		public void DeleteCampaign(Campaign campaign)
		{
			Console.WriteLine(campaign.CampaignName + "Silindi");
		}


		public void UpdateCampaign(Campaign campaign)
		{
			Console.WriteLine(campaign.CampaignName + " Yenilendi");
		}

	 }
}
    
