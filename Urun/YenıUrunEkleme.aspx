<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="YenıUrunEkleme.aspx.cs" Inherits="EntityAspProje.Urun.YenıUrunEkleme" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    
    <form runat="server" class="form-group">
        <div>
            <asp:TextBox ID="TxtUrunAd" runat="server" placeholder="Ürün Adını Girin..." CssClass="form-control"></asp:TextBox>
        </div>
        <br />
          <div>
            <asp:TextBox ID="TxtUrunMarka" runat="server" placeholder="Marka Adını Girin..." CssClass="form-control"></asp:TextBox>
        </div>
        <br />
          <div>
              <asp:DropDownList ID="DropDownList1"  placeholder="Kategori Seçin..." runat="server" CssClass="form-control"></asp:DropDownList>
           </div>
        <br />
          <div>
            <asp:TextBox ID="TxtFıyat" runat="server" placeholder="Fiyatı Girin..." CssClass="form-control"></asp:TextBox>
        </div>
        <br />
          <div>
            <asp:TextBox ID="TxtStok" runat="server" placeholder="Stoğu Sayısı..." CssClass="form-control"></asp:TextBox>
        </div>
        <br />
        <div>
            <asp:Button ID="BtnUrunEkle" runat="server" CssClass="btn btn-primary" Text="Ürün Ekle" OnClick="BtnUrunEkle_Click" />
        </div>
    </form>

</asp:Content>
