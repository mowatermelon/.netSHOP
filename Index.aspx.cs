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


public partial class _Index : System.Web.UI.Page
{

    static Int32 CurPage = 1, PageSize = 1, TotalPage = 0, TotalRead = 0;

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

            if (CurPage == 1)//第一页的前一页不可见
                PrePage.Enabled = false;
            else if (CurPage == TotalPage)//最后一页的后一页不可见
                NextPage.Enabled = false;


            String CmdStr = "";//该变量存放查询第CurPage页包含的PageSize条记录的SQL指令字符串 

            if (CurPage == 1)
            {
                if (TotalPage == 1)
                    CmdStr = "Select * from Img order by ImgId";
                else if (TotalPage > 1)
                    CmdStr = "Select top " + PageSize + " * from Img order by ImgId";
            }
            else if (CurPage > 1)
            {
                string CmdStr1 = "Select MAX(ImgId) from (Select top " + (CurPage - 1) * PageSize + " ImgId from Img order by ImgId )";
                OleDbCommand Cmd1 = new OleDbCommand(CmdStr1, OleDbCon);
                int MZ = Convert.ToInt16(Cmd1.ExecuteScalar());

                if (CurPage == TotalPage)
                    CmdStr = "Select * from Img where Int(ImgId)>" + MZ + " order by ImgId ";
                else
                    CmdStr = "Select top " + PageSize + " *  from Img where Int(ImgId)>" + MZ + " order by ImgId ";
            }

            OleDbCommand Cmdsql01 = new OleDbCommand(CmdStr, OleDbCon);

            OleDbDataReader MessData = Cmdsql01.ExecuteReader();

            Int32 Num = (CurPage - 1) * PageSize + 1;//当前页的起始序号

            string HtmlString = "";
            string HtmlString1 = "";
            string HtmlString2 = "";
            string HtmlString3 = "";

            while (MessData.Read())
            {

                HtmlString += "<ul class='img'>";
                HtmlString += "<li class='imgA imgB' style='background-image:url(" + MessData[3].ToString() + ");'></li>";
                HtmlString += "<li class='imgA imgS' style='background-image:url(" + MessData[3].ToString() + ");'></li>";
                HtmlString += "<li class='imgA imgS' style='background-image:url(" + MessData[3].ToString() + ");'></li>";
                HtmlString += "<li class='imgA imgS' style='background-image:url(" + MessData[3].ToString() + ");'></li>";
                HtmlString += "<li class='imgA imgS' style='background-image:url(" + MessData[3].ToString() + ");'></li>";
                HtmlString += "</ul>";

                HtmlString1 +=  MessData[2].ToString();

                HtmlString2 +=  MessData[4].ToString();

                HtmlString3 += "<li class='hNews'>" + MessData[0].ToString() + "</li>";
                HtmlString3 += "<li class='hNews'>" + MessData[2].ToString() + "</li>";


            }

            goodImg.InnerHtml = HtmlString;
            P2.Text = HtmlString1;
            P4.InnerHtml = HtmlString2;
            buyNews.InnerHtml = HtmlString3;

            MessData.Close();//关闭数据库链接，必须的！
            OleDbCon.Close();//关闭数据库链接，必须的！

        }
    }

    protected void PrePage_Click(object sender, EventArgs e)
    {
        CurPage -= 1;
        Response.Redirect("Index.aspx");
    }


    protected void NextPage_Click(object sender, EventArgs e)
    {
        CurPage += 1;
        Response.Redirect("Index.aspx");
    }


    protected void Button1_Click(object sender, EventArgs e)
    {
        try
        {
            string UserI = TextBox1.Text;
            string UserC = "mo01";
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

            ClientScript.RegisterStartupScript(GetType(), "提醒", "<script type='text/javascript'>alert('发表成功！');window.location.href='Index.aspx#Cont';</script>");


        }
        catch (Exception ex)
        {
            ClientScript.RegisterStartupScript(GetType(), "提醒", "<script type='text/javascript'>alert('" + ex.Message + "');window.location.href='Index.aspx';</script>");
        }
    }

    protected void Good_Up(object sender, EventArgs e)
    {
        string GoodPl = Request.Form["Select1"];
        string GoodN = Request.Form["buy_number"];

            try
            {
                if (GoodPl != null && GoodN != null)
                {
                    string GoodP = P4.InnerHtml;
                    string GoodC = P2.Text;

                    int Gop = int.Parse(GoodP);

                    OleDbConnection OleDbCon = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Server.MapPath("user.mdb"));
                    OleDbCon.Open();

                    int GoN = int.Parse(GoodN);
                    int AllG = Gop * GoN;

                    string Cmdstring = "UPDATE Buy, Img SET Buy.BuyNum = '" + GoodN + "', Buy.BuyPath = '" + GoodPl + "',Buy.ProdId = Img.ImgId ,Buy.count = Buy.count+1 WHERE Int(Img.ImgPrice) ='" + Gop + "'and Img.ImgContent = '" + GoodC + "' and Buy.BuyId =Img.ImgId";
                    OleDbCommand Cmd = new OleDbCommand(Cmdstring, OleDbCon);

                    


                    int number = Cmd.ExecuteNonQuery();

                    if (number > 0)
                    {
                        
                        ClientScript.RegisterStartupScript(GetType(), "提醒", "<script type='text/javascript'>alert('购买成功！一共消费" + AllG + "浪漫币');</script>");
                    }
                    else
                    {  
                        ClientScript.RegisterStartupScript(GetType(), "提醒", "<script type='text/javascript'>alert('购买不成功！');</script>");                    
                    }


                    OleDbCon.Close();


                }
                else {
                    ClientScript.RegisterStartupScript(GetType(), "提醒", "<script type='text/javascript'>alert('亲 你好像有数据你没有选中哦');</script>");
                
                }



            }
            catch (Exception ex)
            {
                ClientScript.RegisterStartupScript(GetType(), "提醒", "<script type='text/javascript'>alert('" + ex.Message + "');window.location.href='Index.aspx';</script>");
            }
        }

    }
