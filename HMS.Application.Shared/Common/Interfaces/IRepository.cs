using HMS.Application.Shared.DTOs.Common;
using HMS.Core.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS.Application.Shared.Common.Interfaces
{
    public interface IRepository
    {
        Task<ResponseOutputDto> GetMultipleAsync<T>(string queryTextOrProcedureName, SqlDynamicParameters dynamicParameters, bool isCommandTypeProcedure = true) where T : class;
        Task<ResponseOutputDto> GetSingleAsync<T>(string queryTextOrProcedureName, SqlDynamicParameters dynamicParameters, bool isCommandTypeProcedure = true) where T : class;
        Task<ResponseOutputDto> Execute<T>(string queryTextOrProcedureName, SqlDynamicParameters dynamicParameters, bool isCommandTypeProcedure = true) where T : class;
    }
}
