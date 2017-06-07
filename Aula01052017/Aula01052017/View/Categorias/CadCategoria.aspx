<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CadCategoria.aspx.cs" Inherits="Aula01052017.View.Categorias.CadCategoria" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <br />
    Tipo:
    <asp:TextBox ID="TxtTipo" runat="server"></asp:TextBox>
    <asp:RequiredFieldValidator ID="RFVTipo" ControlToValidate="TxtTipo" runat="server" ErrorMessage="Campo Obrigatório"></asp:RequiredFieldValidator>
    <br />
    Descrição:
    <asp:TextBox ID="TxtDescricao" runat="server"></asp:TextBox>
    <br />
    <br />
    <asp:Button ID="BtnSalvar" runat="server" Text="Salvar" OnClick="BtnSalvar_Click" />
    <asp:Button ID="BtnCancelar" runat="server" Text="Limpar" OnClick="BtnCancelar_Click" />


</asp:Content>
