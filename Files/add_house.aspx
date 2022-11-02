<%@ Page Title="" Language="C#" MasterPageFile="~/admin.Master" AutoEventWireup="true" CodeBehind="add_house.aspx.cs" Inherits="houses.add_house" %>
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
            <div class="col-md-6">
                <div class="card">
                    <div class="card-body">

                   
                <div class="row">
                    <div class="col">      
                            <h4>Add New House</h4>
                    </div>
                </div>
                <div class="row">
                    <div class="col">
                        <label>Apartment</label>
                        <div class="form-group">
                            <asp:DropDownList CssClass="form-control" ID="DropDownList1" runat="server">
                                
                            </asp:DropDownList>
                        </div>
                       
                        
                    </div>
                </div>
                        

                        <div class="row">
                    <div class="col">
                        <label>House ID</label>
                        <div class="form-group input-group ">
                            <asp:TextBox ID="TextBox3" CssClass="form-control" runat="server" placeholder="house ID"></asp:TextBox>
                        <asp:LinkButton class=" btn btn-primary" ID="LinkButton3" runat="server" OnClick="LinkButton3_Click" Width="56px"><i class="fas fa-check"></i></asp:LinkButton>
                        </div>
                    </div>
                            </div>

                <div class="row">
                    <div class="col-md-6">
                        <label>House Number</label>
                        <div class="form-group">
                            <asp:TextBox ID="TextBox1" CssClass="form-control" runat="server" placeholder="house number"></asp:TextBox>
                        </div>
                    </div>
                    <div class="col-md-6">
                        <label>House Type</label>
                        <div class="form-group">
                            <asp:DropDownList CssClass="form-control" ID="DropDownList2" runat="server">
                                <asp:ListItem Value="BedSitter" Text="BedSitter"></asp:ListItem>
                                 <asp:ListItem Value="OneBedroom" Text="OneBedroom"></asp:ListItem>
                                 <asp:ListItem Value="TwoBedroom" Text="TwoBedroom"></asp:ListItem>
                                 <asp:ListItem Value="OwnCompound" Text="OwnCompound"></asp:ListItem>
                            </asp:DropDownList>
                        </div>
                    </div>
                </div>

                

                <div class="row">
                    <div class="col">
                        <label>Details</label>
                        <div class="form-group">
                            <asp:TextBox ID="TextBox2" CssClass="form-control" runat="server" TextMode="MultiLine"></asp:TextBox>
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
                        <asp:LinkButton ID="LinkButton1" runat="server" CssClass="btn btn-success btn-block" OnClick="LinkButton1_Click">Add House</asp:LinkButton>
                    </div>
                    <div class="col-md-6">
                        <asp:LinkButton ID="LinkButton2" runat="server" CssClass="btn btn-danger btn-block" OnClick="LinkButton2_Click">Delete House</asp:LinkButton>
                    </div>
                </div>
            </div>
        </div>
    </div>

            <div class="col-md-6">
                <div class="row">
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:housesConnectionString %>" SelectCommand="SELECT * FROM [house]"></asp:SqlDataSource>
            <div class="col">
                <asp:GridView ID="GridView1" class="table table-striped" runat="server" AutoGenerateColumns="False" DataKeyNames="house_ID" DataSourceID="SqlDataSource1">
                    <Columns>
                        <asp:BoundField DataField="house_ID" HeaderText="house_ID" ReadOnly="True" SortExpression="house_ID" />
                        <asp:BoundField DataField="house_number" HeaderText="house_number" SortExpression="house_number" />
                        <asp:BoundField DataField="house_type" HeaderText="house_type" SortExpression="house_type" />
                        <asp:BoundField DataField="house_apartment" HeaderText="house_apartment" SortExpression="house_apartment" />
                    </Columns>
                </asp:GridView>
            </div>
        </div>
            </div>   
   </div>
    </div>
        
    
</asp:Content>
