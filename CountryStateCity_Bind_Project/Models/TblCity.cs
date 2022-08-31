using System.ComponentModel.DataAnnotations;

namespace CountryStateCity_Bind_Project.Models
{
    public class TblCity
    {
        [Key]
        public int DId { get; set; }
        public int SId { get; set; }
        public string DName { get; set; }
    }
}
