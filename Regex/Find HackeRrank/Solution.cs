using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;

class Solution {
    static void Main(String[] args) {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
        Regex begins = new Regex("^hackerrank");
        Regex ends = new Regex("hackerrank$");
        Regex both = new Regex("^hackerrank$");
        Regex bothTwice = new Regex("^hackerrank.*hackerrank$");
        
        int lines = Int32.Parse(Console.ReadLine());
        
        MatchCollection matchBoth = null;
        MatchCollection matchBegins = null;
        MatchCollection matchEnds = null;
        MatchCollection matchBothTwice = null;
        
        while(lines != 0){
            // read
            string line = Console.ReadLine();
            matchBoth = both.Matches(line);
            matchBegins = begins.Matches(line);
            matchEnds = ends.Matches(line);
            matchBothTwice = bothTwice.Matches(line);
            
            if(matchBoth.Count > 0 || matchBothTwice.Count > 0){
                Console.WriteLine(0);
            }
            else if(matchBegins.Count > 0){
                Console.WriteLine(1);
            }
            else if(matchEnds.Count > 0){
                Console.WriteLine(2);
            }
            else{
                Console.WriteLine(-1);
            }
            lines--;
        }
    }
}