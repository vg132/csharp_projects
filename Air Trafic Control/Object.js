
function getAngle(ax, ay, bx, by) {
	var magA = Math.sqrt(ax * ax + ay * ay);
	var magB = Math.sqrt(bx * bx + by * by);
	var magAmagB = magA * magB;
	
	var sinTheta = (ax * by - bx * ay) / magAmagB;
	var cosTheta = (ax * bx + ay * by) / magAmagB;
	var theta = Math.atan2(sinTheta, cosTheta);
	return (theta*180)/Math.PI;
}

/* Help */
function IsNullOrEmpty(e) {
	if (typeof (e) != 'object' || e == null) {
		return true
	}
	return false;
}

/* Point class */

Point = function (x, y) {
	this.x = x;
	this.y = y;
}

Point.prototype.getX = function () {
	return this.x;
}

Point.prototype.getY = function () {
	return this.y;
}

Point.prototype.print = function () {
	return "X: " + this.getX() + ", Y: " + this.getY();
}

/* Rect class */

Rect = function (topLeft, bottomRight) {
	this.topLeft = topLeft;
	this.bottomRight = bottomRight;
}

Rect.prototype.getLeft = function () {
	return this.topLeft.getX();
}

Rect.prototype.getRight = function () {
	return this.bottomRight.getX();
}

Rect.prototype.getTop = function () {
	return this.topLeft.getY();
}

Rect.prototype.getBottom = function () {
	return this.bottomRight.getY();
}

Rect.prototype.intersect = function (point) {
	return point.getX() >= this.getLeft() &&
					point.getX() < this.getRight() &&
					point.getY() >= this.getTop() &&
					point.getY() < this.getBottom();
}

/* Air plane class */
var instanceCounter=0;

AirPlane = function (field, point) {
	instanceCounter++;
	this.point = point;
	this.width = 15;
	this.height = 15;
	this.angle = 0;
	this.id = 'airPlane_' + instanceCounter;
	this.field = field;
	this.inLandingZone = 0;
	this.points = new Array();
	//this.field.getField().append('<div id="' + this.id + '" style="position:absolute;z-index:5000;top:' + (this.point.getY() + (this.height / 2)) + ';left:' + (this.point.getX() + (this.width / 2)) + ';width:' + this.width + ';height:' + this.height + ';background-color:#f1f1f1;"></div>');
	this.field.getField().append('<div id="' + this.id + '" style="position:absolute;z-index:5000;top:' + (this.point.getY() + (this.height / 2)) + ';left:' + (this.point.getX() + (this.width / 2)) + ';width:' + this.width + ';height:' + this.height + ';background-image:url(Images/Airplain.gif);"></div>');

	jQuery('#' + this.id).data('AirPlane', this);
	jQuery('#' + this.id).mousedown(function (e) {
		var item = jQuery(this).data('AirPlane');
		item.getField().setActiveObject(item);
	});
}

AirPlane.prototype.getId = function () {
	return this.id;
}

AirPlane.prototype.getPoint = function () {
	return this.point;
}

AirPlane.prototype.getField = function () {
	return this.field;
}

AirPlane.prototype.addPoint = function (point) {
	this.points.push(point);
}

AirPlane.prototype.move = function () {
	if (!IsNullOrEmpty(this.points) && this.points.length > 0) {
		var point = this.points.shift();
		jQuery('#' + this.id).css({ top: point.getY() + 'px', left: point.getX() + 'px' });
		this.angle = this.angle + getAngle(this.getPoint().getX(), this.getPoint().getY(), point.getX(), point.getY());
		if (this.angle > 360) {
			this.angle -= 360;
		}
		jQuery('#' + this.id).rotate(this.angle);

		for (var i = 0; i < this.field.objects.length; i++) {
			var obj = this.field.objects[i];
			if (obj != this) {
				if (this.intersect(obj.getPoint())) {
					Log("Check if intersect: " + i);
					jQuery('#' + this.getId).remove();
					jQuery('#' + obj.getId()).remove();
				}
			}
		}




		if (this.getField().getLandingStrip().intersect(point)) {
			this.inLandingZone++;
		}
		else {
			this.inLandingZone = 0;
		}

		if (this.inLandingZone > 60) {
			jQuery('#' + this.id).remove();
			this.getField().addPoints(100);
			this.points = new Array();
		}
	}
}

AirPlane.prototype.intersect = function (point) {
	var x1 = this.getPoint().getX() - (this.width / 2);
	var y1 = this.getPoint().getY() - (this.height / 2);
	var w1 = this.width;
	var h1 = this.height;

	var x2 = point.getX() - (this.width / 2);
	var y2 = point.getY() - (this.height / 2);
	var w2 = this.width;
	var h2 = this.height;

	var width1 = (w1 >> 1) - (w1 >> 3);
	var height1 = (h1 >> 1) - (h1 >> 3);

	var width2 = (w2 >> 1) - (w2 >> 3);
	var height2 = (h2 >> 1) - (h2 >> 3);

	var cx1 = x1 + width1;
	var cy1 = y1 + height1;

	var cx2 = x2 + width2;
	var cy2 = y2 + height2;

	var dx = Math.abs(cx2 - cx1);
	var dy = Math.abs(cy2 - cy1);

	if (dx < (width1 + width2) && dy < (height1 + height2)) {
		return true;
	}
	return false;
}

