namespace LinqSample
{
    using System.Collections.Generic;
    using System.Linq;

    public sealed class NameQuery
    {
        private readonly IEnumerable<string> names;

        public NameQuery(IEnumerable<string> names)
        {
            this.names = names;
        }

        public IEnumerable<string> GetNamesUsingMethodSyntax(string startsWith, string endsWith)
        {
            return names
                .Where(name => name.StartsWith(startsWith) || name.EndsWith(endsWith))
                .OrderBy(name => name)
                .Select(name => name.ToUpper());
        }

        public IEnumerable<string> GetNamesUsingQuerySyntax(string startsWith, string endsWith)
        {
            return from name in names
                   where name.StartsWith(startsWith) || name.EndsWith(endsWith)
                   orderby name
                   select name.ToUpper();
        }
    }
}
