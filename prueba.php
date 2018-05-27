<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
    <head>
        <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
        <meta content="10" http-equiv="REFRESH"> </meta>
        <title>Di - sensor</title>
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
				<td>
					<table align="center" border="1">
							<tr>
								<td colspan="5" align="center">SENSOR 1</td>
							</tr>
							<tr>
								<td align="center">No.</td>
								<td align="center">Flujo por minuto</td>
								<td align="center">Total Flujo</td>
								<td align="center">Fecha</td>
								<td align="center">¿Dentro del Limite?</td>
				
							</tr>
					<?php
					$n=0;
					$result=mysql_db_query("sensores","SELECT * FROM sensor1 ORDER BY Id ASC");
			        $row=mysql_fetch_array($result);
					
					do
					{
						  $n=$n+1;
						  
						  //datos sensor 1
						  $flujo1=$row['FlujoMinuto'];
						  $totalflujo1=$row['Total'];
						  $fecha1=$row['Fecha'];
						  $limite1=$row['DentroLimite'];
						  		  
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
                                <td align="center"><?php echo $totalflujo1 ?></td>
                                <td align="center"><?php echo $fecha1 ?></td>
                                <td align="center"><?php echo $limite1 ?></td>
							</tr>
						<?php                
						} 
						while ($row = mysql_fetch_array($result));?>
				</td>
				</table>
				<td>
					<table align="center" border="1">
							<tr>
								<td colspan="3" align="center">SENSOR 2</td>
							</tr>
							<tr>
								<td align="center">No.</td>
								<td align="center">Flujo por minuto</td>
								<td align="center">Total Flujo</td>
								<td align="center">Fecha</td>
								<td align="center">¿Dentro del Limite?</td>
				
							</tr>
					<?php
					$n=0;
					$result2=mysql_db_query("sensores","SELECT * FROM sensor2 ORDER BY Id ASC");
			        $row2=mysql_fetch_array($result2);
					
					do
					{
						  $n=$n+1;
						  
						  //datos sensor 1
						  $flujo2=$row2['FlujoMinuto'];
						  $totalflujo2=$row2['Total'];
						  $fecha2=$row2['Fecha'];
						  $limite2=$row2['DentroLimite'];
						  		  
						  if($limite2==1)
						  {
							  $limite2="Si";
						  }
						  else
						  {
							   $limite2="No";  
						  }
						?>	
							<tr>
                                <td align="center"><?php echo $n ?></td>
                                <td align="center"><?php echo $flujo2 ?></td>
                                <td align="center"><?php echo $totalflujo2 ?></td>
                                <td align="center"><?php echo $fecha2 ?></td>
                                <td align="center"><?php echo $limite2 ?></td>
							</tr>
						<?php                
						} 
						while ($row2 = mysql_fetch_array($result2));?>
					</table>
				</td>
				<td>
					<table align="center" border="1">
							<tr>
								<td colspan="3" align="center">SENSOR 3</td>
							</tr>
							<tr>
								<td align="center">No.</td>
								<td align="center">Flujo por minuto</td>
								<td align="center">Total Flujo</td>
								<td align="center">Fecha</td>
								<td align="center">¿Dentro del Limite?</td>
				
							</tr>
					<?php
					$n=0;
					$result3=mysql_db_query("sensores","SELECT * FROM sensor3 ORDER BY Id ASC");
			        $row3=mysql_fetch_array($result3);
					
					do
					{
						  $n=$n+1;
						  
						  //datos sensor 1
						  $flujo3=$row3['FlujoMinuto'];
						  $totalflujo3=$row3['Total'];
						  $fecha3=$row3['Fecha'];
						  $limite3=$row3['DentroLimite'];
						  		  
						  if($limite3==1)
						  {
							  $limite3="Si";
						  }
						  else
						  {
							   $limite3="No";  
						  }
						?>	
							<tr>
                                <td align="center"><?php echo $n ?></td>
                                <td align="center"><?php echo $flujo3 ?></td>
                                <td align="center"><?php echo $totalflujo3 ?></td>
                                <td align="center"><?php echo $fecha3 ?></td>
                                <td align="center"><?php echo $limite3 ?></td>
							</tr>
						<?php                
						} 
						while ($row3 = mysql_fetch_array($result3));?>
					</table>
				</td>
			</table>
    </body>
</html>