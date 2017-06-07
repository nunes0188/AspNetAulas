<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ListaCliente.aspx.cs" Inherits="Aula01052017.View.Clientes.ListaCliente" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <br />
    <asp:GridView ID="gvClientes" runat="server" OnRowCommand="gvClientes_RowCommand">
        <Columns>
            <asp:ButtonField CommandName="Excluir" Text="Excluir" />
            <asp:ButtonField CommandName="Editar" Text="Editar" />
        </Columns>

    </asp:GridView>
</asp:Content>
