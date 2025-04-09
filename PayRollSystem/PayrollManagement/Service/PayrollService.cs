using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PayrollManagement.model;
using PayrollManagement.Repository;
using PayrollManagement.Exceptions;
using PayrollManagement.model;

namespace PayrollManagement.Service
{
    internal class PayrollService : IPayrollService
    {
        readonly IPayrollServiceRepository _payrollServiceRepository;
        public PayrollService()
        {
            _payrollServiceRepository = new PayrollServiceRepository();
        }
        public void GetPayrollById()
        {
            Console.WriteLine("Enter the payrollId:");
            int payRollno = int.Parse(Console.ReadLine());
            List<Payroll> PayrollIdlist = _payrollServiceRepository.GetPayrollById(payRollno);
            foreach (Payroll payroll in PayrollIdlist)
            {
                Console.WriteLine(payroll);
            }
        }
        public void GetPayrollsForEmployee()
        {
            Console.WriteLine("Enter the EmployeeId:");
            int Employeeno = int.Parse(Console.ReadLine());
            List<Payroll> EmployeeIdlist = _payrollServiceRepository.GetPayrollsForEmployee(Employeeno);
            foreach (Payroll payroll in EmployeeIdlist)
            {
                Console.WriteLine(payroll);
            }
        }
        public void GetPayrollsForPeriod()
        {
            Console.WriteLine("Enter the startDate:");
            DateTime startdate = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Enter the endDate:");
            DateTime enddate = DateTime.Parse(Console.ReadLine());
            List<Payroll> PayRollsForPeriod = _payrollServiceRepository.GetPayrollsForPeriod(startdate, enddate);
            foreach (Payroll payroll in PayRollsForPeriod)
            {
                Console.WriteLine(payroll);
            }
        }
        public void GeneratePayroll()
        {
            Console.WriteLine("Enter the EmployeeId:");
            int Employeeno = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the startDate:");
            DateTime startdate = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Enter the endDate:");
            DateTime enddate = DateTime.Parse(Console.ReadLine());
            List<Payroll> PayRoll = _payrollServiceRepository.GeneratePayroll(Employeeno, startdate, enddate);
            foreach (Payroll payroll in PayRoll)
            {
                Console.WriteLine(payroll);
            }
        }

    }
}
