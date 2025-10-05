using System.Reflection;

namespace RADLab3Solution.Models
{
    public class Person
    {
        public Title title { get; set; }
        public int ID { get; set; }

        public enum Title
        {
            Mr,
            Mrs
        }
    }
}
