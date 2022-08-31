using System.ComponentModel.DataAnnotations;

namespace CountryStateCity_Bind_Project.Models
{
    public class TblState
    {
        [Key]
        public int SId { get; set; }
        public int CId { get; set; }
        public string SName { get; set; }
    }
}
