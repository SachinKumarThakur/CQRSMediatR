using EmployeeManagementLibrary.Data;
using EmployeeManagementLibrary.Models;
using EmployeeManagementLibrary.Queries;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace EmployeeManagementLibrary.Handlers
{
    public class GetEmployeeListHandler : IRequestHandler<GetEmployeeListQuery, List<EmployeeModel>>
    {
        private readonly IDataAccess _dataaccsess;
        public GetEmployeeListHandler(IDataAccess dataaccsess)
        {
            _dataaccsess = dataaccsess;
        }

        public Task<List<EmployeeModel>> Handle(GetEmployeeListQuery request, CancellationToken cancellationToken)
        {
            return Task.FromResult(_dataaccsess.GetEmployees());
        }
    }
}
