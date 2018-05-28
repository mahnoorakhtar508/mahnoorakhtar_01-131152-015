<%@ Page Title="" Language="C#" MasterPageFile="~/masterpage.Master" AutoEventWireup="true" CodeBehind="items.aspx.cs" Inherits="vp_project.items" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    
      <!-- Navigation -->
      <nav class="navbar navbar-expand-lg navbar-dark bg-dark fixed-top">
          <div class="container">
              <a class="navbar-brand" href="#">Start Bootstrap</a>
              <button class="navbar-toggler" type="button" data-toggle="collapse" data-target="#navbarResponsive" aria-controls="navbarResponsive" aria-expanded="false" aria-label="Toggle navigation">
                  <span class="navbar-toggler-icon"></span>
              </button>
              <div class="collapse navbar-collapse" id="navbarResponsive">
                  <ul class="navbar-nav ml-auto">
                  <%--    <li class="nav-item active">
                          <a class="nav-link" href="#">
                              Home
                              <span class="sr-only">(current)</span>
                          </a>
                      </li>--%>
                      <li class="nav-item">
                          <a class="nav-link" href="home.aspx">Home</a>
                      </li>
                      <li class="nav-item">
                          <a class="nav-link" href="#">Services</a>
                      </li>
                      <li class="nav-item">
                          <a class="nav-link" href="#">Contact</a>
                      </li>
                  </ul>
              </div>
          </div>
      </nav>
      <!-- Page Content -->
   <div class="container">

      <div class="row">

        <div class="col-lg-3">
           <a class="logo" href="index.html"><img src="iimages/download.png" /></a>

          <div class="list-group">
            <a href="electronics.aspx" class="list-group-item">Electronics</a>
            <a href="house.aspx" class="list-group-item">Home</a>
            <a href="furniture.aspx" class="list-group-item">Furniture</a>
          </div>

        </div>
            
              <!-- /.col-lg-3 -->

                   <asp:ListView ID="ListView1" runat="server">
                 <ItemTemplate>
              <div class="col-lg-9">
                  <div class="card mt-4">
                      <img class="card-img-top img-fluid" src="<%# Eval("image") %>" alt="">
                      <div class="card-body">
                          <h3 class="card-title"><%# Eval("Title") %></h3>
                          <h4>pkr <%# Eval("price") %></h4>
                          <p class="card-text"><%# Eval("Description") %></p>
                          <span class="text-warning">&#9733; &#9733; &#9733; &#9733; &#9734;</span>
                          4.0 stars
                      </div>
                  </div>
     
              </div>
              </ItemTemplate>
                </asp:ListView>
              <!-- /.col-lg-9 -->
          </div>
      </div>
      <!-- /.container -->
      <!-- Footer -->
      <footer class="py-5 bg-dark">
          <div class="container">
              <p class="m-0 text-center text-white">Copyright &copy; Your Website 2017</p>
          </div>
          <!-- /.container -->
      </footer>
      <!-- Bootstrap core JavaScript -->
      <script src="vendor/jquery/jquery.min.js"></script>
      <script src="vendor/bootstrap/js/bootstrap.bundle.min.js"></script>

</asp:Content>
