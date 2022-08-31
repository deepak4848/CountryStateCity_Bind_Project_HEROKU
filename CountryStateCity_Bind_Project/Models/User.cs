using System.ComponentModel.DataAnnotations;

namespace CountryStateCity_Bind_Project.Models
{
    public class User
    {
        [Key]
        public int User_Id { get; set; }

        public string User_Name { get; set; }
        public int User_Country { get; set; }
        public int User_State { get; set; }
        public int User_City { get; set; }  
    }
}
