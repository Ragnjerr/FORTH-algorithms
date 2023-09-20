\ Fizzbuzz in FORTH by Jeremy Lee Harden 
\ With comments updated 17SEP2023

: buzz? ( n -- buzz?)
  dup 5 mod 0= if
		." buzz "
	then
;

: fizz? ( n -- fizz?)
	dup 3 mod 0= if
		." fizz "
	then
;

: fizzbuzz? ( n -- fizzbuzz?)
	dup dup 3 mod 0=
	swap 5 mod 0=
	and if
		." fizzbuzz "
	then
;

: sequence ( n -- seq)
	1 do i
	  dup .
		fizzbuzz?
		fizz?
		buzz?
		drop
	loop
;
