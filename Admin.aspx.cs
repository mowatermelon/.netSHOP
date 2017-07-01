using System;
using System.Drawing;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Collections.Generic;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
using System.Data.OleDb;


public partial class _Admin : System.Web.UI.Page
{

    static Int32 CurPage = 1, PageSize = 16, TotalPage = 0, TotalRead = 0;

    protected void Page_Load(object sender, EventArgs e)//这个函数最重要，所有页面的动态样子都在这里决定
    {


        if (!IsPostBack)//如果是全页的刷新，新加载或者F5，ReDirect
        {

            PrePage.Enabled = true;
            NextPage.Enabled = true;

            OleDbConnection OleDbCon = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Server.MapPath("user.mdb"));
            OleDbCon.Open();

            string Cmdsql = "select count(*) from Img";//准备好SQL查询语句
            OleDbCommand Cmd = new OleDbCommand(Cmdsql, OleDbCon);

            TotalRead = Convert.ToInt32(Cmd.ExecuteScalar());

            if (TotalRead < PageSize)//总页至少一页
                TotalPage = 1;

            else if (TotalRead % PageSize == 0)//刚好整数页
                TotalPage = TotalRead / PageSize;

            else//有余数的，总数要加一页
                TotalPage = TotalRead / PageSize + 1;

            if (CurPage > TotalPage)
                CurPage = TotalPage;

            CurPageL.Text = "当前第" + CurPage + "页，共" + TotalPage + "页";

            //HyperLink3.Text = TotalPage.ToString();

            if (CurPage == 1)//第一页的前一页不可用
                PrePage.Enabled = false;
            else if (CurPage == TotalPage)//最后一页的后一页不可用
                NextPage.Enabled = false;


            String CmdStr = "";//该变量存放查询第CurPage页包含的PageSize条记录的SQL指令字符串 

            if (CurPage == 1)
            {
                if (TotalPage == 1)
                    CmdStr = "Select * from Img order by Int(ImgId)";
                else if (TotalPage > 1)
                    CmdStr = "Select top " + PageSize + " * from Img order by Int(ImgId)";
            }
            else if (CurPage > 1)
            {
                string CmdStr1 = "Select MAX(ImgId) from (Select top " + (CurPage - 1) * PageSize + " ImgId from Img order by Int(ImgId) )";
                OleDbCommand Cmd1 = new OleDbCommand(CmdStr1, OleDbCon);
                int MZ = Convert.ToInt16(Cmd1.ExecuteScalar());

                if (CurPage == TotalPage)
                    CmdStr = "Select * from Img where Int(ImgId)>" + MZ + " order by Int(ImgId) ";
                else
                    CmdStr = "Select top " + PageSize + " *  from Img where Int(ImgId)>" + MZ + " order by Int(ImgId) ";
            }





            OleDbCommand Cmdsql01 = new OleDbCommand(CmdStr, OleDbCon);

            OleDbDataReader MessData = Cmdsql01.ExecuteReader();

            Int32 Num = (CurPage - 1) * PageSize + 1;//当前页的起始序号

            string HtmlString = "";

            while (MessData.Read())
            {

                HtmlString += "<li class='good'>";
                HtmlString += "<a href='Index.aspx'><img src=" + MessData[3].ToString() + "/></a>";
                HtmlString += "<p class='shopniki'>" + MessData[1].ToString() + "</p>";
                HtmlString += "<p class='price'>￥" + MessData[4].ToString() + "</p>";
                HtmlString += "</li>";

            }

            commodity.InnerHtml = HtmlString;

            MessData.Close();
            OleDbCon.Close();

        }
    }

    protected void PrePage_Click(object sender, EventArgs e)
    {
        CurPage -= 1;
        Response.Redirect("Admin.aspx?id=commodity");
    }


    protected void NextPage_Click(object sender, EventArgs e)
    {
        CurPage += 1;
        Response.Redirect("Admin.aspx?id=commodity");
    }

    protected void clear(object sender, EventArgs e)
    {
        List05.Text = "LOGIN";
    }

        protected void Login(object sender, EventArgs e)
    {
        try
        {
            string s1 = TextBox3.Text;
            string s2 = TextBox4.Text;
            
            OleDbConnection OleDbCon = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Server.MapPath("user.mdb"));
            OleDbCon.Open();

            string Cmdstring = "select * from userInfo where UserName='" + s1 + "' and UserPwd='" + s2 + "'";
            
            
            OleDbCommand Cmd = new OleDbCommand(Cmdstring, OleDbCon);
            Cmd.Parameters.AddWithValue("@UsN", s1);
            Cmd.Parameters.AddWithValue("@UsP", s2);

            OleDbDataReader UserData = Cmd.ExecuteReader();// 

            if (UserData.Read())
            {
                Session["UserID"] = UserData[0];
                Session["UserName"] = UserData[1];
                List05.Text = "Hope"+s1+"happy";
                ClientScript.RegisterStartupScript(GetType(), "提醒", "<script type='text/javascript'>alert('登陆成功！');</script>");
            }
            else
            {

                ClientScript.RegisterStartupScript(GetType(), "提醒", "<script type='text/javascript'>alert('登陆失败，请继续登陆！');window.location.href='Admin.aspx';</script>");
            }

            OleDbCon.Close();
                      
        }
        catch (Exception ex)
        {
            ClientScript.RegisterStartupScript(GetType(), "提醒", "<script type='text/javascript'>alert('" + ex.Message + "');window.location.href='Admin.aspx';</script>");
        }
    }



        protected void send(object sender, EventArgs e)
        {
            try
            {
                if (List05.Text != "LOGIN")
                {

                    string UserI = TextBox1.Text;
                    string UserC = List05.Text;
                    string UserN = TextBox2.Text;

                    OleDbConnection OleDbCon = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Server.MapPath("user.mdb"));
                    OleDbCon.Open();

                    string Cmdstring = "insert into mesboard values(@UsI,@UsC,@UsN)";
                    OleDbCommand Cmd = new OleDbCommand(Cmdstring, OleDbCon);
                    Cmd.Parameters.AddWithValue("@UsI", UserI);
                    Cmd.Parameters.AddWithValue("@UsN", UserN);
                    Cmd.Parameters.AddWithValue("@UsC", UserC);

                    Cmd.ExecuteNonQuery();       
                    OleDbCon.Close();

                    ClientScript.RegisterStartupScript(GetType(), "提醒", "<script type='text/javascript'>alert('发表成功！');window.location.href='Admin.aspx';</script>");

                }
                else {
                    ClientScript.RegisterStartupScript(GetType(), "提醒", "<script type='text/javascript'>alert('亲 还没有登录哦~,请点击网页右上角LOGIN进行登录');window.location.href='Admin.aspx';</script>");
                
                }



            }
            catch (Exception ex)
            {
                ClientScript.RegisterStartupScript(GetType(), "提醒", "<script type='text/javascript'>alert('" + ex.Message + "');window.location.href='Admin.aspx';</script>");
            }
        }

}




