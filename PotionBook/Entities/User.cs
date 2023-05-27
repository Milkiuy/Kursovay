//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PotionBook.Entities
{
    using System;
    using System.Collections.Generic;
    
    public partial class User
    {
        public int id { get; set; }
        public string Surname { get; set; }
        public string Name { get; set; }
        public string Patronymic { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public int RoleID { get; set; }

        public string FIO 
        { 
            get
            {
                if (String.IsNullOrEmpty(Patronymic) || String.IsNullOrWhiteSpace(Patronymic))
                {
                    return Surname + " " + Name;
                }
                else
                {
                    return Surname + " " + Name + "\n" + Patronymic;
                }
            }
        }

        public string NameRole
        {
            get
            {
                return "Роль: " + Role.Name.ToString();
            }
        }
    
        public virtual Role Role { get; set; }
    }
}
