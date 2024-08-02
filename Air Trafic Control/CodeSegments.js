<html>
	<head>
		<title>Game</title>
		<script src="http://ajax.googleapis.com/ajax/libs/jquery/1.4.2/jquery.min.js" type="text/javascript"></script>
		<script src="http://ajax.googleapis.com/ajax/libs/jqueryui/1.8.5/jquery-ui.min.js" type="text/javascript"></script>
		<script src="Graphics.js" type="text/javascript"></script>
		<script src="Object.js" type="text/javascript"></script>
		<script type="text/javascript">
			function Log(message) {
				jQuery("#Debug").append(message + "<br />");
			}

			function drawLine (x1, y1, x2, y2) {
				if (x1 > x2) {
					var tmpx = x1; var tmpy = y1;
					x1 = x2; y1 = y2;
					x2 = tmpx; y2 = tmpy;
				}

				var dx = x2 - x1;
				var dy = y2 - y1; var sy = 1;
				if (dy < 0) {
					sy = -1;
					dy = -dy;
				}

				dx = dx << 1; dy = dy << 1;
				if (dy <= dx) {
					var fraction = dy - (dx >> 1);
					var mx = x1;
					while (x1 != x2) {
						x1++;
						if (fraction >= 0) {
							DrawPoint(mx, y1, x1 - mx, 1);
							y1 += sy;
							mx = x1;
							fraction -= dx;
						}
						fraction += dy;
					}
					DrawPoint(mx, y1, x1 - mx, 1);
				}
				else {
					var fraction = dx - (dy >> 1);
					var my = y1;
					if (sy > 0) {
						while (y1 != y2) {
							y1++;
							if (fraction >= 0) {
								DrawPoint(x1++, my, 1, y1 - my);
								my = y1;
								fraction -= dy;
							}
							fraction += dx;
						}
						DrawPoint(x1, my, 1, y1 - my);
					}
					else {
						while (y1 != y2) {
							y1--;
							if (fraction >= 0) {
								DrawPoint(x1++, y1, 1, my - y1);
								my = y1;
								fraction -= dy;
							}
							fraction += dx;
						}
						DrawPoint(x1, y1, 1, my - y1);
					}
				}
			}











			setInterval(onTimerTick, 33);

			function onTimerTick() {
				//Log("Update World");
			}

			var mousePressed = false;
			var lastX = -1;
			var lastY = -1;

			jQuery(document).ready(function () {

				/*
				jQuery('#GameField').mousemove(function (e) {
				if (mousePressed) {
				if (lastX >= 0 && lastY >= 0) {
				drawLine(lastX, lastY, e.pageX, e.pageY);
				}
				lastX = e.pageX;
				lastY = e.pageY;
				}
				});
				jQuery('#GameField').mousedown(function (e) {
				mousePressed = true;
				lastX = -1;
				lastY = -1;
				});
				jQuery('#GameField').mouseup(function (e) {
				mousePressed = false;
				});
				*/








				var rufus = new Pet("Rufus", "cat", "miaow");
				var test = new Pet('d', '2', '4');
				rufus.sayHello();
				test.sayHello();
				rufus.sayHello();






				jQuery('#GameField').mousemove(function (e) {
					if (mousePressed) {
						if (lastX >= 0 && lastY >= 0) {
							drawLine(lastX, lastY, e.pageX, e.pageY);
						}
						lastX = e.pageX;
						lastY = e.pageY;
					}
				});
				jQuery('#AirTest').mousedown(function (e) {
					mousePressed = true;
					lastX = -1;
					lastY = -1;
				});
				jQuery('#GameField').mouseup(function (e) {
					mousePressed = false;
				});
			})
		</script>
	</head>
	<body>
		<div style="clear:both;">
		<div style="width:600;float:left;">
			<div id="GameField" style="width:500px;height:500px;top:50px;left:50px;border:1px solid #ff0000;clear:both;padding:10px;margin:10px;">
				<div id="AirTest" style="width:75;height:75;background-color:Green;background-image:url(http://cdn.images.autosport.com/editorial/1285066782.jpg)"></div>
			</div>
			<div id="Debug" style="width:500px;height:250px;top:50px;left:50px;border:1px solid #00ff00;overflow:scroll;">
			</div>
			Kalle Anka
		</div>
		</div>
	</body>
</html>