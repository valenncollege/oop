using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EllysaEmployeeApplication
{
    [Serializable]
    public class JevonEmployee
    {   
        private int employeeId;
        private string name;
        private int basicSalary;
        private string gender;
        private DateTime startingWork;
        private int numberOfChild;
        #region property
        public int EmployeeId { get => employeeId; private set => employeeId = value; }
        public string Name { get => name;
            set
            {
                if (value == "")
                {
                    throw new Exception("Name required !");
                }
                else
                {
                    this.name = value;
                }
            }
        }
        public int BasicSalary
        {
            get => basicSalary;
            set
            {
                if (value < 0)
                {
                    value = 0;
                }
                else
                {
                    this.basicSalary = value;
                }
            }
        }
        public DateTime StartingWork { get => startingWork; set => startingWork = value; }
        public int NumberOfChild
        {
            get => numberOfChild;
            set
            {
                if (value < 0)
                {
                    value = 0;
                }
                else
                {
                    this.numberOfChild = value;
                }
            }
        }

        public string Gender { get => gender; set => gender = value; }
        #endregion

        #region constructor
        public JevonEmployee(int id, string pName, int pSalary, string pGender, DateTime pStartWork, int pChild)
        {
            this.EmployeeId = id;
            this.Name = pName;
            this.BasicSalary = pSalary;
            this.Gender = pGender;
            this.StartingWork = pStartWork;
            this.NumberOfChild = pChild;
        }
        #endregion

        #region method
        public double CalcChildAllowance ()
        {
            double result = 0;
            if (this.Gender == "Male")
            {
                result = this.NumberOfChild * 0.15 * this.BasicSalary;
            }
            return result;
        }

        public double CalcIncentive(int pTotalSales)
        {
            double result = 0;
            DateTime dateNow = DateTime.Now.Date;
            DateTime dateStart = this.StartingWork;
            int lengthOfService = dateNow.Subtract(dateStart).Days;
            if (lengthOfService >= 365)
            {
                result = 0.25 * pTotalSales;
            }
            return result;
        }
        #endregion
    }
}