<%@ Page Title="" Language="C#" MasterPageFile="~/Kullanici.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="DiziYorumProje.WebForm1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="container">
        <div class="content-grids">
            <div class="col-md-8 content-main">
                <asp:Repeater ID="Repeater1" runat="server">
                    <ItemTemplate>
                        <div class="content-grid">
                            <div class="content-grid-info">
                                <img src="<%# Eval("BlogGorsel")  %>"" alt="" style="height: 300px; width: 600px" />
                                <div class="post-info">
                                    <h4><a href="BlogDetay.aspx?BlogID=<%# Eval("BlogID")%>"><%# Eval("BlogBaslik") %></a>  <%# Eval("BlogTarih")  %></h4>
                                    <p><%# Eval("BlogIcerik")  %></p>
                                    <a href="BlogDetay.aspx"><span></span>Davamını Oku</a>
                                </div>
                            </div>
                        </div>
                    </ItemTemplate>
                </asp:Repeater>
            </div>
            <div class="col-md-4 content-right">
                <div class="recent">
                    <h3>Son Bloglar</h3>
                    <ul>
                        <asp:Repeater ID="Repeater3" runat="server">
                            <ItemTemplate>
                                <li><a href="#"><%# Eval("BlogBaslik") %></a></li>
                            </ItemTemplate>
                        </asp:Repeater>     
                    </ul>
                </div>
                <div class="comments">
                    <h3>Son Yorumlar</h3>
                    <ul>
                        <asp:Repeater ID="Repeater4" runat="server">
                            <ItemTemplate>
                                <li><a style="color: #00aeff;"><%# Eval("KullaniciAd") %> </a> | <a> <%# Eval("Yorum") %></a></li>
                            </ItemTemplate>
                        </asp:Repeater>
                    </ul>
                </div>
                <div class="clearfix"></div>
                <div class="categories">
                    <h3>Kaltegoriler</h3>
                    <ul>
                        <asp:Repeater ID="Repeater2" runat="server">
                            <ItemTemplate>
                                <li><a href="KategoriDetay.aspx?KategoriID=<%# Eval("KategoriID")%>"><%# Eval("KategoriAd") %></a></li>
                            </ItemTemplate>
                        </asp:Repeater> 
                    </ul>
                </div>
                <div class="clearfix"></div>
            </div>
            <div class="clearfix"></div>
        </div>
    </div>
</asp:Content>
