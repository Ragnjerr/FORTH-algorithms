\ Fibonacci Sequence in FORTH by Jeremy Lee Harden 
\ With comments updated 17SEP2023

variable int1
variable int2

: fib ( n -- seq)
		1 0 . . 
		0 int1 !
		1 int2 !
		2 do
			int1 @
			int2 @	
			2dup + dup .
			rot drop 2dup
			swap int1 !
			swap int2 !
			drop drop
		loop
;	
