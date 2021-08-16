using EmployeeManagementLibrary.Models;
using MediatR;
using System.Collections.Generic;

namespace EmployeeManagementLibrary.Queries
{
    public record GetEmployeeListQuery():IRequest<List<EmployeeModel>>;

}
