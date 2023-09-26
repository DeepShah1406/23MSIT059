<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="_23MSIT059.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div align ="center">
            <h2> Student Data </h2><asp:GridView ID="gridvStudent" runat="server"></asp:GridView>
            <br />
            Student ID : <asp:TextBox ID="txtsid" runat="server"></asp:TextBox>
            <br />
            Student Name : <asp:TextBox ID="txtsname" runat="server"></asp:TextBox>
            <asp:RangeValidator ID="RangeValidator5" runat="server" ControlToValidate="txtsname" ErrorMessage="Not more than 12 characters" ForeColor="Red" MaximumValue="12"></asp:RangeValidator>
            <br />
            Prog : <asp:TextBox ID="txtprog" runat="server"></asp:TextBox>
            <%--<asp:RegularExpressionValidator ID="rev1" runat="server" ControlToValidate="txtprog" ValidationExpression="\w{MSIT,MCA}" ErroorMeaasge="Please enter a valid Program" ForeColor="Red" ErrorMessage="Either MSIT or MCA"></asp:RegularExpressionValidator>--%>
            <br />
            Sem : <asp:TextBox ID="txtsem" runat="server"></asp:TextBox>
            <asp:RangeValidator ID="RangeValidator2" runat="server" ControlToValidate="txtsem" ErrorMessage="Only from 1 to 4." ForeColor="Red" MaximumValue="4" MinimumValue="1"></asp:RangeValidator>
            <br />
            Sub1Mark : <asp:TextBox ID="txts1m" runat="server"></asp:TextBox>
            <asp:RangeValidator ID="RangeValidator1" runat="server" ControlToValidate="txts1m" ErrorMessage="Only Digit(s), between 0 to 100" ForeColor="Red" MaximumValue="100" MinimumValue="0" Type="Integer"></asp:RangeValidator>
            <br />
            Sub2Mark : <asp:TextBox ID="txts2m" runat="server"></asp:TextBox>
            <asp:RangeValidator ID="RangeValidator3" runat="server" ControlToValidate="txts2m" ErrorMessage="Only Digit(s), between 0 to 100" ForeColor="Red" MaximumValue="100" MinimumValue="0" Type="Integer"></asp:RangeValidator>
            <br />
            Sub3Mark : <asp:TextBox ID="txts3m" runat="server"></asp:TextBox>
            <asp:RangeValidator ID="RangeValidator4" runat="server" ControlToValidate="txts3m" ErrorMessage="Only Digit(s), between 0 to 100" ForeColor="Red" MaximumValue="100" MinimumValue="0" Type="Integer"></asp:RangeValidator>
            <br />
            Total : <asp:TextBox ID="txttotal" runat="server"></asp:TextBox>
            <br />
            Per : <asp:TextBox ID="txtper" runat="server"></asp:TextBox>
            <br />
            <asp:Button ID="tbnInsert" Text="Insert" runat="server" OnClick="tbnInsert_Click" />
            &nbsp;&nbsp;
            <asp:Button ID="btnUpdate" Text="Update" runat="server" OnClick="btnUpdate_Click" />
            &nbsp;&nbsp;
            <asp:Button ID="btnDelete" Text="Delete" runat="server" OnClick="btnDelete_Click" />
            &nbsp;&nbsp;
            <asp:Button ID="btnSelect" Text="Select" runat="server" OnClick="btnSelect_Click" />
        </div>
    </form>
</body>
</html>
