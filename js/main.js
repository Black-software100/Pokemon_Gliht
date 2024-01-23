var cccalc = (function() {
	var _natureList = [
		"Fuerte",
		"Huraña",
		"Audaz",
		"Firme",
		"Pícara",
		"Osada",
		"Dócil",
		"Plácida",
		"Agitada",
		"Floja",
		"Miedosa",
		"Activa",
		"Seria",
		"Alegre",
		"Ingenua",
		"Modesta",
		"Afable",
		"Mansa",
		"Tímida",
		"Alocada",
		"Serena",
		"Amable",
		"Grosera",
		"Cauta",
		"Rara"
	],
	_genderList = [
		0,
		50,
		75,
		150,
		200
	],
	_init = function() {
		$(btn_calc).on('click', _calc);
	},
	_calc = function() {
		var tid, sid, num, num2, hab, bEncontrado = false, gend, prob;
		$('#mensajes').empty();
		tid = parseInt($('#id_normal').val(), 10);
		sid = parseInt($('#id_oculto').val(), 10);
		if (isNaN(tid) || isNaN(sid) || tid < 0 || sid < 0) {
			_print('El ID o ID oculto no son válidos');
			return;
		}
		
		num = 0;
		while (num < _genderList.length) {
			num2 = _genderList[num];
			while (num2 < _genderList[num] + _natureList.length) {
				if ((tid ^ sid ^ num2) < 8) {
					bEncontrado = true;
					hab = num2 % 2;
					gend = '';
					prob = '';
					switch (num)
					{
						case 0:
							gend = 'macho';
							prob = 'puede ser macho o hembra';
							break;
					case 1:
							gend = 'hembra';
							prob = '87,5% de ser macho';
							break;
					case 2:
							gend = 'hembra';
							prob = '75% de ser macho';
							break;
					case 3:
							gend = 'hembra';
							prob = '50% de ser macho';
							break;
					case 4:
							gend = 'hembra';
							prob = '25% de ser macho';
							break;
					}
					_print('Usando un Pokémon '+gend+' con Gran Encanto. Género del variocolor: '+prob+', Naturaleza: '+_natureList[num2-_genderList[num]]+'. Habilidad: '+hab.toString()+'.');
				}
				num2++;
			}
			num++;
		}
		if (!bEncontrado) {
			_print('La combinación de ID '+tid+'/'+sid+' no puede beneficiarse del abuso de Gran Encanto.');
		}
	},
	_print = function(txt) {
		$('#mensajes').append($('<tr><td></td></tr>').text(txt));
	};

	return {
		init: _init
	};

})();

$(cccalc.init);
