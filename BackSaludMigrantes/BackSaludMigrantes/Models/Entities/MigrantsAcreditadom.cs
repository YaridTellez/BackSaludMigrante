using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace BackSaludMigrantes.Models.Entities
{
  
    public class MigrantsAcreditadom
    {
        public int MigrantId { get; set; }

        public string TypeDoc { get; set; }

        public string DocNum { get; set; }

        public string Surname { get; set; }
        
        public string SecondSurname { get; set; }
       
        public string FirstName { get; set; }
                
        public string SecondName { get; set; }

        public DateTime BirthDate { get; set; }
        public string MigrantsStatementsFile { get; set; }

        public string LocationName { get; set; }      

        public string Relationship { get; set; }

        public string Direction { get; set; }

        public bool Nucleo { get; set; } 

    }
}
