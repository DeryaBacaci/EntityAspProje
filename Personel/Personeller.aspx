<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="Personeller.aspx.cs" Inherits="EntityAspProje.Personel.Personeller" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <style type="text/css">
        .auto-style1 {
            color: #FFFFFF;
            background-color: #000000;
        }
    </style>
</asp:Content>


<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <table class="table table-bordered">
        <tr class="auto-style1" >
            <th>PERSONEL ID</th>
            <th>PERSONEL AD SOYAD</th>
            <th>PERSONELİ SİL</th>
        </tr>
        <asp:Repeater ID="Repeater1" runat="server">
            <ItemTemplate>
                <tr>
                    <td><%#Eval("PERSONELID") %></td>
                    <td><%#Eval("PERSONELADSOYAD") %></td>
                    <td>
                        <asp:HyperLink NavigateUrl='<%# "~/Personel/PersonelSil.aspx?PERSONELID="+Eval("PERSONELID")%>' ID="HyperLink1" runat="server" CssClass="btn btn-danger">SİL</asp:HyperLink> </td>
                </tr>
            </ItemTemplate>
        </asp:Repeater>
          
    </table>
  <a href="PersonelEkle.aspx" CssClass="btn btn-info"  ><strong><u>Personel Ekle</u></strong></a>
</asp:Content>
