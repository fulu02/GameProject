using GameProject.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Abstract
{
    interface IUserValidationService
    {
        bool Validate(Gamer gamer);
    }
}
