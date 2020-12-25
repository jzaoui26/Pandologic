using Pandologic.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Pandologic.Contracts
{
    public interface IJobTitleManager
    {

        List<JobTitle> ListSearch(string search);
    }
}
