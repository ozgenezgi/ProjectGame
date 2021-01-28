using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectGame
{
    class ValidationManager : IUserValidation
    {
        public bool Validate(Gamer gamer)
        {
            if(gamer.FirstName == "Ezgi" && gamer.LastName == "özgen" && gamer.IdentityNumber == 12345)
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
