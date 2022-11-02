<%@ Page Title="" Language="C#" MasterPageFile="~/admin.Master" AutoEventWireup="true" CodeBehind="adminpage.aspx.cs" Inherits="houses.adminpage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
        <div class="mainmain">
            <div class="sidebar">
                <ul class="item">
      <li>
        <a class="text2 font-weight-bold text-dark  mr-3"  href="adminpage.aspx">DashBoard</a>
      </li>
      <li>
          <asp:LinkButton ID="addlocation"  CssClass="text2 font-weight-bold text-dark mr-3" runat="server" OnClick="addlocation_Click"  >Add_Apartment</asp:LinkButton>
      </li>
        <li>
          <asp:LinkButton ID="addhouse"  CssClass="text2 font-weight-bold text-dark  mr-3 " runat="server" OnClick="addhouse_Click"  >Add_House</asp:LinkButton>
      </li>
        <li>
          <asp:LinkButton ID="allocation"  CssClass="text2 font-weight-bold text-dark  mr-3" runat="server" OnClick="allocation_Click"  > House_Allocation</asp:LinkButton>
      </li>
         <li>
          <asp:LinkButton ID="houseinfo" CssClass="text2 font-weight-bold text-dark  mr-3" runat="server" OnClick="houseinfo_Click"  >House_info</asp:LinkButton>
      </li>
         
      <li>
          <asp:LinkButton ID="complains" CssClass="text2 font-weight-bold text-dark  mr-3" runat="server" OnClick="complains_Click" >Complains</asp:LinkButton>
      </li>
     
        <li>
          <asp:LinkButton ID="rentalinfo" CssClass="text2 font-weight-bold text-dark  mr-3" runat="server" OnClick="rentalinfo_Click">Rentals</asp:LinkButton>
      </li>
         <li>
          <asp:LinkButton ID="logout" CssClass="text2 font-weight-bold text-dark  mr-3" runat="server" OnClick="logout_Click">Logout</asp:LinkButton>
      </li>
        
    </ul>
            </div>
            <div class="content">
                <br />
                <br />
                <div class="row">
                    <div class="col-md-4">
                        <div class="card">
                            <div class="card-body" style="height:150px;">
                                    content<br />
                                <br />
                                <br />
                            </div>
                        </div>
                    </div>
                    <div class="col-md-4">
                       <div class="card">
                            <div class="card-body" style="height:150px;">
                                    content<br />
                                <br />
                                <br />
                            </div>
                        </div>
                    </div>
                    <div class="col-md-4">
                        <div class="card">
                            <div class="card-body" style="height:150px;">
                                    content<br />
                                <br />
                                <br />
                            </div>
                        </div>
                    </div>
                </div>
                 <br />
                    <br />
                <div class="row">
                    <div class="col-md-4">
                       <div class="card">
                            <div class="card-body" style="height:150px;">
                                    content<br />
                                <br />
                                <br />
                            </div>
                        </div>
                    </div>
                    <div class="col-md-4">
                        <div class="card">
                            <div class="card-body" style="height:150px;">
                                    content<br />
                                <br />
                                <br />
                            </div>
                        </div>
                    </div>
                    <div class="col-md-4">
                        <div class="card">
                            <div class="card-body" style="height:150px;">
                                    content<br />
                                <br />
                                <br />
                            </div>
                        </div>
                    </div>
                    
                </div>
            </div>
        </div>
    </div>
    <br />
    <br />
</asp:Content>
