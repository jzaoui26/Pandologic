using Pandologic.Contracts;
using Pandologic.Entities;
using Dapper;
using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;

namespace Pandologic.Concrete
{
    public class JobTitleManager : IJobTitleManager
    {
        private readonly IDapperManager _dapperManager;

        public JobTitleManager(IDapperManager dapperManager)
        {
            this._dapperManager = dapperManager;
        }


        public List<JobTitle> ListSearch(string search)
        {
            var jobTitles = _dapperManager.GetAll<JobTitle>
                ($"SELECT * FROM [Test_JobTitles] WHERE JobTitleName like '{search}%'", null, commandType: CommandType.Text);
                
            return jobTitles;
        }


    }
}