AirPlane.prototype.print = function () {
	return "X: " + this.getPoint().getX() + ", Y: " + this.getPoint().getY() + ", Points: " + this.points.length;
}

/* Game field */

Field = function (fieldId) {
	this.fieldId = fieldId;
	this.width = this.getField().width();
	this.height = this.getField().height();
	this.objects = new Array();
	this.lastX = -1;
	this.lastY = -1;
	this.points = 0;
	this.landingStrip = new Rect(new Point(285, 198), new Point(555, 231));
	jQuery(fieldId).data('field', this);

	jQuery(fieldId).mousemove(function (e) {
		var field = jQuery(this).data('field');
		if (!IsNullOrEmpty(field.getActiveObject())) {
			if (field.lastX >= 0 && field.lastY >= 0) {
				field.calculateAndDrawLine(field, e.pageX, e.pageY, field.lastX, field.lastY);
			}
			field.lastX = e.pageX;
			field.lastY = e.pageY;
		}
	});

	jQuery(fieldId).mouseup(function (e) {
		var field = jQuery(this).data('field');
		field.setActiveObject(null);
		field.lastX = -1;
		field.lastY = -1;
	});
}

Field.prototype.getField = function () {
	return jQuery(this.getFieldId());
}

Field.prototype.getFieldId = function () {
	return this.fieldId;
}

Field.prototype.setActiveObject = function (object) {
	this.activeObject = object;
}

Field.prototype.getActiveObject = function () {
	return this.activeObject;
}

Field.prototype.getPoints = function () {
	return this.points;
}

Field.prototype.addPoints = function (points) {
	this.points += points;
}

Field.prototype.addObject = function (object) {
	this.objects.push(object);
}

Field.prototype.createRandomPoint = function () {
	var x=Math.floor(Math.random() * this.width);
	var y=Math.floor(Math.random()*this.height);
	return new Point(x,y);
}

Field.prototype.getLandingStrip = function () {
	return this.landingStrip;
}

Field.prototype.createObject = function () {
	var point;
	var found = true;
	do {
		point = this.createRandomPoint();
		for (var i = 0; i < this.objects.length; i++) {
			if (this.objects[i].intersect(point)) {
				found = false;
				break;
			}
			else {
				found = true;
			}
		}
	} while (!found);
	var object = new AirPlane(this, point);
	this.addObject(object);
}

Field.prototype.updateWorld = function () {
	for (var i = 0; i < this.objects.length; i++) {
		this.objects[i].move();
	}
}

Field.prototype.calculateAndDrawLine = function (field, x1, y1, x2, y2) {
	if (IsNullOrEmpty(field) || IsNullOrEmpty(field.getActiveObject())) {
		return;
	}
	var points = new Array();
	var swapped = false;
	if (x1 > x2) {
		var tmpx = x1; var tmpy = y1;
		x1 = x2; y1 = y2;
		x2 = tmpx; y2 = tmpy;
		swapped = true;
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
				points.push(new Point(mx, y1));
				y1 += sy;
				mx = x1;
				fraction -= dx;
			}
			fraction += dy;
		}
		DrawPoint(mx, y1, x1 - mx, 1);
		points.push(new Point(mx, y1));
	}
	else {
		var fraction = dx - (dy >> 1);
		var my = y1;
		if (sy > 0) {
			while (y1 != y2) {
				y1++;
				if (fraction >= 0) {
					DrawPoint(x1 + 1, my, 1, y1 - my);
					points.push(new Point(x1++, my));
					my = y1;
					fraction -= dy;
				}
				fraction += dx;
			}
			DrawPoint(x1, my, 1, y1 - my);
			points.push(new Point(x1, my));
		}
		else {
			while (y1 != y2) {
				y1--;
				if (fraction >= 0) {
					DrawPoint(x1 + 1, y1, 1, my - y1);
					points.push(new Point(x1++, y1));
					my = y1;
					fraction -= dy;
				}
				fraction += dx;
			}
			DrawPoint(x1, y1, 1, my - y1);
			points.push(new Point(x1, y1));
		}
	}

	if (swapped) {
		for (var i = 0; i < points.length; i++) {
			field.getActiveObject().addPoint(points[i]);
		}
	}
	else {
		for (var i = points.length - 1; i > 0; i--) {
			field.getActiveObject().addPoint(points[i]);
		}
	}
}