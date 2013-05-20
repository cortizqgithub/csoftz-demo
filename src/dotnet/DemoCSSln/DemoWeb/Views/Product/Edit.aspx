<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/demo.Master" Inherits="System.Web.Mvc.ViewPage<CSoftZ.Demo.Domain.View.Model.ProductViewModel>" %>

<%@ Import Namespace="CSoftZ.Demo.Common.Helper.Consts" %>
<asp:Content ID="titleContent" ContentPlaceHolderID="TitleContent" runat="server">Edit</asp:Content>
<asp:Content ID="mainContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Edit</h2>
    <div id="msg-box" style="display: none"></div>
    <% using (Html.BeginForm("Edit", "Product", null, FormMethod.Post, new { id = "productfrm" })) {%>
    <%: Html.ValidationSummary(true) %>
    <div class="editor-label"><%: Html.LabelFor(model => model.Name) %><%:  " *" %></div>
    <div class="editor-field">
        <%: Html.TextBoxFor(model => model.Name, new {title = "A descriptive name for product."}) %>
        <%: Html.ValidationMessageFor(model => model.Name) %>
    </div>
    <div class="editor-label"><%: Html.LabelFor(model => model.eMail) %><%:  " *" %></div>
    <div class="editor-field">
        <%: Html.TextBoxFor(model => model.eMail, new {title = "Contact eMail for product."}) %>
        <%: Html.ValidationMessageFor(model => model.eMail) %>
    </div>
    <div class="editor-label"><%: Html.LabelFor(model => model.Phone) %><%:  " *" %></div>
    <div class="editor-field">
        <%: Html.TextBoxFor(model => model.Phone, new {title = "Phone as a contact for product."}) %>
        <%: Html.ValidationMessageFor(model => model.Phone) %>
    </div>
    <div class="editor-label"><%: Html.LabelFor(model => model.Address) %><%:  " *" %></div>
    <div class="editor-field">
        <%: Html.TextBoxFor(model => model.Address, new {title = "Localization for product."}) %>
        <%: Html.ValidationMessageFor(model => model.Address) %>
    </div>
    <div class="editor-label"><%: Html.LabelFor(model => model.City) %><%:  " *" %></div>
    <div class="editor-field">
        <%: Html.TextBoxFor(model => model.City, new {title = "City where product is located."}) %>
        <%: Html.ValidationMessageFor(model => model.City) %>
    </div>
    <div class="editor-label"><%: Html.LabelFor(model => model.Estate) %><%:  " *" %></div>
    <div class="editor-field">
        <%: Html.TextBoxFor(model => model.Estate, new {title = "Estate where product is located."}) %>
        <%: Html.ValidationMessageFor(model => model.Estate) %>
    </div>
    <div class="editor-label"><%: Html.LabelFor(model => model.Country) %><%:  " *" %></div>
    <div class="editor-field">
        <%: Html.TextBoxFor(model => model.Country, new {title = "Country where product is located."}) %>
        <%: Html.ValidationMessageFor(model => model.Country) %>
    </div>
    <div class="editor-label"><%: Html.LabelFor(model => model.Active) %><%:  " *" %></div>
    <div class="editor-field">
        <%: Html.DropDownListFor(model => model.Active, new SelectList(ViewData[ViewConstants.VIEWDATA_YESNOVALUELIST] as IEnumerable, "Code", "Description"), new { title = "Indicates if product is enabled." })%>
        <%: Html.ValidationMessageFor(model => model.Active) %>
    </div>
    <p>(*) Required Fields.</p>
    <p><%: Html.HiddenFor(model => model.ProductId)%><input id="cmd" type="submit" value="Save" /></p>
    <% } %>
    <div>
        <%: Html.ActionLink("Back to List", "Index") %></div>
</asp:Content>
<asp:Content ID="headContent" ContentPlaceHolderID="HeadContent" runat="server">
    <script type="text/javascript">
    $(document).ready(function () {
        jQuerySetupEnvironmentForEditPages();
        setFormTooltips('productfrm');
        <%=   ViewData[ViewConstants.VIEWDATA_MSGBOX] %>
    });
    </script>
</asp:Content>
