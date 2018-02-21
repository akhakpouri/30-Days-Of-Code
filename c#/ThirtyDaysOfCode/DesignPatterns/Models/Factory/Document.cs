using System;
using System.Collections.Generic;

namespace DesignPatterns.Models.Factory
{
    /// <summary>
    /// The 'Creator' abstract class
    /// </summary>
    public abstract class Document
    {
        // Constructor calls abstract Factory method
        protected Document()
        {
            CreatePages();
        }

        public List<Page> Pages { get; } = new List<Page>();

        protected abstract void CreatePages();

        internal virtual void ChangeThis()
        {
            Console.Write("This method should be changed");
        }
    }
}
