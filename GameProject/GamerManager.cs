using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject
{
    //Bir manager sınıfı içerisinde başka bir manager sınıfı kullanılacaksa onu new'leme. 
    //onun yerine constructor oluşturmak daha mantıklıdır. 
    
    class GamerManager : IGamerService //İnterfaceleri implemente(uygulamak doldurmak) edebilmek için somut sınıf yazılır. 
    {
        IUserValidationService _userValidationService; // Constructor oluşturulur.

        public GamerManager(IUserValidationService userValidationService)
        {
            _userValidationService = userValidationService;
        }

        public void Add(Gamer gamer)
        {
            if (_userValidationService.Validate(gamer)==true)
            {
                Console.WriteLine("Kayıt oldu");
            }
            else
            {
                Console.WriteLine("Doğrulama Başarısız");
            }
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine("Kayıt silindi");
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine("Kayıt güncellendi");
        }
    }
}
