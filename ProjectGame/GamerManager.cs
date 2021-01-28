using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectGame
{
    class GamerManager : IGamer
    {
       private IUserValidation  _userValidation;

        public GamerManager(IUserValidation userValidation)
        {
            _userValidation = userValidation;
        }

        public void Add(Gamer gamer)
        {
            if (_userValidation.Validate(gamer) == true)
            {
                Console.WriteLine(gamer.FirstName + " isimli kullanıcı doğrulandı ve kaydı oldu.");
            }
            else
            {
                Console.WriteLine("doğrulama başarısız"); ;
            }
            
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine("kayıt  silindi.");
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine("kayıt  güncellendi.");
        }
    }
}
