using System.ComponentModel.DataAnnotations;

namespace Pandologic.Entities
{
    public class Job
    {
        [Key]
        public int JobId { get; set; }
        public int JobTitleId { get; set; }
        public int CategoryId { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public int DescriptionLength { get; set; }
        public int EducationLevel { get; set; }
        public int Clicks { get; set; }
        public int Applicants { get; set; }
    }


}
