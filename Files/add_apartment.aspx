<%@ Page Title="" Language="C#" MasterPageFile="~/admin.Master" AutoEventWireup="true" CodeBehind="add_apartment.aspx.cs" Inherits="houses.add_apartment" %>
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
    <div class="container-fluid">
        <div class="row">
            <div class="col-md-5">
                <div class="card">
                    <div class="card-body">

                    
                <div class="row">
                    <div class="col">
                        
                            <h4>Add New Apartment <span class="text-danger">Location</span></h4>
                        
                    </div>
                </div>
                <div class="row">
                    <div class="col">
                        <label>Apartment Name</label>
                        <div class="form-group">
                            <asp:TextBox ID="apartment" CssClass="form-control" runat="server" placeholder="Apartment Name"></asp:TextBox>
                        </div>
                    </div>
                </div>

                <div class="row">
                    <div class="col-md-6">
                        <label>Apartment ID</label>
                        <div class="form-group input-group">
                            <asp:TextBox ID="TextBox2" CssClass="form-control" runat="server" placeholder="ID"></asp:TextBox>
                            <asp:LinkButton class=" btn btn-primary" ID="LinkButton2" runat="server" OnClick="LinkButton2_Click" Width="52px"><i class="fas fa-check"></i></asp:LinkButton>
                        </div>
                    </div>
                    <div class="col-md-6">
                        <label>Apartment Image</label>
                        <div class="form-group">
                            <asp:FileUpload ID="FileUpload1" runat="server" />
                        </div>
                    </div>
                </div>

                <div class="row">
                    <div class="col-md-6">
                        <label>County</label>
                        <div class="form-group">
                            <asp:TextBox ID="TextBox3" CssClass="form-control" runat="server" placeholder="County"></asp:TextBox>
                        </div>
                    </div>
                    <div class="col-md-6">
                        <label>Town</label>
                        <div class="form-group">
                            <asp:TextBox ID="TextBox1" runat="server" CssClass="form-control" placeholder="Town"></asp:TextBox>
                        </div>
                    </div>
                </div>

                        <div class="row">
                            <div class="col">
                                <center>
                                    <span class="badge badge-pill badge-secondary">House Number Information</span>

                                </center>
                            </div>
                        </div>
                 <div class="row">
                            <div class="col-md-4">
                                <label>Total  room number</label>
                                <div class="form-group"></div>
                                <asp:TextBox ID="TextBox4" runat="server" CssClass="form-control" placeholder="Total" TextMode="Number"></asp:TextBox>
                            </div>
                             <div class="col-md-4">
                                <label>Allocated rooms</label>
                                <div class="form-group"></div>
                                <asp:TextBox ID="TextBox5" ReadOnly="true" runat="server" CssClass="form-control" placeholder="allocated" TextMode="Number"></asp:TextBox>
                            </div>
                            <div class="col-md-4">
                                <label>Remaining rooms</label>
                                <div class="form-group"></div>
                                <asp:TextBox ID="TextBox6" runat="server"  ReadOnly="true" CssClass="form-control" placeholder="remaining" TextMode="Number"></asp:TextBox>
                            </div>
                        </div>

                 
                        <br />
                        <br />
                <div class="row">
                    <div class="col-md-6">
                        <asp:LinkButton ID="LinkButton1" runat="server" CssClass="btn btn-success btn-block" OnClick="LinkButton1_Click">Add</asp:LinkButton>
                    </div>
                     
                     <div class="col-md-6">
                        <asp:LinkButton ID="LinkButton3" runat="server" CssClass="btn btn-danger btn-block" OnClick="LinkButton3_Click">Delete</asp:LinkButton>
                    </div>
                </div>

                
            </div>
        </div>
    </div>

            <div class="col-md-6">
                 <div class="row">
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:housesConnectionString %>" SelectCommand="SELECT * FROM [apartments]"></asp:SqlDataSource>
            <div class="col">
                <asp:GridView ID="GridView1" class="table table-striped" runat="server" AutoGenerateColumns="False" DataKeyNames="apa_ID" DataSourceID="SqlDataSource1">
                    <Columns>
                        <asp:BoundField DataField="apa_ID" HeaderText="apa_ID" ReadOnly="True" SortExpression="apa_ID" />
                        <asp:BoundField DataField="apa_name" HeaderText="apa_name" SortExpression="apa_name" />
                        <asp:BoundField DataField="total_number" HeaderText="total_number" SortExpression="total_number" />
                        <asp:BoundField DataField="remaining_rooms" HeaderText="remaining_rooms" SortExpression="remaining_rooms" />
                        <asp:BoundField DataField="apa_county" HeaderText="apa_county" SortExpression="apa_county" />
                        <asp:BoundField DataField="apa_town" HeaderText="apa_town" SortExpression="apa_town" />
                    </Columns>
                </asp:GridView>
            </div>
        </div>
            </div>
    </div>
 </div>
    
</asp:Content>
