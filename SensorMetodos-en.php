<!DOCTYPE html>

<!--[if IE 7]>                  <html class="ie7 no-js" lang="en">     <![endif]-->
<!--[if lte IE 8]>              <html class="ie8 no-js" lang="en">     <![endif]-->
<!--[if (gte IE 9)|!(IE)]><!--> <html class="not-ie no-js" lang="en">  <!--<![endif]-->
<head>
	<meta charset="utf-8">
	<meta http-equiv="X-UA-Compatible" content="IE=edge,chrome=1">
	<meta name="viewport" content="width=device-width, initial-scale=1, maximum-scale=1">
	
	<title>Di - Sensor</title>
	
	<meta name="description" content="">
	<meta name="author" content="">
	
	<!--[if !lte IE 6]><!-->
		<link rel="stylesheet" href="css/style.css" media="screen" />

		<link rel="stylesheet" href="//fonts.googleapis.com/css?family=Open+Sans:400,600,300,800,700,400italic|PT+Serif:400,400italic" />
		
		<link rel="stylesheet" href="css/fancybox.min.css" media="screen" />

		<link rel="stylesheet" href="css/video-js.min.css" media="screen" />

		<link rel="stylesheet" href="css/audioplayerv1.min.css" media="screen" />
	<!--<![endif]-->

	<!--[if lte IE 6]>
		<link rel="stylesheet" href="//universal-ie6-css.googlecode.com/files/ie6.1.1.css" media="screen, projection">
	<![endif]-->

	<!-- HTML5 Shiv + detect touch events -->
	<script src="js/modernizr.custom.js"></script>

	<!-- HTML5 video player -->
	<script src="js/video.min.js"></script>
	<script>_V_.options.flash.swf = 'http://localhost/smartstart/js/video-js.swf';</script>
<!-- Shared on MafiaShare.net  --><!-- Shared on MafiaShare.net  --></head>
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
<header id="header" class="container clearfix">
<a href="index.html" id="logo">
		<img src="img/logo.png" alt="Di-Soft Technologies and Solutions">
	</a>
<nav id="main-nav">
		<ul>
			<li>
				<a href="index-en.html" data-description="All begins here">Home</a>
			</li>
			<li class="current">
				<a href="#" data-description="What makes us different">Learn more</a>
				<ul>
					<li><a href="about-us-en.html">About us</a></li>
					<li><a href="our-team-en.html">Out team</a></li>
					<li><a href="description-en.html">Job description</a></li>
					<li><a href="pricing-tables-en.html">Princing tables</a></li>
				</ul>
			</li>
			<li>
				<a href="Gallery-en.html" data-description="What show">Gallery</a></li>
			<li>
				<a href="#" data-description="Projects we have done">Projects</a>
				<ul>
					<li><a href="#">Di - Evaluation of libraries</a>
						<ul>
							<li><a href="Evaluation-en.html">Object Oriented Programming</a></li>
							<li><a href="EvaluationDiseño-en.html">Software design</a></li>
							<li><a href="EvaluationSistemas-en.html">Information Sistems</a></li> 
							<li><a href="EvaluationRedes-en.html">Computer Networks</a></li>
							<li><a href="EvaluationIngles-en.html">English II</a></li>
							<li><a href="EvaluationCalculo-en.html">Calculus</a></li>							
						</ul>
					</li>
					<li><a href="#">Di - Bus</a>
						<ul>
							<li><a href="Bus-en.html">Project management</a></li>
							<li><a href="BusProgramacion-en.html">Visual programming</a></li>
							<li><a href="BusFormulacion-en.html">Project Formulation</a></li> 
							<li><a href="BusProbabilidad-en.html">Probability</a></li>
							<li><a href="BusMatematicas-en.html">Discrete mathematics</a></li>
							<li><a href="BusIngles-en.html">English III</a></li> 
						</ul>
						</li>
					<li><a href="#">Di - Sensor</a>
						<ul>
							<li><a href="Sensor-en.html">S.O. y S. I.</a></li>
							<li><a href="SensorSistemas-en.html">Embedded systems</a></li>
							<li><a href="SensorEstructuras-en.html">Data Structure</a></li> 
							<li><a href="SensorEvalacion-en.html">Evaluation of projects</a></li>
							<li><a href="SensorMetodos-en.php">Statistical methods</a></li>
							<li><a href="SensorIngles-en.html">English</a></li> 
							<li><a href="SensorEtica-en.html">Ethics</a></li> 
						</ul>
						</li>
				</ul>
			</li>
			<li>
				<a href="contact-us-en.html" data-description="We can talk">Contact us</a>
			</li>
		</ul>
	</nav><!-- end #main-nav -->
