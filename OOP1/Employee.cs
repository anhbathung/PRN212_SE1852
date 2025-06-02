using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    public class Employee
    {
        #region Nhóm các thuộc tính của Employee
        private int _id;
        private string _name;
        private string _email;
        private string _phone;
        #endregion
        #region Nhóm các Constructors của Employee
        public Employee()
        {

        }
        public Employee(int _id,string _name, string _email, string _phone)
        {
            this._id= _id;
            this._name= _name;
            //hoặc:
            Email = _email;//là gọi setter cho Property Email
            Phone = _phone;
        }
        #endregion
        #region Nhóm các Properties của Employee
        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }
        public string Name
        {
            set { _name = value; }
            get { return _name; }
        }
        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }
        public string Phone
        {
            get { return _phone; }
            set { _phone = value; }
        }
        #endregion
        #region Nhóm các phương thức của Employee
        public void PrintInfor()
        {
            Console.WriteLine($"{_id}\t{_name}\t{_email}\t{_phone}");
        }
        public override string ToString()
        {
            string msg = $"{_id}\t{_name}\t{_email}\t{_phone}";
            return msg;
        }
        #endregion
    }
}
