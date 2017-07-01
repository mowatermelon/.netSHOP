<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Register.aspx.cs" Inherits="_Register" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Strict//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-strict.dtd">
<html xmlns="http://www.w3.org/1999/xhtml" xml:lang="en">
<head id="Head1" runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>REGISITER</title>
    <link href="~/Styles/Site.css" rel="stylesheet" type="text/css" />
    <script type="text/javascript" charset="javascript" src="~/Scripts/mo.js"></script>
</head>
<body id="Body1" runat="server">
        <div class="mo">
           <p>Heart-shaped chocolates: you want to be with each other the relationship between the clear as soon as possible. Cartoonchocolate: you are appreciate each other's naivete. Chocolate with toys: that your relationship with each other is between lovers and friends.</p>
        </div>
         
        <div id="all_top" class="atop" runat="server">
     

            <div id="center_top" class="ctop" runat="server">

                <form id="form1" runat="server">

        
                    <div id="Div1" class="mo1" runat="server">REGISTER</div>
                
                    <div id="Div2" class="mo mo2" runat="server">
                        注&nbsp;册&nbsp;名：
                        <asp:TextBox ID="TextBox1" runat="server"  class="all_border inp"></asp:TextBox>
                    </div>
        
                    <div id="Div3" class="mo mo2" runat="server">
                        帐号密码：
                        <asp:TextBox ID="TextBox2" runat="server"  class="all_border inp" TextMode="Password"></asp:TextBox>
                    </div>

                    <div id="Div4" class="mo mo2" runat="server">
                        确认密码：
                        <asp:TextBox ID="TextBox3" runat="server"  class="all_border inp" TextMode="Password"></asp:TextBox>
                    </div>
                
                    <asp:Button ID="btn" runat="server" Text="注册" onclick="Register" class="all_border"/>

                    <asp:HyperLink ID="HyperLink4" runat="server" NavigateUrl="~/Admin.aspx" class="mo3">已有帐号？立即登录</asp:HyperLink>          
        
                </form>
            </div>
       
        </div>

        <div class="mo">
           <p>心型巧克力：你希望与对方之间的关系尽快明朗化。卡通巧克力： 表示你很欣赏对方的天真烂漫。带玩具的巧克力：表示你与对方的关系正介于情人和朋友之间。</p>
        </div>

</body>
</html>
