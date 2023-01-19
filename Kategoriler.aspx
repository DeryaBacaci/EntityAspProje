<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="Kategoriler.aspx.cs" Inherits="EntityAspProje.Kategoriler" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <table class="table table-bordered">
        <tr>
            <th>KATEGORİ ID</th>
            <th>KATEGORİ ADI</th>
            <th>SİL</th>
            <th>GÜNCELLE</th>
        </tr>
        <asp:Repeater ID="Repeater1" runat="server">
            <ItemTemplate>
                <tr>
                    <td><%#Eval("KATEGORIID")%></td>
                    <td><%#Eval("KATEGORIAD")%></td>
                    <td>
                        <asp:HyperLink NavigateUrl='<%# "~/KategorıSıl.aspx?KATEGORIID="+Eval("KATEGORIID") %>' ID="HyperLink1" runat="server" CssClass="btn btn-danger">SİL</asp:HyperLink>
                    </td>
                    <td>
                        <asp:HyperLink NavigateUrl='<%# "~/KategorıGuncelle.aspx?KATEGORIID="+Eval("KATEGORIID") %>'  ID="HyperLink2" runat="server" CssClass="btn btn-warning">GÜNCELLE</asp:HyperLink>
                    </td>
                </tr>
            </ItemTemplate>
        </asp:Repeater>
    </table>
      <a href="KategorıEkle.aspx" class="btn btn-info">Yeni Kategori Ekle</a>
</asp:Content>
