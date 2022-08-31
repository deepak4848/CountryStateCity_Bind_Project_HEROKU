using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CountryStateCity_Bind_Project.Models
{
    public class TblUserCollection
    {
        public int User_Id { get; set; }

        public string User_Name { get; set; }
        public int User_Country { get; set; }
        public int User_State { get; set; }
        public int User_City { get; set; }
        public List<TblCountry> tblCountries { get; set; }
        public List<TblState> tblStates { get; set; }
        public List<TblCity> tblCities { get; set; }
    }
}
