<%@ Page Title="" Language="C#" MasterPageFile="~/admin.Master" AutoEventWireup="true" CodeBehind="house_allocation.aspx.cs" Inherits="houses.house_allocation" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <script type="text/javascript">
        $(document).ready(function () {
            $(".table").prepend($("<thead></thead>").append($(this).find("tr:first"))).dataTable();
        })
    </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <br />
    <br />
    <div class="container">
        <div class="row">
            <div class="col-md-6 ">
                <div class="card">
                    <div class="card-body">
                        <div class="row">
                            <div class="col">
                                <h5>Allocate House To Members</h5>
                            </div>
                        </div>
                        <div class="row">
                            <div class="col">
                                <label>Member ID</label>
                                <div class="form-group input-group">
                                    <asp:TextBox ID="TextBox8" CssClass="form-control" runat="server"></asp:TextBox>
                                    <asp:LinkButton class=" btn btn-primary" ID="LinkButton3" runat="server" OnClick="LinkButton3_Click" Width="67px" ><i class="fas fa-check"></i></asp:LinkButton>
                                </div>
                            </div>
                        </div>
                        <div class="row">
                            <div class="col-md-6">
                                <label>First Name</label>
                                <div class="form-group">
                                    <asp:TextBox ID="TextBox1" class="form-control" placeholder="first name" runat="server"></asp:TextBox>
                                </div>
                            </div>
                            <div class="col-md-6">
                                <label>Last Name</label>
                                <div class="form-group">
                                    <asp:TextBox ID="TextBox2" class="form-control" placeholder="Last Name" runat="server"></asp:TextBox>
                                </div>
                            </div>
                        </div>
                        <div class="row">
                            <div class="col-md-6">
                                <label>Phone Number</label>
                                <div class="form-group">
                                    <asp:TextBox ID="TextBox3" TextMode="Number" class="form-control" placeholder="Mobile number" runat="server"></asp:TextBox>
                                </div>
                            </div>
                            <div class="col-md-6">
                                <label>Email Address</label>
                                <div class="form-group">
                                    <asp:TextBox ID="TextBox4" TextMode="Email" class="form-control" placeholder="email" runat="server"></asp:TextBox>
                                </div>
                            </div>
                        </div>

                        <div class="row">
                            <div class="col-md-6">
                                <label>Apartment</label>
                                <div class="form-group">
                                     <asp:DropDownList ID="DropDownList1"  CssClass="form-control" runat="server">
                                        <asp:ListItem Value="10" Text="10"></asp:ListItem>
                                         <asp:ListItem Value="10" Text="10"></asp:ListItem>
                                         <asp:ListItem Value="10" Text="10"></asp:ListItem>
                                    </asp:DropDownList>
                                </div>
                            </div>
                            <div class="col-md-6">
                                <label>House Number</label>
                                <div class="form-group">
                                    <asp:TextBox ID="TextBox6"  TextMode="Number"   class="form-control" placeholder="House Number" runat="server"></asp:TextBox>
                                </div>
                            </div>
                        </div>

                        <div class="row">
                            <div class="col">
                                <label>Image</label>
                                <div class="form-group">
                                    <asp:FileUpload ID="FileUpload1" CssClass="form-control" runat="server" />
                                </div>
                            </div>
                        </div>

                         <div class="row">
                            <div class="col-md-6">
                                <label>Username</label>
                                <div class="form-group">
                                    <asp:TextBox ID="TextBox5"  class="form-control" placeholder="usename" runat="server"></asp:TextBox>
                                </div>
                            </div>
                            <div class="col-md-6">
                                <label>Password</label>
                                <div class="form-group">
                                    <asp:TextBox ID="TextBox7" TextMode="Password" class="form-control" placeholder="email" runat="server"></asp:TextBox>
                                </div>
                            </div>
                        </div>

                     <div class="row">
                    <div class="col-md-6 ">
                        <asp:LinkButton ID="LinkButton1" runat="server" CssClass="btn btn-primary btn-block" OnClick="LinkButton1_Click">Add </asp:LinkButton>
                    </div>
                         <div class="col-md-6">
                        <asp:LinkButton ID="LinkButton2" runat="server" CssClass="btn btn-danger btn-block" OnClick="LinkButton2_Click">Delete</asp:LinkButton>
                    </div>
                </div>
                    </div>
                </div>
            </div>
            
        <div class="col-md-6">
            
            <div class="row">
                <div class="col">
                    <center>
                        <h6>Member Information</h6>
                    </center>
                    <hr />
                </div>
            </div>
                   
                <div class="row">
                    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:housesConnectionString %>" SelectCommand="SELECT * FROM [member]"></asp:SqlDataSource>
                    <div class="col">
                          <asp:GridView ID="GridView1" class="table table-striped" runat="server" AutoGenerateColumns="False" DataKeyNames="member_ID" DataSourceID="SqlDataSource1">
                              <Columns>
                                  <asp:BoundField DataField="member_ID" HeaderText="member_ID" ReadOnly="True" SortExpression="member_ID" />
                                  <asp:BoundField DataField="firstname" HeaderText="firstname" SortExpression="firstname" />
                                  <asp:BoundField DataField="lastname" HeaderText="lastname" SortExpression="lastname" />
                                  <asp:BoundField DataField="phone" HeaderText="phone" SortExpression="phone" />
                                  <asp:BoundField DataField="email" HeaderText="email" SortExpression="email" />
                                  <asp:BoundField DataField="apartment_name" HeaderText="apartment_name" SortExpression="apartment_name" />
                                  <asp:BoundField DataField="username" HeaderText="username" SortExpression="username" />
                              </Columns>
                          </asp:GridView>
                    </div>
                </div>
    </div>
            </div>
        
       
       
    </div>
    

    
</asp:Content>
