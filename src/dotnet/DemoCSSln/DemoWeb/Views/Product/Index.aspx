<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/demo.Master" Inherits="System.Web.Mvc.ViewPage<ProductViewModel>" %>
<%@ Import Namespace="CSoftZ.Demo.Common.Helper.Consts" %>
<asp:Content ID="TitleContent" ContentPlaceHolderID="TitleContent" runat="server">Product Catalogue</asp:Content>
<asp:Content ID="MainContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Product Catalogue</h2>
    <div id="msg-box" style="display:none"></div>
    <%: Html.ActionLink("New", "Create") %>
     <br />

<% using (Html.BeginForm()) {%>
<br />
Filter by:
<%: Html.DropDownListFor(m => m.SearchCriteria, new SelectList(ViewData[ViewConstants.VIEWDATA_FILTERCRITERIALIST] as IEnumerable, "Code", "Description"))%>
With:
<%: Html.TextBoxFor(model => model.SearchData) %>
<input id="search" type="submit" value="Search" />
<%: Html.HiddenFor(model => model.SearchCriteriaHidden) %>
<%: Html.HiddenFor(model => model.SearchDataHidden) %>
<%: Html.HiddenFor(model => model.PreserveCriteria)%>
<br />
    <% Html.Telerik().Grid<ProductInfo>(Model.ProductList)
        .Name("g")
        .Columns(columns => {
            columns.Template(o => {
                %><input type="checkbox" name="recToDel" value="<%: o.ProductId %>" /><%
            }).Title("<input type='checkbox' name='chkAll' id='chkAll'/>").Width(15);
            columns.Template(o => {
                %><a href='<%:Url.Action("Edit", "Product") + "/" + o.ProductId %>'>Edit</a> <%
            }).Title("Edit").Width(50);
            columns.Bound(o => o.Name).Width(50);
            columns.Bound(o => o.Address).Width(50);
            columns.Bound(o => o.Phone).Width(50);
        })
        .DataBinding(dataBinding => {
            dataBinding.Server().Select("Index", "Product", new {sch = Model.SearchCriteriaHidden, sdh= Model.SearchDataHidden, ps=Model.PageSize});
        })
        .Scrollable(scrolling => scrolling.Enabled(false))
        .Pageable(pager => pager.PageSize(Model.PageSize))
        .Sortable()
        .Footer(true)
        .Render();
    %>
    <input type="hidden" name="delRecsUsed" id="delRecsUsed" />
    <input type="button" name="delRecs" id="delRecs" value="Remove"/>
    Show: <%: Html.DropDownListFor(m => m.PageSize, new SelectList(ViewData[ViewConstants.VIEWDATA_PAGESIZELIST] as IEnumerable, "Code", "Description"))%>
Records
<%}%>
    
</asp:Content>
<asp:Content ID="HeadContent" ContentPlaceHolderID="HeadContent" runat="server">
<script type="text/javascript">
        $(document).ready(function () {
            jQuerySetupEnvironmentForGridPages();
        });
</script>
</asp:Content>
