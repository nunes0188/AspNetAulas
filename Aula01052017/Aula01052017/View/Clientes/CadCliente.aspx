<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CadCliente.aspx.cs" Inherits="Aula01052017.View.Clientes.CadCliente" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
      <br />
    Nome:
    <asp:TextBox ID="TxtNome" runat="server"></asp:TextBox>
    <asp:RequiredFieldValidator ID="RFVNome" ControlToValidate="TxtNome" runat="server" ErrorMessage="Campo Obrigatório"></asp:RequiredFieldValidator>
    <br />
    Sobre Nome:
    <asp:TextBox ID="TxtSNome" runat="server"></asp:TextBox>
    <asp:RequiredFieldValidator ID="RFVSNome" ControlToValidate="TxtSNome" runat="server" ErrorMessage="Campo Obrigatório"></asp:RequiredFieldValidator>
    <br />
    CPF:
    <asp:TextBox ID="TxtCPF" runat="server"></asp:TextBox>
    <asp:RequiredFieldValidator ID="RFVCPF" ControlToValidate="TxtCPF" runat="server" ErrorMessage="Campo Obrigatório"></asp:RequiredFieldValidator>
    <br />
    Endereço:
    <asp:TextBox ID="TxtEndereco" runat="server"></asp:TextBox>
    <asp:RequiredFieldValidator ID="RFVEndereco" ControlToValidate="TxtEndereco" runat="server" ErrorMessage="Campo Obrigatório"></asp:RequiredFieldValidator>
    <br />
    Tipo de Cliente:
    <asp:DropDownList ID="DLTipoCliente" runat="server" DataValueField="Id"></asp:DropDownList>
    <br />
    <asp:Button ID="BtnSalvar" runat="server" Text="Salvar" OnClick="BtnSalvar_Click" />
    <asp:Button ID="BtnCancelar" runat="server" Text="Limpar" OnClick="BtnCancelar_Click" />
</asp:Content>
