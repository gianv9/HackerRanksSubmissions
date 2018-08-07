using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;

class Solution {
    static int lines;
    static string expression;
    
    static void Main(String[] args) {
        expression = "^([Hh][Ii]\\s[^Dd])";
        // see: https://msdn.microsoft.com/en-us/library/bk1x0726(v=vs.110).aspx#Examples
        lines = Int32.Parse(Console.ReadLine());
        
        while(lines != 0){
            string line = Console.ReadLine();
            Match match = Regex.Match(line,expression);
            if(match.Success){
                Console.WriteLine(line);
            }
            lines--;
        }
    }
}