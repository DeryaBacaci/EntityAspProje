<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="KategorıGuncelle.aspx.cs" Inherits="EntityAspProje.KategorıGuncelle" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
      <form runat="server" class="form-group">
           <div>
            <asp:TextBox ID="txtıd" runat="server"  CssClass="form-control" Enabled="false"></asp:TextBox>
        </div>
        <br />
        <div>
            <asp:TextBox ID="txtad" runat="server" placeholder="Kategori Adını Girin..." CssClass="form-control" ></asp:TextBox>
        </div>
        <br />
        <div>
            <strong>
            <asp:Button ID="BtnKtgrGuncelle" runat="server" CssClass="btn btn-default" Text="Kategori Güncelle" style="font-weight: bold; background-color: #CCCCCC" OnClick="BtnKtgrGuncelle_Click"   />
            </strong>
        </div>
    </form>

</asp:Content>
