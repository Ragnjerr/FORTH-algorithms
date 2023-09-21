\ Euclid's Algorithm in FORTH by Jeremy Lee Harden 21SEP2023

: euclid ( n1 n2 -- gcd) 
		begin
			?dup while
			tuck mod
		repeat . 
;
