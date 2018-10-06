
@Code
    Layout = Nothing
End Code

<!DOCTYPE html>
@Imports System.Web.Optimization
<html>
<head>
    <meta name="viewport" content="width=device-width" />
    <title>Login</title>
    @Styles.Render("~/Content/css3")
</head>
<body>
   <form action="../Home/EvaluarIndex" method="post">
       <div class="login-wrap">
           <div class="login-html">
               <input id="tab-1" type="radio" name="tab" class="sign-in" checked><label for="tab-1" class="tab">Recursos Humanos</label>
               <input id="tab-2" type="radio" name="tab" class="sign-up"><label for="tab-2" class="tab">Sign Up</label>
               <div class="login-form">
                   <div class="sign-in-htm">
                       <div class="group">
                           <label for="user" class="label">Usuario</label>
                           <input id="user" type="text" name="usuario" class="input">
                       </div>
                       <div class="group">
                           <label for="pass" class="label">Password</label>
                           <input id="pass" type="password" name="password" class="input" data-type="password">
                       </div>
                       <div class="group">
                           <input id="check" type="checkbox" class="check" checked>
                           <label for="check"><span class="icon"></span> Keep me Signed in</label>
                       </div>
                       <div class="group">
                           <input type="submit" class="button" value="Iniciar Session">
                       </div>
                       <div class="hr"></div>
                       <div class="foot-lnk">
                           <a href="#forgot">Forgot Password?</a>
                       </div>
                   </div>

               </div>
           </div>
       </div>

   </form>

</body>
</html>
