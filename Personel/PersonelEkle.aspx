<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="PersonelEkle.aspx.cs" Inherits="EntityAspProje.Personel.PersonelEkle" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <form runat="server" class="form-group">
       
        <div>
            Personel AD-SOYAD:
        <asp:TextBox ID="TxtPrAD" runat="server" CssClass="form-control" placeholder="AD ve Soyad arasına birer boşluk birakınız..."></asp:TextBox>
        </div>
        <br />
        <br />
        <asp:Button runat="server" Text="Personeli Ekle" CssClass="btn btn-primary" Font-Bold="true" OnClick="Unnamed1_Click" />
    </form>

</asp:Content>
