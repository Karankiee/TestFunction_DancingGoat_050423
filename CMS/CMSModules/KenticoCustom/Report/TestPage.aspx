<%@ Page Language="C#" AutoEventWireup="true" CodeFile="TestPage.aspx.cs" Inherits="TestPage" Theme="Default" %>

<%@ Register Src="~/CMSAdminControls/UI/UniGrid/UniGrid.ascx" TagName="UniGrid" TagPrefix="cms" %>
<%@ Register Namespace="CMS.UIControls.UniGridConfig" TagPrefix="ug" Assembly="CMS.UIControls" %>


<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.0-alpha3/dist/css/bootstrap.min.css" rel="stylesheet"
        integrity="sha384-KK94CHFLLe+nY2dmCWGMq91rCGa5gtU4mk92HdvYe+M/SXH301p5ILy+dN9+nJOZ" crossorigin="anonymous">
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.3.0-alpha3/dist/js/bootstrap.bundle.min.js"
        integrity="sha384-ENjdO4Dr2bkBIFxQpeoTz1HIcje39Wm4jDKdf19U8gI4ddQ3GYNS7NTKfAdVQSZe"
        crossorigin="anonymous"></script>
    <script src="https://code.jquery.com/jquery-3.6.4.js" integrity="sha256-a9jBBRygX1Bh5lt8GZjXDzyOB+bWve9EiO7tROUtj/E="
        crossorigin="anonymous"></script>

</head>
<body>
    <form id="form1" runat="server">
        <asp:ScriptManager ID="ScriptManager" runat="server" />

        <div class="cms-bootstrap">

            <div class="form-horizontal form-filter">

                <div class="form-group">
                    <div class="filter-form-label-cell">
                        <asp:Label ID="lblSubject" runat="server" Text="Subject :" class="control-label"></asp:Label>
                    </div>
                    <div class="filter-form-value-cell-wide">
                        <asp:DropDownList ID="ddlSubject" runat="server" DataTextField="Text" DataValueField="Text" CssClass="form-control">
                        </asp:DropDownList>
                    </div>
                </div>

                <div class="form-group">
                    <div class="filter-form-label-cell">
                        <asp:Label ID="lblTitleName" runat="server" Text="TitleName :" class="control-label"></asp:Label>
                    </div>
                    <div class="filter-form-value-cell-wide">
                        <asp:DropDownList ID="ddlTitleName" runat="server" DataTextField="Text" DataValueField="Text" CssClass="form-control">
                        </asp:DropDownList>
                    </div>
                </div>

                <div class="form-group">
                    <div class="filter-form-label-cell">
                        <asp:Label ID="lblStratDate" runat="server" Text="Start Date :" class="control-label"></asp:Label>
                    </div>
                    <div class="filter-form-value-cell-wide">
                        <cms:DateTimePicker ID="txtStratDate" runat="server" />
                    </div>
                </div>

                <div class="form-group">
                    <div class="filter-form-label-cell">
                        <asp:Label ID="lblEndDate" runat="server" Text="End Date :" class="control-label"></asp:Label>
                    </div>
                    <div class="filter-form-value-cell-wide">
                        <cms:DateTimePicker ID="txtEndDate" runat="server" />
                    </div>
                </div>

            </div>

            <asp:Button ID="btnSearch" CssClass="btn btn-primary" runat="server" Text="Search" OnClick="btnSearch_Click" />
            <asp:Button ID="btnExport" CssClass="btn btn-success" runat="server" Text="Export" OnClick="btnExport_Click" />
            <asp:Button ID="btnReset" CssClass="btn btn-default" runat="server" Text="Reset" OnClick="btnReset_Click" />

            <asp:UpdatePanel ID="udpGrid" runat="server" UpdateMode="Conditional">
                <ContentTemplate>
                    <cms:UniGrid ID="FormGrid" runat="server" ShowExportMenu="false" ExportFileName="FormGrid">

                        <GridColumns>
                            <ug:Column Source="E_FromID" Caption="E_FromID" Wrap="false" runat="server">
                            </ug:Column>
                            <ug:Column Source="ddlSubject" Caption="ddlSubject" Wrap="false" runat="server">
                            </ug:Column>
                            <ug:Column Source="TitleName" Caption="TitleName" Wrap="false" runat="server">
                            </ug:Column>
                            <ug:Column Source="Name" Caption="Name" Wrap="false" runat="server">
                            </ug:Column>
                            <ug:Column Source="SurName" Caption="SurName" Wrap="false" runat="server">
                            </ug:Column>
                            <ug:Column Source="Email" Caption="Email" Wrap="false" runat="server">
                            </ug:Column>
                            <ug:Column Source="Phone" Caption="Phone" Wrap="false" runat="server">
                            </ug:Column>
                            <ug:Column Source="Image1" Caption="Image1" Wrap="false" runat="server"
                                Name="Image1" ExternalSourceName="#Image1">
                            </ug:Column>
                            <ug:Column Source="Image2" Caption="Image2" Wrap="false" runat="server"
                                Name="Image2" ExternalSourceName="#Image2">
                            </ug:Column>
                            <ug:Column Source="Image3" Caption="Image3" Wrap="false" runat="server"
                                Name="Image3" ExternalSourceName="#Image3">
                            </ug:Column>
                            <ug:Column Source="Image4" Caption="Image4" Wrap="false" runat="server"
                                Name="Image4" ExternalSourceName="#Image4">
                            </ug:Column>
                            <ug:Column Source="Image5" Caption="Image5" Wrap="false" runat="server"
                                Name="Image5" ExternalSourceName="#Image5">
                            </ug:Column>
                            <ug:Column Source="FormInserted" Caption="FormInserted" Wrap="false" runat="server">
                            </ug:Column>
                            <ug:Column Source="FormUpdated" Caption="FormUpdated" Wrap="false" runat="server">
                            </ug:Column>
                        </GridColumns>

                        <PagerConfig DefaultPageSize="1" />
                        <GridOptions ShowSelection="false" />

                    </cms:UniGrid>
                </ContentTemplate>
            </asp:UpdatePanel>
        </div>

        <div class="modal" id="exampleModal" tabindex="-1" aria-labelledby="exampleModalLabel" aria-hidden="true">
            <div class="modal-dialog">
                <div class="modal-content">
                    <div class="modal-header">
                        <h1 class="modal-title fs-5" id="exampleModalLabel">Modal title</h1>
                        <button type="button" class="btn-close" data-bs-dismiss="modal" aria-label="Close"></button>
                    </div>
                    <div class="modal-body text-center">

                        <img class="js-modalImage" width="400" height="150" scr="" />

                    </div>
                    <div class="modal-footer">
                        <button type="button" class="btn btn-secondary" data-bs-dismiss="modal">Close</button>
                    </div>
                </div>
            </div>
        </div>

        <script>
            document.querySelectorAll(".js-getModalSRC").forEach((element) => {
                element.addEventListener("click", () => {
                    document.querySelector("#exampleModal .js-modalImage").setAttribute("src", element.querySelector("img").getAttribute("src"));
                });
            });

            document.getElementById('exampleModal').addEventListener('hide.bs.modal', function (event) {
                document.getElementById('exampleModal').querySelector(".js-modalImage").setAttribute("src", "")
            });
        </script>

        <%--<script>
            var prm = Sys.WebForms.PageRequestManager.getInstance();
            if (prm != null) {

                prm.add_initializeRequest((sender, args) => {
                    console.log("1");
                });

                prm.add_endRequest((sender, args) => {
                    console.log("2");
                });
            }
        </script>--%>
    </form>
</body>
</html>
