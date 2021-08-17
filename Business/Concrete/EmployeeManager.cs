using System;
using System.Collections.Generic;
using System.Text;
using Core.Utilities.Results;
using Business.Abstract;
using Business.Constants;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class EmployeeManager : IEmployeeService
    {
        private IEmployeeDal _employeeDal;

        public EmployeeManager(IEmployeeDal employeeDal)
        {
            _employeeDal = employeeDal;
        }

        public IDataResult<Employee> GetEmployeeById(int employeeId)
        {
            return DataResult<Employee>.FromSuccess(_employeeDal.Get(e => e.EmployeeId == employeeId), Messages.ItemsBrought);
        }
    }
}