</header><!-- end #header -->

<section id="content" class="container clearfix">

	<article class="single-project">

		<header class="page-header">

			<h1 class="page-title align-left">Project Integrator 4th Semester</h1>
			
			<a href="Gallery.html" class="button no-bg medium align-right">
				Gallery <img src="img/icon-grid.png" alt="" class="icon">
			</a>

			<hr />

			<h2 class="project-title">Di - Sensor / Statistical methods</h2>

			<ul class="portfolio-pagination">
				<li class="prev"><a href="SensorEvaluacion-en.html" class="button medium no-bg"><span class="arrow left">&raquo;</span> Previous</a></li>
				<li class="next"><a href="SensorEtica-en.html" class="button medium no-bg">Next <span class="arrow">&raquo;</span></a></li>
			</ul><!-- end .portfolio-pagination -->
			
		</header><!-- end .page-header -->

		<div id="main">
		
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
		
		</div><!-- end #main -->

		<div id="sidebar">

			<h4>Objectives:</h4>

			<p>Creating tables and graphs using different statistical methods.</p>
			<h4>Deliverables:</h4>

			<ul class="check">
				<li>Graph of data</li>
			</ul>
		</div><!-- end #sidebar -->
		
	</article><!-- end .single-project -->
	
</section><!-- end #content -->
<footer id="footer" class="clearfix">

	<div class="container">

		<div class="three-fourth">

			<nav id="footer-nav" class="clearfix">

				<ul>
					<li><a href="index-en.html">Home</a></li>
					<li><a href="Gallery-en.html">Gallery</a></li>
					<li><a href="contact-us-en.html">Contact us</a></li>
					<li><a href="Mapa-en.html">SiteMap</a></li>
					<li><a href="SensoresMetodos.php">Spanish Version</a></li>
				</ul>
				
			</nav><!-- end #footer-nav -->

			<ul class="contact-info">
				<li class="address">#225C 13 de Septiembre. Villa de Alvarez, Col., 12345. Mex</li>
				<li class="phone">(312) 128-2869</li>
				<li class="email"><a href="mailto:torby@outlook.com">torby@outlook.com</a></li>
			</ul><!-- end .contact-info -->
			
		</div><!-- end .three-fourth -->

		<div class="one-fourth last">

			<span class="title">we are connected</span>

			<ul class="social-links">
				<li class="facebook"><a href="https://www.facebook.com/torby1">Facebook</a></li>
			</ul><!-- end .social-links -->

		</div><!-- end .one-fourth.last -->
		
	</div><!-- end .container -->

</footer><!-- end #footer -->

<footer id="footer-bottom" class="clearfix">

	<div class="container">

		<ul>
			<li>Di - Technologies and Solutions &copy; 2014</li>
			<li><a href="Politicas-en.html">Privacy</a></li>
			<li><a href="javascript:window.print();">Print</a></li>
		</ul>

	</div><!-- end .container -->

</footer><!-- end #footer-bottom -->
<!--[if !lte IE 6]><!-->
	<script src="//ajax.googleapis.com/ajax/libs/jquery/1.7.1/jquery.min.js"></script>
	<script>window.jQuery || document.write('<script src="js/jquery-1.7.1.min.js"><\/script>')</script>
	<!--[if lt IE 9]> <script src="js/selectivizr-and-extra-selectors.min.js"></script> <![endif]-->
	<script src="js/respond.min.js"></script>
	<script src="js/jquery.easing-1.3.min.js"></script>
	<script src="js/jquery.fancybox.pack.js"></script>
	<script src="js/jquery.smartStartSlider.min.js"></script>
	<script src="js/jquery.jcarousel.min.js"></script>
	<script src="js/jquery.cycle.all.min.js"></script>
	<script src="js/jquery.isotope.min.js"></script>
	<script src="js/audioplayerv1.min.js"></script>
	<script src="//maps.google.com/maps/api/js?sensor=false"></script>
	<script src="js/jquery.gmap.min.js"></script>
	<script src="js/jquery.touchSwipe.min.js"></script>
	<script src="js/custom.js"></script>
<!--<![endif]-->
</body>
</html>