using Microsoft.EntityFrameworkCore;
using UniversityManagementSystem.Infrustructure.Abstracts.Functions;
using UniversityManagementSystem.Infrustructure.Data;
using System.Data;

namespace UniversityManagementSystem.Infrustructure.Repositories.Functions
{
    public class InstructorFunctionsRepository : IInstructorFunctionsRepository
    {
        // Fileds
        private readonly ApplicationDBContext _dbContext;
        /*******************************************************************************************/
        // Constructors
        public InstructorFunctionsRepository(ApplicationDBContext dbContext)
        {
            _dbContext = dbContext;
        }

        /*******************************************************************************************/
        // Handle Functions
        public decimal GetSalarySummationOfInstructor(string query)
        {
            using (var cmd = _dbContext.Database.GetDbConnection().CreateCommand())
            {
                if (cmd.Connection.State!=ConnectionState.Open)
                {
                    cmd.Connection.Open();
                }

                //read From List

                //  var reader = await cmd.ExecuteReaderAsync();
                // var value = await reader.ToListAsync<GetInstructorFunctionResult>();

                decimal response = 0;
                cmd.CommandText = query;
                var value = cmd.ExecuteScalar();
                var result = value.ToString();
                if (decimal.TryParse(result, out decimal d))
                {
                    response= d;
                }
                cmd.Connection.Close();
                return response;
            }
        }
        /*******************************************************************************************/
    }
}
