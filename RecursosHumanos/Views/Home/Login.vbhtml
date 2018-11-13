
@Code
    Layout = Nothing
End Code

<!DOCTYPE html>
@Imports System.Web.Optimization

<html>
<head>
    <meta name="viewport" content="width=device-width" />
    <title>Login</title>
    @Styles.Render("~/Content/css")
    @Styles.Render("~/Content/css2")
</head>
<body class="login">


    <div class="nav justify-content-center">

        <form action="../Home/Login" method="post">

            <div class="form-group">
                <label for="exampleInputEmail1">Usuario</label>
                <input type="text" class="form-control" name="usuario" id="exampleInputEmail1" aria-describedby="emailHelp" placeholder="Ente Usuario">
               
            </div>
            <div class="form-group">
                <label for="exampleInputPassword1">Password</label>
                <input type="password" class="form-control" name="password" id="exampleInputPassword1" placeholder="Password">
            </div>
         
            <button type="submit" class="btn btn-primary">Iniciar Seccion</button>

        </form>



    </div>

   
</body>
</html>
