using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BackSaludMigrantes.Models.Entities
{
  
    public class MigrantsStatements
    {
        public string DataSISBEN { get; set; }

        public string Direction { get; set; }

        public int Mobile { get; set; }

        public Location Location { get; set; }
       
        public int LocationId { get; set; }

        public DateTime StatamentsDate { get; set; }

        public DateTime ValidityDate { get; set; }

        public string latitude { get; set; }

        public string longitude { get; set; }
    }
}
