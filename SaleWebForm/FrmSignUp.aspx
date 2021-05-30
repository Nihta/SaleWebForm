<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FrmSignUp.aspx.cs" Inherits="SaleWebForm.FrmSignUp" %>

<!DOCTYPE html>

<!DOCTYPE html>
<html>

<head runat="server">
    <title>Đăng ký</title>
    <link rel="stylesheet" href="https://cdn.jsdelivr.net/npm/bootstrap@4.6.0/dist/css/bootstrap.min.css" />
</head>

<body>
    <main class="d-flex align-items-center min-vh-100 py-3 py-md-0">
        <div class="container d-flex justify-content-center">
            <div class="col-md-4">
                <asp:Label ID="LabelWarning" runat="server"></asp:Label>
                <h4 class="card-title mb-3">Đăng ký</h4>

                <form id="formLogin" runat="server">
                    <div>
                        <div class="form-group">
                            <label for="TextBoxFullName">Họ và tên</label>
                            <asp:TextBox ID="TextBoxFullName" runat="server" class="form-control" TextMode="SingleLine"></asp:TextBox>
                        </div>

                        <div class="form-group">
                            <label for="TextBoxUserName">Tên đăng nhập</label>
                            <asp:TextBox ID="TextBoxUserName" runat="server" class="form-control" TextMode="SingleLine"></asp:TextBox>
                        </div>

                        <div class="form-group">
                            <label for="TextBoxPassWord">Mật khẩu</label>
                            <asp:TextBox ID="TextBoxPassWord" runat="server" class="form-control" TextMode="Password"></asp:TextBox>
                        </div>

                        <div class="form-group">
                            <label for="TextBoxPassWord">Xác nhận mật khẩu</label>
                            <asp:TextBox ID="TextBoxPassWordRepeat" runat="server" class="form-control" TextMode="Password"></asp:TextBox>
                        </div>

                        <asp:Button ID="BtnSignup" runat="server" Text="Đăng ký" CssClass="btn btn-primary btn-block mb-4" OnClick="BtnSignup_Click" />
                    </div>
                </form>

                <p>Bạn có tài khoản? <a href="FrmLogin.aspx" class="text-reset">Đăng nhập ngay</a></p>
            </div>
        </div>
    </main>
</body>
</html>
