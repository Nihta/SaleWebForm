<%@ Page Title="" Language="C#" MasterPageFile="~/SiteAdmin.Master" AutoEventWireup="true" CodeBehind="Category.aspx.cs" Inherits="SaleWebForm.WebForm1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <form id="formCategory" runat="server">
        <div class="container-fluid px-4">
            <h1>Quản lý loại hàng hoá</h1>
            <div class="row">
                <div class="card mb-4 p-0">
                    <div class="card-header">
                        Danh mục
                    </div>
                    <div class="card-body">
                        <div class="dataTable-wrapper dataTable-loading no-footer sortable searchable fixed-columns">
                            <div class="align-items-center d-flex justify-content-between mb-2">
                                <div class="dataTable-dropdown">
                                    <label>
                                        Hiển thị
                                    <select class="dataTable-selector">
                                        <option value="5">5</option>
                                        <option value="10" selected="">10</option>
                                        <option value="15">15</option>
                                        <option value="20">20</option>
                                        <option value="25">25</option>
                                    </select>
                                        mục
                                    </label>
                                </div>

                                <div class="d-flex flex-row align-items-center">
                                    <button type="button" class="btn btn-primary mx-2" data-bs-toggle="modal" data-bs-target="#exampleModal">Thêm</button>
                                    <div class="dataTable-search">
                                        <input class="dataTable-input" placeholder="Tìm kiếm ..." type="text" />
                                    </div>
                                </div>
                            </div>

                            <div class="dataTable-container">
                                <asp:Literal ID="LiteralTable" runat="server"></asp:Literal>
                            </div>

                            <div class="dataTable-bottom">
                                <div class="dataTable-info">Hiển thị 1 tới 10 trên 50 danh mục</div>
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
                        <h5 class="modal-title" id="exampleModalLabel">Thêm danh mục mới</h5>
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
                        <button type="button" class="btn btn-secondary" data-bs-dismiss="modal">Huỷ</button>
                        <asp:Button ID="ButtonAdd" CssClass="btn btn-primary" runat="server" Text="Thêm" OnClick="ButtonAdd_Click" />
                    </div>
                </div>
            </div>
        </div>
    </form>
</asp:Content>
