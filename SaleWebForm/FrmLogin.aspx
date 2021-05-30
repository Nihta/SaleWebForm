<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FrmLogin.aspx.cs" Inherits="SaleWebForm.FrmLogin" %>

<!DOCTYPE html>

<html>
<head runat="server">
    <title>Đăng nhập</title>
    <link rel="stylesheet" href="https://cdn.jsdelivr.net/npm/bootstrap@4.6.0/dist/css/bootstrap.min.css" />
</head>

<body>
    <main class="d-flex align-items-center min-vh-100 py-3 py-md-0">
        <div class="container d-flex justify-content-center">
            <div class="col-md-4">
                <asp:Label ID="LabelWarning" runat="server"></asp:Label>
                <h4 class="card-title mb-3">Đăng nhập</h4>
                <form id="formLogin" runat="server">
                    <div>
                        <div class="form-group">
                            <label for="TextBoxUserName">Tên đăng nhập</label>
                            <asp:TextBox ID="TextBoxUserName" runat="server" class="form-control" TextMode="SingleLine"></asp:TextBox>
                        </div>

                        <div class="form-group">
                            <label for="TextBoxPassWord">Mật khẩu</label>
                            <asp:TextBox ID="TextBoxPassWord" runat="server" class="form-control" TextMode="Password"></asp:TextBox>
                        </div>

                        <asp:Button ID="BtnLogin" runat="server" Text="Đăng nhập" CssClass="btn btn-primary btn-block mb-4" OnClick="BtnLogin_Click" />
                    </div>
                </form>
                <a href="CommingSoon.html" class="forgot-password-link">Quên mật khẩu?</a>

                <p>Bạn không có tài khoản? <a href="WebFormSignUp.aspx" class="text-reset">Đăng ký</a></p>
            </div>
        </div>
    </main>
</body>
</html>
