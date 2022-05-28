using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using DataAccess;
using System.Data;

namespace Business
{
    public static class CommonBLL
    {
        public static object TeacherLoginCheck(Entity.Teacher t)
        {
            string[] names = new string[] { "teacherid", "password" };
            object[] values = new object[] { t.TeacherID, t.Password };
            return DataAccess.DA.GetOneData("spr_TeacherLoginCheck", CommandType.StoredProcedure, names, values);
        }
    }
}
