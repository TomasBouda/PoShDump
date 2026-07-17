document.addEventListener('DOMContentLoaded', function () {
	Array.prototype.forEach.call(document.querySelectorAll('th .toggle'), function (toggle) {
		var table = toggle.closest('table');
		if (!table) {
			return;
		}

		toggle.textContent = table.classList.contains('collapsed') ? '[+]' : '[-]';
		toggle.addEventListener('click', function (event) {
			event.stopPropagation();

			var collapsed = table.classList.toggle('collapsed');
			toggle.textContent = collapsed ? '[+]' : '[-]';
			table.style.borderBottomStyle = collapsed ? 'dashed' : 'solid';

			if (!collapsed) {
				table.scrollIntoView({ behavior: 'smooth', block: 'nearest' });
			}
		});
	});
});
