using Pandologic.Contracts;
using Pandologic.Entities;
using Dapper;
using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;

namespace Pandologic.Concrete
{
    public class JobManager : IJobManager
    {
        private readonly IDapperManager _dapperManager;

        public JobManager(IDapperManager dapperManager)
        {
            this._dapperManager = dapperManager;
        }


        public List<Job> ListSearch(int JobTitleId)
        {
            var jobs = _dapperManager.GetAll<Job>
                ($"SELECT * FROM [Test_Jobs] WHERE JobId IN " +
                    $"(SELECT MIN(JobId) as JobId FROM [Test_Jobs] as tj WHERE tj.JobId = JobId AND JobTitleId = {JobTitleId} GROUP BY tj.City)" +
                $" ORDER BY City"
               , null, commandType: CommandType.Text);
                
            return jobs;
        }


    }
}
