<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Index.aspx.cs" Inherits="_Index" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html>

<head>
    <title> >_< ~  INDEX >_< ~</title>
     <link href="Styles/Site01.css" rel="stylesheet" type="text/css" />
     <script type="text/javascript" src="Scripts/mo.js"></script>
</head>
<body>

    <form id="form1" runat="server" method="post">

   <!-------------------------------------------------------TOP BEGIN----------------------------------------------------------------------->
       <div id="TOP" runat="server">

           <div id="TOP_IMG"  runat="server">                

           </div>

           
           <div id="Top_Right"  runat="server">

                <div>
		 		    <span id="span_Index" class="btnHd btnOver" onmouseover="showIndex()" runat="server">巧手</span>
		 		    <span id="span_Tran" class="btnHd" onmouseover="showTran()" runat="server">巧译</span>
		 		    <span id="span_Kind" class="btnHd btnCenter" onmouseover="showKind()" runat="server">巧种</span>
                    <span id="span_Prod" class="btnHd" onmouseover="showProd()" runat="server">巧品</span>
                    <span id="span_Cont" class="btnHd" onmouseover="showCont()" runat="server">巧言</span>
		 	    </div>

           </div>


       </div>
  <!-------------------------------------------------------TOP OVER----------------------------------------------------------------------->
  

 <!-------------------------------------------------------MID BEGIN----------------------------------------------------------------------->         
        <div id="mid"  runat="server">   


            <!-------------------------------------------------------MID INDEX BEGIN-------------------------------------> 
		 		<div id="Index" runat="server">

                    <div id="first_mid"  runat="server">
                           
                        <div id="ShowArea" runat="server">            
                            <ul id="goodImg" runat="server">

                            </ul>

		 			        <ul class="word"  runat="server">	
		 				        <li runat="server"><asp:Label ID="P2" runat="server" Text="" class="title"></asp:Label></li>
                                <li runat="server"><p id="P3" class="title02"  runat="server">【61儿童节糖果食品大礼包】【 萌熊棒棒糖巧克力 苦甜平衡 丝滑醇厚】</p></li>
                                <li  class="price"  runat="server"><p id="pp">商品价格 ￥</p><i ID="P4" runat="server"></i></li>
                                <li runat="server"><p id="P5" class="price number"  runat="server">&nbsp;&nbsp;已售2382</p></li>
                                <li runat="server">促销<p id="P6" class="title "  runat="server">满赠指定商品满2件，赠送Amovo/魔吻 魔吻 牛奶口味伽纳彻</p></li>
                                <li runat="server">送货至
                                    <select id="Select1" runat="server" >
                                        <option runat="server">武汉</option>
                                        <option runat="server">上海</option>
                                        <option runat="server">武汉</option>
                                        <option runat="server">北京</option>
                                        <option runat="server">仙桃</option>
                                    </select>运费10.00元  满69.00包邮
                                </li>
                                <li class="buyNumber" runat="server">
                                    <i>&nbsp;&nbsp;&nbsp;&nbsp;请选择购买数量：</i>

                                    <label  runat="server"><input type="radio" name="buy_number"  runat="server" value="100"/>100</label>
                                    <label  runat="server"><input type="radio" name="buy_number"  runat="server" value="200" />200</label>
                                    <label  runat="server"><input type="radio" name="buy_number"  runat="server" value="300" />300</label>
                                    <asp:Button ID="buy"  class='buy' runat="server" Text="立即 购买" OnClick="Good_Up"/>
                                </li>
                             </ul>    
                        </div>   
                    </div>
         
         
                    <div id="second_mid" runat="server">
                        <ul>
                            <li class='btn'  runat="server">
                                <asp:Button ID="PrePage"  class='all_border btn' runat="server" Text="< back" onclick="PrePage_Click" />
                            </li>

                            <li class='btn'  runat="server">
                                <asp:Button ID="NextPage"  class='all_border btn' runat="server" Text=" up >" onclick="NextPage_Click" />
                            </li>

                            <li class='bom_p bom_p_f_i'  runat="server">
                                <asp:HyperLink ID="CurPageL" runat="server" NavigateUrl="" class="bom_p bom_p_f_i"></asp:HyperLink>
                            </li>
                        </ul>

                    </div>
                      
		 		</div>
            <!-------------------------------------------------------MID INDEX OVER-------------------------------------> 

            <!-------------------------------------------------------MID TRAN BEGIN-------------------------------------> 
		 		<div id="Tran" runat="server">
                    <ul class="MIMI">
                        <li class="HMIMI hMIMI">巧克力种类</li>
                        <li class="HMIMI hMIMI">巧克力蜜语</li>
                        <li class="hMIMI">伽纳彻</li>
                        <li class="hMIMI">不要将自己推往最高处，希望愈大，失望愈大,不要让野心埋没了童真。</li>
                        <li class="hMIMI">棒棒糖</li>
                        <li class="hMIMI">自我要求太高反而得不到人生乐趣,不要为了取得所有胜利而失去人和。</li>
                        <li class="hMIMI">考伟曲</li>
                        <li class="hMIMI">努力耕耘，学习的过程比结果更具吸引力,照顾自己的同时也要懂得与人享乐趣。 </li>
                        <li class="hMIMI">DIY</li>
                        <li class="hMIMI">你未必能洞悉世事，但一定要尊重别人,不要过份高估自己的能力而贬低旁人。 </li>
                    </ul>
		 		</div>
            <!-------------------------------------------------------MID TRAN OVER-------------------------------------> 



            <!-------------------------------------------------------MID KIND BEGIN-------------------------------------> 
		 		<div id="Kind" runat="server">
                    <ul class="KIND">
                        <li class="HKIND hKIND">巧克力爱称</li>
                        <li class="HKIND hKIND">巧克力全称</li>
                        <li class="HKIND hKIND">巧克力价格</li>
                         <li class="HKIND hKIND">修改</li>
                        <li class="hKIND">考伟曲趣味礼盒</li>
                        <li class="hKIND">Amovo/魔吻 【买1送1】手工纯可可脂 生日礼物情人节巧克力礼盒 手工创意夹心黑巧克力</li>
                        <li class="hKIND">￥388.00</li>
                        <li  class='hKIND' runat="server">
                             <asp:Button class='all_border btn' runat="server" Text="修改"/>
                        </li>
                        <li class="hKIND">巧克力棒棒糖趣味礼盒</li>
                        <li class="hKIND">Amovo/魔吻 【买1送1】六一儿童节纯手工黑巧克力礼盒装萌心棒棒糖巧克力生日礼物情人节</li>
                        <li class="hKIND">￥488.00</li>
                        <li class='hKIND'  runat="server">
                             <asp:Button class='all_border btn' runat="server" Text="修改"/>
                        </li>
                        <li class="hKIND">考伟曲不苦系列</li>
                        <li class="hKIND">Amovo/魔吻 六一儿童节 35%可可牛奶巧克力 进口纯可可脂 手工黑巧克力 休闲零食 120g</li>
                        <li class="hKIND">￥100.00</li>
                        <li class='hKIND'  runat="server">
                             <asp:Button class='all_border btn' runat="server" Text="修改"/>
                        </li>
                        <li class="hKIND">伽纳彻微苦小熊棒棒糖</li>
                        <li class="hKIND">Amovo/魔吻 六一儿童节小熊棒棒糖手工纯黑巧克力盒装 纯可可脂 零食生日节日礼物160g</li>
                        <li class="hKIND">￥555.00</li>
                        <li class='hKIND'  runat="server">
                             <asp:Button class='all_border btn' runat="server" Text="修改"/>
                        </li>
                    </ul>

		 	    </div>
            <!-------------------------------------------------------MID KIND OVER-------------------------------------> 



            <!-------------------------------------------------------MID PROD BEGIN-------------------------------------> 
		 		<div id="Prod" class="info" runat="server">
                        <ul id="Ul1" class="News" runat="server">
                            <li class="hNews HNews">最近购买过的商品id</li>
                            <li class="hNews HNews">最近购买过的商品名称</li>                      
                        </ul>

                        <ul  id="buyNews" class="News" runat="server">
                        
                        </ul>

                        <ul>
                            <li id="Li1" class='btn'  runat="server">
                                <asp:Button ID="Button2"  class='all_border btn' runat="server" Text="< back" onclick="PrePage_Click" />
                            </li>

                            <li id="Li2" class='btn'  runat="server">
                                <asp:Button ID="Button3"  class='all_border btn' runat="server" Text=" up >" onclick="NextPage_Click" />
                            </li>

                            <li id="Li3" class='bom_p bom_p_f_i'  runat="server">
                                <asp:HyperLink ID="HyperLink7" runat="server" NavigateUrl="" class="bom_p bom_p_f_i"></asp:HyperLink>
                            </li>
                        </ul>
		 		</div>
            <!-------------------------------------------------------MID PROD OVER-------------------------------------> 




            <!-------------------------------------------------------MID CONT BEGIN-------------------------------------> 
                <div id="Cont" class="info" runat="server">
                    <div id="third_mid" runat="server">

                    <p id="P15" class="mo1" runat="server">
                        CONTENT
                   </p>
                
                    <p id="P16" class="mo mo2" runat="server">
                        标题：
                        <asp:TextBox ID="TextBox1" runat="server"  class="all_border inp">
                        </asp:TextBox>
                    </p>
        
                    <p id="P17" class="mo mo2" runat="server">
                        内容：
                        <asp:TextBox ID="TextBox2" runat="server"   class="all_border inp" Rows="25" TextMode="MultiLine">
                        </asp:TextBox>
                    </p>
                
                    <asp:Button ID="btn" class='btn all_border' runat="server" Text="发布" />

                </div>
		 		</div>
            <!-------------------------------------------------------MID CONT OVER-------------------------------------> 



        </div>
 <!-------------------------------------------------------MID OVER----------------------------------------------------------------------->     



  <!-------------------------------------------------------BOM BEGIN----------------------------------------------------------------------->  
        <div id="BOM" runat="server">
            <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/Admin.aspx" class="bom_p bom_p_f_i">
                关于我们
            </asp:HyperLink>

            <div  class="bom_p_x">
                /
            </div>

            <asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl="~/Admin.aspx" class="bom_p">
                门店指引
            </asp:HyperLink>

            <div  class="bom_p_x">
                /
            </div>

            <asp:HyperLink ID="HyperLink3" runat="server" NavigateUrl="~/Admin.aspx" class="bom_p">
                信息反馈
            </asp:HyperLink>

            <div  class="bom_p_x">
                /
            </div>

            <asp:HyperLink ID="HyperLink4" runat="server" NavigateUrl="~/Admin.aspx" class="bom_p">
                我要加盟
            </asp:HyperLink>

            <div  class="bom_p_x">
                /
            </div>

            <asp:HyperLink ID="HyperLink5" runat="server" NavigateUrl="~/Admin.aspx" class="bom_p">
                招聘信息
            </asp:HyperLink>

            <div  class="bom_p_x">
                /
            </div>

            <asp:HyperLink ID="HyperLink6" runat="server" NavigateUrl="~/Admin.aspx" class="bom_p">
                友情链接
            </asp:HyperLink>
        </div>  
  <!-------------------------------------------------------BOM OVER----------------------------------------------------------------------->                   
    </form>

</body>
</html>
