
using System.ComponentModel.DataAnnotations;

namespace BackSaludMigrantes.Models.Entities
{
    
    public class Location
    {
        public int LocationId { set; get; }
        public List<MigrantsStatements> MigrantsStatementsLoc { get; set; }
        public string LocationName { get; set; }
    }
}
