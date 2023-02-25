<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="Hakkimizda.aspx.cs" Inherits="DiziYorumProje.AdminSayfalar.Hakkimizda" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <form runat="server">
        <h1>Aktif Hakkımızda</h1>
        <asp:TextBox ID="TextBox4" runat="server" CssClass="form-control" Height="100px" TextMode="MultiLine" Enabled="False"></asp:TextBox>
        <h1>Güncellemek İçin Doldurunuz</h1>
        <asp:TextBox ID="TextBox1" runat="server" CssClass="form-control" Height="100px" TextMode="MultiLine"></asp:TextBox>
        <br />
        <asp:Button ID="Button1" runat="server" Text="Güncelle" CssClass="btn btn-success" OnClick="Button1_Click" />
    </form>
</asp:Content>
