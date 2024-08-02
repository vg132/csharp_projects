function DrawPoint(x, y, w, h) {
	//var item = jQuery('<div style="position:absolute;left:' + x + 'px;top:' + y + 'px;width:' + w + 'px;height:' + h + 'px;background-color:#000000;overflow:hidden;"></div>').fadeOut(2500);
	//jQuery("#GameField").append(item);
	
	w++;
	h++;
	jQuery('<div id="' + x + '_' + y + '_' + w + '_' + h + '" style="position:absolute;left:' + x + 'px;top:' + y + 'px;width:' + w + 'px;height:' + h + 'px;background-color:#000000;overflow:hidden;"></div>').appendTo("#GameField");
	jQuery('#' + x + '_' + y + '_' + w + '_' + h + '').fadeOut(3500, function () { jQuery(this).remove(); });
}
