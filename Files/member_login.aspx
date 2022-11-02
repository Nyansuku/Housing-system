<%@ Page Title="" Language="C#" MasterPageFile="~/main.Master" AutoEventWireup="true" CodeBehind="member_login.aspx.cs" Inherits="houses.member_login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <br />
    <br />
    <div class="container">
        <div class="row">
            <div class="col-md-4">
                <h2 class="font-weight-bold" style="margin-top:150px;">Login</h2>
            </div>
            
            <div class="col-md-6">
                
                    <div class="row">
                        <div class="col">
                            
                           <h4 class="font-weight-bold">Login To Your Account <span class="text-danger">Here</span></h4>
                           
                        </div>
                    </div>
                        <br />
                   

                    <div class="row">
                        <div class="col">
                            <label>Username(required)</label>
                            <div class="form-group">
                                <asp:TextBox ID="TextBox1" CssClass="form-control" runat="server" placeholder="username" BackColor="Black" ForeColor="White" Height="50"></asp:TextBox>
                            </div>
                        </div>
                    </div>

                    <div class="row">
                        <div class="col">
                            <label>Password</label>
                            <div class="form-group">
                                <asp:TextBox ID="TextBox2" CssClass="form-control" runat="server" placeholder="password" TextMode="Password" ForeColor="White" BackColor="Black" Height="50"></asp:TextBox>
                            </div>
                        </div>
                    </div>
                        <br />

                    <div class="row">
                        <div class="col-md-4 mr-auto">
                            <div class="form-group">
                                <asp:LinkButton ID="LinkButton1" CssClass="form-control btn btn-danger btn-block"  runat="server" OnClick="LinkButton1_Click">Login</asp:LinkButton>
                            </div>
                        </div>

                        
                    </div>
                        <br />
                        <div class="row">
                            <div class="col">
                                <h5>Forgot password?? click <a href="forgot.aspx" class="text-danger">here</a></h5>
                            </div>
                        </div>
                        <br />
                        <div class="row">
                            <div class="col">
                                <h6>Dont Have An Account?<a href="signup.aspx" class="font-weight-bold text-dark">create one here</a></h6>
                            </div>
                        </div>
                <br />
                
                    <a href="home.aspx"><< Back To Home</a>
                
                <br />
            <br />
                </div>
            
        </div>
       
    </div>
</asp:Content>
