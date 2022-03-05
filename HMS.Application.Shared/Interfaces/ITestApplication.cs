using HMS.Application.Shared.DTOs.Common;
using HMS.Application.Shared.DTOs.Test;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS.Application.Shared.Interfaces
{
    public interface ITestApplication
    {
        Task<ResponseOutputDto> GetAll();
        Task<ResponseOutputDto> GetById(int id);
        Task<ResponseOutputDto> Add(TestInputDto testInputDto);
        Task<ResponseOutputDto> Update(TestInputDto testInputDto);
    }
}
