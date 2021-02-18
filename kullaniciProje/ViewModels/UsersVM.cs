using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace kullaniciProje.ViewModels
{
    public class UsersVM
    {
        public int Id { get; set; }
        public string K_Ad { get; set; }
        public string Ad_Soyad { get; set; }
        public string Sifre { get; set; }
        public string Grup { get; set; }
        public string K_Tur { get; set; }
    }

    public class UsersListVM
    {
        public List<UsersVM> users { get; set; }
    }
}