<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
    <head>
        <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
        <title>Proyecto Integrador</title>
    </head>
    <body>
    	<?php
        	//Conectando con la base de datos
			$link=mysql_connect("localhost","Edsel","e.-94B:_41");
			
			//Seleccionando la base de datos a utilizar
			mysql_select_db("sensores") or die ("Error al seleccionar la base de datos");
			
			//Obteniendo los datos para crear la gráfica
			//sensor 1
			$result1 = mysql_db_query("sensores","SELECT SUM(Total) FROM sensor1"); 
    		$row1=mysql_fetch_array($result1); 
			$s1=$row1[0];
			$s1=($s1/10);
			
			//sensor 2
			$result2 = mysql_db_query("sensores","SELECT SUM(Total) FROM sensor2"); 
    		$row2=mysql_fetch_array($result2); 
			$s2=$row2[0];
			$s2=($s2/10);
			
			//sensor3
			$result3 = mysql_db_query("sensores","SELECT SUM(Total) FROM sensor3"); 
    		$row3=mysql_fetch_array($result3); 
			$s3=$row3[0];
			$s3=($s3/10);
			
		?>
        <table align="center">
        	<tr>
            	<td align="center" colspan="3">
                	Grafica comparativa de sensores
                </td>
            </tr>
           	<tr>
            	<td align="center" valign="bottom">
                	<img src="azul.gif" height="<?php echo $s1 ?>" width="30" />
                </td>
            	<td align="center" valign="bottom">
                	<img src="verde.gif" height="<?php echo $s2 ?>" width="30" />
                </td>         	
                <td align="center" valign="bottom">
                	<img src="violeta.gif" height="<?php echo $s3 ?>" width="30" />
                </td>                               
            </tr>
            <tr>
            	<td align="center" valign="bottom">
                	sensor 1
                </td>
            	<td align="center" valign="bottom">
                	sensor 2
                </td>         	
                <td align="center" valign="bottom">
                	sensor 3
                </td>                               
            </tr>
            <tr>
            	<td align="center" valign="bottom">
                	<?php echo ($s1*10) ?>
                </td>
            	<td align="center" valign="bottom">
                	<?php echo ($s2*10) ?>
                </td>         	
                <td align="center" valign="bottom">
                	<?php echo ($s3*10) ?>
                </td>                               
            </tr>
        </table>
    </body>
</html>