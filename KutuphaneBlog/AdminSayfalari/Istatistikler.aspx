﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="Istatistikler.aspx.cs" Inherits="KutuphaneBlog.WebForm12" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <table class="table table-bordered">
        <tr>
            <td>Toplam Kitap Sayısı : <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label></td>
            <td>Toplam Yorum Sayısı : <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label></td>
            <td>Toplam Dergi Sayısı : <asp:Label ID="Label3" runat="server" Text="Label"></asp:Label></td>
        </tr>
        <tr>
            <td>Toplam Çizgi Roman Sayısı : <asp:Label ID="Label4" runat="server" Text="Label"></asp:Label></td>
            <td>Toplam Çocuk Kitabı Sayısı : <asp:Label ID="Label5" runat="server" Text="Label"></asp:Label></td>
            <td>En Çok Yorum Alan Kitap : <asp:Label ID="Label6" runat="server" Text="Label"></asp:Label></td>
        </tr>
    </table>
</asp:Content>
