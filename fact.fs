\ Factorial Algorithm in FORTH by Jeremy Harden 16SEPT2023

variable int1
variable int2

: fact ( n -- seq)
		int1 ! 
		2 int2 !
		1000 0 do
			int1 @
		  int2 @ 
			2dup mod 0 = if
				dup	. 
			then
			1 + int2 ! drop
		loop 
;
