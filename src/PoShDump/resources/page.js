$(function(){
	$('th i').click(function(){

		var table = $(this).closest('table');
		var shown = table.data('shown');

		// Show collection header
		$(this).closest('table.tbl-collection > thead').find('tr:nth-child(2)').first().toggle();
		table.find('tbody').first().toggle();

		if(shown === undefined || shown === false){
			table.data('shown', true);
			$(this).removeClass('fa-square-caret-down').addClass('fa-square-caret-up');
			table.css('border-bottom-style', 'solid');
			table[0].scrollIntoView ({behavior:'smooth', block:'nearest'});
		}
		else{
			table.data('shown', false);
			$(this).removeClass('fa-square-caret-up').addClass('fa-square-caret-down');
			table.css('border-bottom-style', 'dashed');
		}
	});
})