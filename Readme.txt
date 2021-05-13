ReadMe
======

We have a series of blocks of string data (e.g. a list of string arrays) where the data has the first row repeated in each blocks

We want to get a concatenated result that keeps the heading of the first block but removes the repeated (first) heading row from each subsequent block 

e.g. if you start with 
ABC
DEF
GHI

ABC
KLM
NOP

ABC
QRS
STU

ABC
VXY
Z12
345


You would get a result of:

ABC
DEF
GHI
KLM
NOP
QRS
STU
VXY
Z12
345

Please create a C# Function that consumes an enumeration of string arrays and in the most efficient way (in terms of the shortest possible answer to solve this problem) return the single resulting array.
