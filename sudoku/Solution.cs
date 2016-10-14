namespace ConsoleApplication
{
    public class Solution
    {
        public bool IsHumanSolveable { get; set; }
        public SolvedCell[] SolvedCells { get; set; }
    }

    public class SolvedCell 
    {
        public string Value { get; set; }
        public int X { get; set; }
        public int Y { get; set; }
    }
}