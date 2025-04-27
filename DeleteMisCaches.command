#!/bin/bash

DIR=`echo $0 | sed -E 's/\/[^\/]+$/\//'`
if [ "X$0" != "X$DIR" ]; then
	cd "$DIR"
fi

SAVEIFS=$IFS
IFS=$(echo -en "\n\b");

for i in $(find . -type f \( -iname "*.mis.cache" \))
do
   file=${i}
   if [ -e $file ]
   then
      echo "Trashing ${file}"
      rm "$file"
   fi
done

IFS=$SAVEIFS