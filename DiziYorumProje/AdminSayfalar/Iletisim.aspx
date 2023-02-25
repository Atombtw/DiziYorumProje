<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="Iletisim.aspx.cs" Inherits="DiziYorumProje.AdminSayfalar.Iletisim" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table class="table table-bordered">
        <tr>
            <th>#</th>
            <th>Ad Soyad</th>
            <th>Mail</th>
            <th>Telefon</th>
            <th>Konu</th>
            <th>Mesaj</th>
        </tr>
        <asp:Repeater ID="Repeater1" runat="server">
            <ItemTemplate>
                <tr>
                    <td><%# Eval("MesajID") %></td>
                    <td><%# Eval("AdSoyad") %></td>
                    <td><%# Eval("Mail") %></td>
                    <td><%# Eval("Telefon") %></td>
                    <td><%# Eval("Konu") %></td>
                    <td><%# Eval("Mesaj") %></td>
                </tr>
            </ItemTemplate>
        </asp:Repeater>
    </table>
</asp:Content>
