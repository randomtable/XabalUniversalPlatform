<%@ Page EnableViewStateMac="true" ViewStateEncryptionMode="Always" Language="VB" AutoEventWireup="false" CodeFile="Default.aspx.vb" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <!-- Required meta tags -->
    <meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no">

    <!-- Bootstrap CSS -->
      <link href="https://fonts.googleapis.com/icon?family=Material+Icons" rel="stylesheet">
<link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/css/bootstrap.min.css" integrity="sha384-ggOyR0iXCbMQv3Xipma34MD+dH/1fQ784/j6cY/iJTQUOhcWr7x9JvoRxT2MZw1T" crossorigin="anonymous">

    <title>Hello, world!</title>
      
      <style>
      .w3-theme-l5 {color:#000 !important; background-color:#edf6ff !important}
.w3-theme-l4 {color:#000 !important; background-color:#c2e0ff !important}
.w3-theme-l3 {color:#000 !important; background-color:#85c2ff !important}
.w3-theme-l2 {color:#fff !important; background-color:#47a3ff !important}
.w3-theme-l1 {color:#fff !important; background-color:#0a85ff !important}
.w3-theme-d1 {color:#fff !important; background-color:#005cb8 !important}
.w3-theme-d2 {color:#fff !important; background-color:#0052a3 !important}
.w3-theme-d3 {color:#fff !important; background-color:#00478f !important}
.w3-theme-d4 {color:#fff !important; background-color:#003d7a !important}
.w3-theme-d5 {color:#fff !important; background-color:#003366 !important}

.w3-theme-light {color:#000 !important; background-color:#edf6ff !important}
.w3-theme-dark {color:#fff !important; background-color:#003366 !important}
.w3-theme-action {color:#fff !important; background-color:#003366 !important}

.w3-theme {color:#fff !important; background-color:#0066cc !important}
.w3-text-theme {color:#0066cc !important}
.w3-border-theme {border-color:#0066cc !important}

.w3-hover-theme:hover {color:#fff !important; background-color:#0066cc !important}
.w3-hover-text-theme:hover {color:#0066cc !important}
.w3-hover-border-theme:hover {border-color:#0066cc !important}
          
          @media screen and (min-width: 768px) {
              .container {
                  max-width: 688px;
              }
}
 
@media screen and (min-width: 992px) {
 .container {
                  max-width: 904px;
              }
}
 
@media screen and (min-width: 1280px) {
 .container {
                  max-width: 1184px;
              }
}
          
          .bg-italia {color:#fff !important; background-color:#009688 !important}
          .btn-italia {color:#fff !important; background-color:#009688 !important}
          .bg-tertiary {color:#000 !important; background-color:#cddc39 !important}
          .btn-tertiary {color:#000 !important; background-color:#cddc39 !important}
          .bg-quaternary {color:#fff !important; background-color:#9c27b0 !important}
          .btn-quaternary {color:#fff !important; background-color:#9c27b0 !important}
          .bg-primary {color:#fff !important; background-color:#0066cc !important}
          .btn-primary {color:#fff !important; background-color:#0066cc !important}
          
          
.bg-100 {color:#000 !important; background-color:#dfe5e8 !important}
.bg-200 {color:#000 !important; background-color:#becbd2 !important}
.bg-300 {color:#000 !important; background-color:#9eb1bb !important}
.bg-400 {color:#fff !important; background-color:#7d97a5 !important}
.bg-500 {color:#fff !important; background-color:#57707d !important}
.bg-600 {color:#fff !important; background-color:#4d636f !important}
.bg-700 {color:#fff !important; background-color:#435761 !important}
.bg-800 {color:#fff !important; background-color:#3a4b53 !important}
.bg-900 {color:#fff !important; background-color:#303e45 !important}

          .pagination {
  display: inline-block;
}

.pagination a {
  color: black;
  float: left;
  padding: 8px 16px;
  text-decoration: none;
}

.pagination a.active {
  background-color: #0066CC;
  color: white;
  border-radius: 5px;
}

.pagination a:hover:not(.active) {
  background-color: #ddd;
  border-radius: 5px;
}
          
      </style>
      
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    <header class="bg-primary">
      <div class="container text-white pt-4 pb-4">
        <h1>Xabal Universal Platform</h1>
      </div>
    </header>

    <div class="container">
        
      <section>
        
        <br />

      <div class="card bg-light mb-3 mx-auto">
  <div class="card-header">Xabal Universal Platform</div>
  <div class="card-body">
    <h5 class="card-title">Effettua il Login per visualizzare le funzioni</h5>
    
    <div class="input-group pb-3">
                    <div class="input-group-prepend">
                      <span class="input-group-text" id="basic-addon1">Nome Utente</span>
                    </div>
<asp:TextBox ID="TextBox1" runat="server" type="text" class="form-control" placeholder="Nome Utente" aria-label="Nome Utente" aria-describedby="basic-addon1"></asp:TextBox>
                  </div>

                  <div class="input-group pb-3">
                    <div class="input-group-prepend">
                      <span class="input-group-text" id="Span1">Password</span>
                    </div>
<asp:TextBox ID="TextBox2" runat="server" type="password" class="form-control" placeholder="Password" aria-label="Password" aria-describedby="basic-addon1"></asp:TextBox>
                  </div>

                  <div style="float:none; margin-left:auto; margin-right:auto; text-align:center;">
<asp:Button ID="Button1" runat="server" Text="Login" type="button" style="height:50px; width:300px;" class="waves-effect waves-light btn mb-1 btn-primary"></asp:Button>
                  </div>
  </div>
</div>

        </section>
      </div>

    <!-- Optional JavaScript -->
    <!-- jQuery first, then Popper.js, then Bootstrap JS -->
<script src="https://code.jquery.com/jquery-3.3.1.slim.min.js" integrity="sha384-q8i/X+965DzO0rT7abK41JStQIAqVgRVzpbzo5smXKp4YfRvH+8abtTE1Pi6jizo" crossorigin="anonymous"></script>
<script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.14.7/umd/popper.min.js" integrity="sha384-UO2eT0CpHqdSJQ6hJty5KVphtPhzWj9WO1clHTMGa3JDZwrnQq4sF86dIHNDz0W1" crossorigin="anonymous"></script>
<script src="https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/js/bootstrap.min.js" integrity="sha384-JjSmVgyd0p3pXB1rRibZUAYoIIy6OrQ6VrjIEaFf/nJGzIxFDsf4x0xIM+B07jRM" crossorigin="anonymous"></script>
      
      <script>
          $(document).ready(function () {
              $('.sidenavM').sidenavM();
          });
      </script>
      
      <script>
          $(document).ready(function () {
              $('.tooltipped').tooltip();
          });
      </script>
      
      <script>
          $(function () {
              $('[data-toggle="popover"]').popover()
          })
      </script>
      
      <script>
          $(document).ready(function () {
              $('.carouselM').carouselM();
          });
      </script>
      
      <script>
          $(function () {
              $('[data-toggle="tooltip"]').tooltip()
          })
      </script>
      

    </div>
    </form>
</body>
</html>
