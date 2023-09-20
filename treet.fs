\ Armour Treet in FORTH by Jeremy Lee Harden 17SEP2023

: treet ( n -- at)
		dup 7 mod 0 = if
			." ARMOUR TREET!!! " 
			else .
		then
;

: sequence ( n -- seq)
		1 do i
			dup
			treet
			drop
		loop
;

