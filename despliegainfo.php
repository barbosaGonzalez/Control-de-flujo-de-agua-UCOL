  <html>
  <head>
    <title>Listado de la tabla</title>
    <meta http-equiv="Content-Type" content="text/html; charset=iso-8859-1">
  </head>
  <body>
    <?php
    /* Abre la Conexion con la base de datos */
    $link = mysql_connect("localhost","Edsel","e.-94B:_41") or die ("No se ha podido conectar con el servidor"); 

    /* Seleccion de la base de datos a utilizar */
    mysql_select_db("sensores") or die ("Error al tratar de selecccionar la base de datos"); 

    $n=0;
  ?>
    <table align="center" border="1">
          <tr>
              <td colspan="12" align="center">Listado de los datos de sensores</td>
            </tr>
            <tr>
              <td align="center" rowspan="2">No.</td>
                <td align="center" colspan="3">Flujo por minuto</td>
                <td align="center" colspan="3">Total Flujo</td>

            </tr>
            <tr>
              <td align="center">Sensor 1</td>
                <td align="center">Sensor 2</td>
                <td align="center">Sensor 3</td>
                <td align="center">Sensor 1</td>
                <td align="center">Sensor 2</td>
                <td align="center">Sensor 3</td>
            </tr>
    <?php
    /* Busqueda para desplegar la informacion de la bd en la tabla*/
        $result=mysql_db_query("sensores","SELECT * FROM sensor1 ORDER BY Id ASC");
        $row=mysql_fetch_array($result);
    
    $result2=mysql_db_query("sensores","SELECT * FROM sensor2 ORDER BY Id ASC");
        $row2=mysql_fetch_array($result2);
    
    $result3=mysql_db_query("sensores","SELECT * FROM sensor3 ORDER BY Id ASC");
        $row3=mysql_fetch_array($result3);
    
        do
        {
              $n=$n+1;
              
        //datos sensor 1
              $flujo1=$row["FlujoMinuto"];
              $totalflujo1=$row["Total"];
              $fecha1=$row["Fecha"];
              $limite1=$row["DentroLimite"];
              
        //datos sensor 2
        $flujo2=$row2["FlujoMinuto"];
              $totalflujo2=$row2["Total"];
              $fecha2=$row2["Fecha"];
              $limite2=$row2["DentroLimite"];

        //datos sensor 3
        $flujo3=$row3["FlujoMinuto"];
              $totalflujo3=$row3["Total"];
              $fecha3=$row3["Fecha"];
              $limite3=$row3["DentroLimite"];

        
        if($limite1==1)
        {
          $limite1="Si";
        }
        else
        {
             $limite1="No";  
        }
            ?>  
                <tr>
              <td align="center"><?php echo $n ?></td>
                <td align="center"><?php echo $flujo1 ?></td>
                <td align="center"><?php echo $flujo2 ?></td>
                <td align="center"><?php echo $flujo3 ?></td>                                
                <td align="center"><?php echo $totalflujo1 ?></td>
                <td align="center"><?php echo $totalflujo2 ?></td>
                <td align="center"><?php echo $totalflujo3 ?></td>
            </tr>
            <?php                 
            } 
            while ($row = mysql_fetch_array($result));
        /* Cerrando la conexion */
        mysql_close($link);
  ?>
      </table>
  </body>
</html>