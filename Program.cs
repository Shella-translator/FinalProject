using System;
using static System.Console;

string [] Array={"Hello", "2", "world", ":-)"};
PrintString(Array);
WriteLine();


void PrintString (string [] Array)
{
for (int i = 0; i < Array.Length; i++)
{
    Write(Array[i]);
    if(i<Array.Length-1)Write(", ");
}
}

string [] NewArray;
int j=0;

for (int i = 0; i < Array.Length; i++)
{
    if (Array[i].Length<=3)j++;
   
}
NewArray= new string [j];
int x=0;
for (int n = 0; n < Array.Length; n++)
{
    if (Array[n].Length<=3)
    {
        NewArray[x]=Array[n];
        x++;
    }
   
}


PrintString(NewArray);