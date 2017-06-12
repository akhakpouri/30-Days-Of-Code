using System.Collections.Generic;

namespace DesignPatterns.Models.Factory
{
    /// <summary>
    /// The 'Creator' abstract class
    /// </summary>
    public abstract class Document
    {
        // Constructor calls abstract Factory method
        public Document()
        {
            CreatePages();
        }

        public List<Page> Pages { get; } = new List<Page>();

        public abstract void CreatePages();
    }
}
