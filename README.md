##C# Longest Common Subsequence (LCS)

[![Build status](https://ci.appveyor.com/api/projects/status/crfl6c9wrvdlbhbr?svg=true)](https://ci.appveyor.com/project/jeff-pang/longestcommonsubsequence-1t5i2)

###Description
This is a C# implementation of LCS without recursion. The code is written to be as readable as possible, sometimes additional variables are created just for the sake of readability. For a detailed explanation on how LCS works see [LCS Tutorial](http://jeff-pang.com/LongestCommonSubsequence/)

The unit test is based on the following input:

> row = "ABCDCBA" 
> col = "DCBAABC"


and expected output:
> LCS = "DCBA"

So, the LCS table will look like:
> | * | * | A | B | C | D | C | B | A |   |
> |---|---|---|---|---|---|---|---|---|---|
> | * | 0 | 0 | 0 | 0 | 0 | 0 | 0 | 0 |<< initialise row to 0
> | D | 0 | 0 | 0 | 0 | 1 | 1 | 1 | 1 |
> | C | 0 | 0 | 0 | 1 | 1 | 2 | 2 | 2 |
> | B | 0 | 0 | 1 | 1 | 1 | 2 | 3 | 3 |
> | A | 0 | 1 | 1 | 1 | 1 | 2 | 3 | 4 |
> | A | 0 | 1 | 1 | 1 | 1 | 2 | 3 | 4 |
> | B | 0 | 1 | 2 | 2 | 2 | 2 | 3 | 4 |
> | C | 0 | 1 | 2 | 3 | 3 | 3 | 2 | 4 |
> &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; ^
> &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; initialise column to 0



