\ Halestone Trajectory in FORTH by Jeremy Lee Harden 
\ With updated comments 17SEP2023

: traject ( n -- seq)
	begin
		dup .
		dup 1 = if 
		  drop quit else
			dup 2 mod 0= if
			  2 / else
				3 * 1 + 
			then
		then
	again
;
