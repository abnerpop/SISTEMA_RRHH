
@Code
    Layout = Nothing
End Code

<!DOCTYPE html>
@Imports System.Web.Optimization
<html>
<head>
    <meta name="viewport" content="width=device-width" />
    <title>Empleado</title>
    @Styles.Render("~/Content/css2")
</head>
<body>
    @Html.ActionLink("INICIO", "Index")
    <div> 

        <section class="banner">

            <section class="wrap">

                <article>

                    <h1>REGISTRAR EMPLEADO</h1>

                    <form action="../Home/Ingresar_Empleado" method="POST" class="formulario">

                        
                        <label>Nombre<input type="text" name="nombre" id="" /></label>
                        <label>Apellido<input type="text" name="apellido" id="" /></label>
                        <label>DPI<input type="text" name="dpi" id="" /></label>
                        <label>NIT<input type="text" name="nit" id="" /></label>
                        <label>EDAD<input type="text" name="edad" id="" /></label>
                        <label>Nacionalidad<input type="text" name="nacionalidad" id="" /></label>
                        <label>Nacimiento<input type="text" name="nacimiento" id="" /></label>
                        <label>Telefono<input type="text" name="telefono" id="" /></label>
                        <label>Sexo<input type="text" name="sexo" id="" /></label>
                        <label>Estado civil<input type="text" name="civil" id="" /></label>
                        <input type="submit" value="Registrar" name="registro" id="boton">

                    </form>

                </article>

            </section>
        </section>

    </div>
</body>
</html>
