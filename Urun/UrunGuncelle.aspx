<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="UrunGuncelle.aspx.cs" Inherits="EntityAspProje.Urun.UrunGuncelle" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">

     <form runat="server" class="form-group">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Ürün Adı" Font-Bold="True"></asp:Label>
            <asp:TextBox ID="TxtUrunAd" runat="server"  CssClass="form-control"></asp:TextBox>
        </div>
        <br />
          <div>
              <asp:Label ID="Label2" runat="server" Text="Ürün Marka" Font-Bold="True"></asp:Label>
            <asp:TextBox ID="TxtUrunMarka" runat="server" CssClass="form-control"></asp:TextBox>
        </div>
        <br />
          <div>
              <asp:Label ID="Label3" runat="server" Text="Kategori" Font-Bold="True"></asp:Label>
              <asp:DropDownList ID="DropDownList1" runat="server" CssClass="form-control"></asp:DropDownList>
           </div>
        <br />
          <div>
              <asp:Label ID="Label4" runat="server" Text="Fiyat" Font-Bold="True"></asp:Label>
            <asp:TextBox ID="TxtFıyat" runat="server"  CssClass="form-control"></asp:TextBox>
        </div>
        <br />
          <div>
              <asp:Label ID="Label5" runat="server" Text="Stok" Font-Bold="True"></asp:Label>
            <asp:TextBox ID="TxtStok" runat="server" CssClass="form-control"></asp:TextBox>
        </div>
        <br />
        <div>
           
            <asp:Button ID="BtnUrunGuncelle" runat="server" CssClass="btn btn-warning" Text="Ürün Güncelle" OnClick="BtnUrunGuncelle_Click"  />
        </div>
    </form>

</asp:Content>
