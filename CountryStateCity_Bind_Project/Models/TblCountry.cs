using System.ComponentModel.DataAnnotations;

namespace CountryStateCity_Bind_Project.Models
{
    public class TblCountry
    {
        [Key]
        public int CId { get; set; }
        public string CName { get; set; }
    }
}
