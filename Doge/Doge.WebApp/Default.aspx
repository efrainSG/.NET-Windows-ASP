<%@ Page Title="Orders" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Doge.WebApp._Default" %>
<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div class="jumbotron" style="background-color: #e4e6e9">
        <asp:Timer ID="Timer1" runat="server" Interval="1000" OnTick="Timer1_Tick1"></asp:Timer>
        <asp:DataList ID="DataList1" runat="server">
            <ItemTemplate>
                <asp:Panel runat="server">
                    <asp:Label ID="Label1" runat="server" Text='<%# Eval("OrderId") %>' CssClass="text-150 text-600 text-primary-d1"></asp:Label><br />
                    <asp:Label ID="Label2" runat="server" CssClass='<%# Eval("StatusClass") %>' Text='<%# Eval("Status") %>'></asp:Label><br />
                    <asp:Label ID="Label3" runat="server" Text='<%# Eval("DeliverAddress") %>' CssClass="text-secondary-d1"></asp:Label><br />
                    <asp:Label ID="Label4" runat="server" Text='<%# Eval("RemainingTime") %>' CssClass="text-secondary-d1"></asp:Label>
                </asp:Panel>
            </ItemTemplate>
        </asp:DataList>
    </div>
</asp:Content>
