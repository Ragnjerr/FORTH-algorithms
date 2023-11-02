\ Fibonacci Sequence in FORTH by Jeremy Lee Harden 
\ With comments updated 17SEP2023

variable int1
0 int1 !
variable int2
1 int2 !

: fib ( n -- seq)
		int2 @ int1 @ . . 
		2 do
			int1 @ int2 @	
			2dup + dup u.
			rot drop 2dup
			swap int1 !
			swap int2 !
			drop drop
		loop
;	
