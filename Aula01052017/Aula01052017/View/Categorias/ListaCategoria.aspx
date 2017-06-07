<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ListaCategoria.aspx.cs" Inherits="Aula01052017.View.Categorias.ListaCategoria" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <br />
    
    <asp:GridView ID="gvCategorias" runat="server" OnRowCommand="gvCategorias_RowCommand">
        <Columns>
            <asp:ButtonField CommandName="Excluir" Text="Excluir" />
            <asp:ButtonField CommandName="Editar" Text="Editar" />
        </Columns>
    </asp:GridView>
</asp:Content>
