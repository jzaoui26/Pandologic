using Pandologic.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Pandologic.Contracts
{
    public interface IJobManager
    {
        List<Job> ListSearch(int JobTitleId);
    }
}
