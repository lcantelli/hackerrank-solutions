#/bin/bash
read a
read b
read c
#debugger on
set -x	

if [ $a -eq $b ] && [ $a -eq $c ]; then
    echo "EQUILATERAL"
elif [ $a -eq $b ] || [ $a -eq $c ] || [ $b -eq $c ]; then
    echo "ISOSCELES"
else
    echo "SCALENE"
fi
#debugger off
set +x	