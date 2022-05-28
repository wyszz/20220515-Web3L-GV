using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
//
using System.Data;
using System.Data.SqlClient;
using Entity;
using Business;

namespace _20220515_Web3L
{
    public partial class DisplayTeacher : System.Web.UI.Page
    {
        static DataTable DT;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["teacher"] == null)
            {
                Response.Write("<script>alert('请先登录！');parent.window.location.href='Login.aspx'</script>");
            }
            //else
            //{
            //    Entity.Teacher t = (Entity.Teacher)Session["teacher"];
            //    t.TeacherName = Business.AdminBusiness.GetTeacherNamebyID(t).ToString();
            //    //this.Label1.Text = string.Format("欢迎管理员'{0}'回来！", t.TeacherName);
            //    this.Label1.Text = "欢迎管理员 " + t.TeacherName + "回来！";
            //}
            if (!IsPostBack)
            {
                DT = Business.AdminBusiness.SelectViewTeacher();
                ViewState["pageindex"] = 0;
                this.LoadDataList(DT);
            }
        }

        private PagedDataSource DataListPaging(DataTable dt)
        {
            DataView dv = dt.DefaultView;
            PagedDataSource pds = new PagedDataSource();
            pds.DataSource = dv;
            pds.AllowPaging = true;
            pds.PageSize = 2;
            pds.CurrentPageIndex = Convert.ToInt32(ViewState["pageindex"].ToString());
            ViewState["pagecount"] = pds.PageCount;
            if (pds.IsFirstPage)
            {
                this.lbtn_pre.Enabled = false;
            }
            else
            {
                this.lbtn_pre.Enabled = true;
            }
            if (pds.IsLastPage)
            {
                this.lbtn_next.Enabled = false;
            }
            else
            {
                this.lbtn_next.Enabled = true;
            }
            return pds;
        }

        private void LoadDataList(DataTable dt)
        {
            this.dl_teacher.DataSource = this.DataListPaging(dt);
            this.dl_teacher.DataBind();
        }

        protected void lbtn_Click(object sender, EventArgs e)
        {
            LinkButton lbtn = sender as LinkButton;
            string cmda = lbtn.CommandArgument;
            int pageindex = Convert.ToInt32(ViewState["pageindex"].ToString());
            if (cmda=="pre")
            {
                pageindex = pageindex - 1;
            }
            else
            {
                pageindex = pageindex + 1;
            }
            ViewState["pageindex"] = pageindex;
            this.LoadDataList(DT);
            this.tbx_pagenum.Text = (pageindex + 1).ToString();
        }

        protected void btn_go_Click(object sender, EventArgs e)
        {
            int pagenum = Convert.ToInt32(this.tbx_pagenum.Text.Trim());
            int pageindex = pagenum - 1;
            int pagecount = Convert.ToInt32(ViewState["pagecount"]);
            //int.TryParse
            if (pageindex < 0)
            {
                Response.Write("<script>alert('页数必须大于0！将回到首页')</script>");
                pageindex = 0;
            }
            if (pageindex >= pagecount)
            {
                Response.Write("<script>alert('页数不能超过总页数！将达到最后一页')</script>");
                pageindex = pagecount - 1;
            }
            ViewState["pageindex"] = pageindex;
            this.LoadDataList(DT);
            this.tbx_pagenum.Text = (pageindex + 1).ToString();
        }

        protected void btn_search_Click(object sender, EventArgs e)
        {
            string tname = this.tbx_teachername.Text.Trim();
            if (tname=="")
            {
                Response.Write("<script>alert('教师姓名不能为空！')</script>");
                return;
            }
            Entity.Teacher t = new Teacher();
            t.TeacherName = "%" + tname + "%";
            DT = Business.AdminBusiness.SelectViewTeacherbyTeacherName(t);
            this.dl_teacher.DataSource = this.DataListPaging(DT);
            this.dl_teacher.DataBind();
        }

        protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
        {
            ImageButton imbtn = (ImageButton)sender;
            string tid = imbtn.CommandArgument;
            //Session["tid"] = tid;
            Response.Redirect("~/teacherinfowebpage.aspx?tid=" + tid);
        }
    }
}