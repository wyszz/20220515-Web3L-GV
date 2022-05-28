using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Teacher
    {
        private string _teacherid;
        private string _teachername;
        private string _password;
        private int _age;
        private string _email;
        private string _qq;
        private string _phone;
        private string _gender;
        private DateTime _birthday;
        private string _titleid;
        private string _roleid;
        private string _officeid;
        private string _authorizedid;
        private string _photourl;

        public string TeacherID { get => _teacherid; set => _teacherid = value; }
        public string TeacherName { get => _teachername; set => _teachername = value; }
        public string Password { get => _password; set => _password = value; }
        public int Age { get => _age; set => _age = value; }
        public string Email { get => _email; set => _email = value; }
        public string QQ { get => _qq; set => _qq = value; }
        public string Phone { get => _phone; set => _phone = value; }
        public string Gender { get => _gender; set => _gender = value; }
        public DateTime Birthday { get => _birthday; set => _birthday = value; }
        public string TitleID { get => _titleid; set => _titleid = value; }
        public string RoleID { get => _roleid; set => _roleid = value; }
        public string OfficeID { get => _officeid; set => _officeid = value; }
        public string AuthorizedID { get => _authorizedid; set => _authorizedid = value; }
        public string PhotoURL { get => _photourl; set => _photourl = value; }
    }
}
