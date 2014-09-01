namespace IntersectionAndUnionOfSets
{
    using System;
    using System.Collections.Generic;
    
    public class IntersectionAndUnionOfSets
    {
        public static void Main()
        {
            ISet<string> firstSet = new HashSet<string>() { "Perl", "Java", "C#", "SQL", "PHP" };
            ISet<string> secondSet = new HashSet<string>() { "Oracle", "SQL", "MySQL" };

            Union(firstSet, secondSet);
            Intersect(firstSet, secondSet);
        }

        private static void Intersect(ISet<string> first, ISet<string> second)
        {
            ISet<string> intersect = new HashSet<string>(first);
            intersect.IntersectWith(second);
            Console.WriteLine();
        }

        private static void Union(ISet<string> first, ISet<string> second)
        {
            ISet<string> union = new HashSet<string>(first);
            union.UnionWith(second);
            Console.WriteLine();
        }
    }
}
