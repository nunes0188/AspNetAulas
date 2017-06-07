<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CadastraCategoria.aspx.cs" Inherits="Aula250517.View.Categorias.CadastraCategoria" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

            Nome:
    <asp:TextBox ID="TxtNome" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RFVNome" ControlToValidate="TxtNome" runat="server" ErrorMessage="Campo Obrigatório"></asp:RequiredFieldValidator>
            <br />
            Descrição:
    <asp:TextBox ID="TxtDescricao" runat="server"></asp:TextBox>
            <br />
            <asp:CheckBox ID="ChkAtivo" runat="server" />
            Ativo
    <br />
            <asp:Button ID="BtnSalvar" runat="server" Text="Salvar" OnClick="BtnSalvar_Click" />
            <asp:Button ID="BtnCancelar" runat="server" Text="Button" />


</asp:Content>
