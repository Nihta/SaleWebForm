using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SaleWebForm
{
    public class TableHelpers
    {
        public static string MakeThead(params string[] colNames)
        {
            string html = "";
            foreach (string colName in colNames)
            {
                html += $"<th data-sortable='' class=''><a href='#' class='dataTable-sorter'>{colName}</a></th>";
            }

            html += $"<th style='width: 80px'>Hành động</th>";

            return $"<thead><tr>{html}</tr></thead>";
        }

        public static string MakeRow(params string[] colValues)
        {
            string html = "";
            foreach (string colValue in colValues)
            {
                html += $"<td>{colValue}</td>";
            }

            html += "<td class='d-flex'><span class='text-primary btn d-block btn-edit'>Sửa </span><span class='text-primary btn d-block btn-delete'>Xoá</span></td>";

            return $"<tr>{html}</tr>";
        }

        public static string MakeTable(string thead, string tbody, string tableId = "table-nihta")
        {
            return $"<table id='{tableId}' class='dataTable-table'>{thead}<tbody>{tbody}</tbody></table>";
        }

        public static string MakePagination(int min, int max, int cur)
        {

            string content = "";

            content += $"<li class='page-item {(cur == min ? "disabled" : "")}'><a class='page-link' href='#' tabindex='-1' aria-disabled='{(cur == min ? "true" : "false")}'>Trước</a></li>";

            for (int i = min; i <= max; i++)
            {
                content += $"<li class='page-item {(cur == i ? "active" : "")}'><a class='page-link' href='#'>{i}</a></li>";
            }

            content += $"<li class='page-item {(cur == max ? "disabled" : "")}'><a class='page-link' href='#' tabindex='-1' aria-disabled='{(cur == max ? "true" : "false")}'>Sau</a></li>";

            return $"<nav><ul class='pagination'>{content}</ul></nav>";
        }
    }
}