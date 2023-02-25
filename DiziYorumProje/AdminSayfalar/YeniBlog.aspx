<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="YeniBlog.aspx.cs" Inherits="DiziYorumProje.AdminSayfalar.YeniBlog" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <form runat="server" class="form-group">
        <h4>Başlık</h4>
        <asp:TextBox ID="TextBox1" runat="server" CssClass="form-control"></asp:TextBox>
        <h4>Tarih</h4>
        <asp:TextBox ID="TextBox2" runat="server" CssClass="form-control"></asp:TextBox>
        <h4>Görsel</h4>
        <asp:TextBox ID="TextBox3" runat="server" CssClass="form-control"></asp:TextBox>
        <h4>Tür</h4>
        <asp:DropDownList ID="DropDownList1" runat="server" CssClass="form-control" DataTextField="TurAd" DataValueField="TurID"></asp:DropDownList>
        <h4>Kategori</h4>
        <asp:DropDownList ID="DropDownList2" runat="server" CssClass="form-control" DataTextField="KategoriAd" DataValueField="KategoriID"></asp:DropDownList>
        <h4>İçerik</h4>
        <asp:TextBox ID="TextBox4" runat="server" CssClass="form-control" Height="100px" TextMode="MultiLine"></asp:TextBox>
        <br />
        <asp:Button ID="Button1" runat="server" Text="Kaydet" CssClass="btn btn-success" OnClick="Button1_Click" />
    </form>
</asp:Content>
