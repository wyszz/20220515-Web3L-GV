using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Business;
using Entity;
using System.Data;
using System.Data.SqlClient;

namespace _20220515_Web3L
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_reset_Click(object sender, EventArgs e)
        {
            this.tbx_teacherid.Text = "";
            this.tbx_password.Text = "";
        }

        protected void btn_login_Click(object sender, EventArgs e)
        {
            //首先验证文本框是否为空
            //获取文本框信息
            //访问数据库
            //根据返回值判断是否登录成功
            //将用户信息存入Session
            if (this.tbx_teacherid.Text.Trim()=="")
            {
                Response.Write("<script>alert('教师ID不能为空！')</script>");
                return;
            }
            if (this.tbx_password.Text.Trim() == "")
            {
                Response.Write("<script>alert('密码不能为空！')</script>");
                return;
            }
            //判断验证码
            //
            Entity.Teacher t = new Teacher();
            t.TeacherID = this.tbx_teacherid.Text.Trim();
            t.Password = this.tbx_password.Text.Trim();
            object result = Business.CommonBLL.TeacherLoginCheck(t);
            if (result==null)
            {
                Response.Write("<script>alert('用户名密码错误，请重新输入！')</script>");
                return;
            }
            t.RoleID = result.ToString();
            t.Password = "";
            Session["teacher"] = t;
            if (t.RoleID=="000")
            {
                Response.Write("<script>alert('欢迎进入管理员界面！');window.location.href='AdminMainPage.aspx'</script>");
            }
            else
            {
                Response.Write("<script>alert('欢迎进入教师界面！');window.location.href='DisplayTeacher.aspx'</script>");
            }
            //
            //DataTable dt = new DataTable();
            //if (dt.Rows.Count<=0)
            //{

            //}
            //dt.Rows[0]["roleid"].ToString();
        }
    }
}