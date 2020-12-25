using System.ComponentModel.DataAnnotations;

namespace Pandologic.Entities
{
    public class JobTitle
    {
        [Key]
        public int JobTitleId { get; set; }
        public string JobTitleName { get; set; }
        public int CategoryId { get; set; }
    }


}
