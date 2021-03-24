using GameProject.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Abstract
{
    public interface ISalesService
    {
        void Sell(Gamer gamer, Game game);
        void SellWithDiscount(Gamer gamer, Game game, Campaign campaign);

    }
}
