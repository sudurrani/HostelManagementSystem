using HMS.Application.Shared.Common.Interfaces;
using HMS.Application.Shared.DTOs.Common;
using HMS.Application.Shared.DTOs.Test;
using HMS.Application.Shared.Interfaces;
using HMS.Core.Shared;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS.Application
{
    public class TestApplication : ITestApplication
    {
        private readonly IRepository _repository;
        public TestApplication(IRepository repository)
        {
            _repository = repository;
        }
        public Task<ResponseOutputDto> GetAll()
        {
            var sqlDynamicParameters = new SqlDynamicParameters();            
            var result = _repository.GetMultipleAsync<TestOutputDto>("Test_GetAll", sqlDynamicParameters, true);
            return result;
        }
        public Task<ResponseOutputDto> GetById(int id)
        {
            var sqlDynamicParameters = new SqlDynamicParameters();            
            sqlDynamicParameters.Add("Id", value: id,dbType:DbType.Int32);
            var result = _repository.GetSingleAsync<TestOutputDto>("Test_GetById", sqlDynamicParameters, true);
            return result;
        }
        public Task<ResponseOutputDto> Add(TestInputDto testInputDto)
        {
            var sqlDynamicParameters = new SqlDynamicParameters();
            sqlDynamicParameters.Add("Id", value: 0, dbType: DbType.Int32);
            sqlDynamicParameters.Add("Name", value: testInputDto.Name, dbType: DbType.String);
            sqlDynamicParameters.Add("Age", value: testInputDto.Age, dbType: DbType.Int32);
            var result = _repository.Execute<TestOutputDto>("Test_Save", sqlDynamicParameters, true);
            return result;
        }
        public Task<ResponseOutputDto> Update(TestInputDto testInputDto)
        {
            var sqlDynamicParameters = new SqlDynamicParameters();
            sqlDynamicParameters.Add("Id", value: testInputDto.Id, dbType: DbType.Int32);
            sqlDynamicParameters.Add("Name", value: testInputDto.Name, dbType: DbType.String);
            sqlDynamicParameters.Add("Age", value: testInputDto.Age, dbType: DbType.Int32);
            var result = _repository.Execute<TestOutputDto>("Test_Save", sqlDynamicParameters, true);
            return result;
        }
    }
}
