using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
//
using Business;
using Entity;

namespace _20220515_Web3L
{
    public partial class AdminTop : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["teacher"] == null)
            {
                Response.Write("<script>alert('请先登录！');window.location.href='Login.aspx'</script>");
            }
            else
            {
                Entity.Teacher t = (Entity.Teacher)Session["teacher"];
                t.TeacherName = Business.AdminBusiness.GetTeacherNamebyID(t).ToString();
                this.Label1.Text = "欢迎管理员 " + t.TeacherName + "回来！";
            }
        }
    }
}