using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
//
using Business;
using Entity;
using System.Data;

namespace _20220515_Web3L
{
    public partial class TeacherInfo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["teacher"] == null)
            {
                Response.Write("<script>alert('请先登录！');parent.window.location.href='Login.aspx'</script>");
            }
            if (!Page.IsPostBack)
            {
                if (Request.QueryString["tid"]==null)
                {
                    Response.Write("<script>alert('请选中某位教师！');window.location.href='DisplayTeacher.aspx'</script>");
                    return;
                }
                Entity.Teacher t = new Entity.Teacher();
                t.TeacherID = Request.QueryString["tid"];
                this.DataList1.DataSource = Business.AdminBusiness.SelectTeacherbyID(t);
                this.DataList1.DataBind();
            }
        }
    }
}