<%@ Page Title="" Language="C#" MasterPageFile="~/SiteAdmin.Master" AutoEventWireup="true" CodeBehind="Category.aspx.cs" Inherits="SaleWebForm.WebForm1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <form id="formCategory" runat="server">
        <div class="container-fluid px-4 mt-4">
            <div class="row">
                <div class="card mb-4 p-0">
                    <div class="card-header">
                        Category
                    </div>
                    <div class="card-body">
                        <div class="dataTable-wrapper dataTable-loading no-footer sortable searchable fixed-columns">
                            <div class="align-items-center d-flex justify-content-between mb-2">
                                <div class="dataTable-dropdown">
                                    <label>
                                        Show
                                        <asp:DropDownList ID="DropDownListNumOfItemInPage" runat="server" CssClass="dataTable-selector" OnSelectedIndexChanged="DropDownListNumOfItemInPage_SelectedIndexChanged" AutoPostBack="true">
                                            <asp:ListItem Value="5" Selected="True">5</asp:ListItem>
                                            <asp:ListItem Value="10">10</asp:ListItem>
                                            <asp:ListItem Value="25">25</asp:ListItem>
                                            <asp:ListItem Value="50">50</asp:ListItem>
                                        </asp:DropDownList>
                                        Item
                                    </label>
                                </div>

                                <div class="d-flex flex-row align-items-center">
                                    <button type="button" class="btn btn-primary mx-2 btn-modal btn-add" data-bs-toggle="modal" data-bs-target="#exampleModal">Add</button>
                                    <div class="dataTable-search">
                                        <input class="dataTable-input" placeholder="Search ..." type="text" />
                                    </div>
                                </div>
                            </div>

                            <div class="dataTable-container">
                                <asp:Literal ID="LiteralTable" runat="server"></asp:Literal>
                            </div>

                            <div class="dataTable-bottom">
                                <asp:Literal ID="LiteralPaginationInfo" runat="server"></asp:Literal>
                                <asp:Literal ID="LiteralPagination" runat="server"></asp:Literal>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>


        <div class="modal fade" id="exampleModal" data-bs-backdrop="static" tabindex="-1" aria-labelledby="exampleModalLabel" aria-hidden="true">
            <div class="modal-dialog">
                <div class="modal-content">
                    <div class="modal-header">
                        <%--<h5 class="modal-title" id="exampleModalLabel"> </h5>--%>
                        <button type="button" class="btn-close" data-bs-dismiss="modal" aria-label="Close"></button>
                    </div>

                    <div class="modal-body">
                        <div class="mb-3">
                            <label for="TextBoxAddName" class="col-form-label">Tên danh mục:</label>
                            <asp:TextBox ID="TextBoxAddName" runat="server" CssClass="form-control"></asp:TextBox>
                        </div>
                        <div class="mb-3">
                            <label for="TextBoxAddDesc" class="col-form-label">Mô tả:</label>
                            <asp:TextBox ID="TextBoxAddDesc" runat="server" CssClass="form-control" TextMode="MultiLine"></asp:TextBox>
                        </div>
                    </div>

                    <div class="modal-footer">
                        <button type="button" class="btn btn-secondary" data-bs-dismiss="modal">Cancel</button>
                        <asp:Button ID="ButtonAdd" CssClass="btn btn-primary" runat="server" Text="Save" OnClick="ButtonSave_Click" />
                    </div>
                </div>
            </div>
        </div>

        <asp:TextBox ID="mode" CssClass="d-none" runat="server"></asp:TextBox>
        <asp:TextBox ID="IdCateCur" CssClass="d-none" runat="server"></asp:TextBox>
        <asp:Button ID="ButtonDelete" runat="server" Text="Del" OnClick="ButtonDelete_Click" CssClass="d-none" /><asp:Literal ID="Literal1" runat="server"></asp:Literal>
    </form>

    <script>
        console.log("Nihta");

        // Chức năng xoá
        const btnDelete = document.getElementById('<%= ButtonDelete.ClientID %>');
        document.querySelectorAll(".btn-delete").forEach(e => {
            e.addEventListener("click", () => {
                // Lấy ID
                const id = e.parentElement.parentElement.children[0].textContent;
                document.getElementById('<%= IdCateCur.ClientID %>').value = id.toString();

                if (confirm("Bạn có chắc chắn xoá danh mục này không?")) {
                    btnDelete.click();
                }
            });
        });

        // Chuyển mode thành ADD
        document.querySelector(".btn-modal.btn-add").addEventListener("click", () => {
            document.getElementById('<%= mode.ClientID %>').value = "ADD";
        });

        // Chức năng sửa
        document.querySelectorAll(".btn-edit").forEach(e => {
            e.addEventListener("click", () => {
                // Lấy ID
                const id = e.parentElement.parentElement.children[0].textContent;
                document.getElementById('<%= IdCateCur.ClientID %>').value = id.toString();

                // Lấy dữ liệu
                document.getElementById('<%= TextBoxAddName.ClientID %>').value = e.parentElement.parentElement.children[1].textContent;
                document.getElementById('<%= TextBoxAddDesc.ClientID %>').value = e.parentElement.parentElement.children[2].textContent;

                // Mở modal
                document.querySelector(".btn-modal.btn-add").click();

                // Chuyển mode thành EDIT
                document.getElementById('<%= mode.ClientID %>').value = "EDIT";
            });
        })

    </script>
</asp:Content>
