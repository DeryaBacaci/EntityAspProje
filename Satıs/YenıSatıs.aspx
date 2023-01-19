<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="YenıSatıs.aspx.cs" Inherits="EntityAspProje.Satıs.YenıSatıs" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <form runat="server">
        Ürün Seçin:
    <div>
        <asp:DropDownList ID="DropDownList1" placeholder="Kategori Seçin..." runat="server" CssClass="form-control"></asp:DropDownList>
    </div>
        <br />
        Müşteri Seçin:
      <div>
          <asp:DropDownList ID="DropDownList2" placeholder="Kategori Seçin..." runat="server" CssClass="form-control"></asp:DropDownList>
      </div>
        <br />
        Personel Seçin:
      <div>
          <asp:DropDownList ID="DropDownList3" placeholder="Kategori Seçin..." runat="server" CssClass="form-control"></asp:DropDownList>
      </div>
        <br />
        Fiyat:
      <div>
          <asp:TextBox ID="TxtFıyat" runat="server" CssClass="form-control"></asp:TextBox>
      </div>
        <br />
         <div>
            <asp:Button ID="BtnYenıSatıs" runat="server" CssClass="btn btn-primary" Text="Satış Yap" OnClick="BtnYenıSatıs_Click" />
        </div>
    </form>

</asp:Content>
