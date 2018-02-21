using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Models.Factory
{
    public class Report : Document
    {
        protected override void CreatePages()
        {
            Pages.Add(new IntroductionPage());
            Pages.Add(new ResultPage());
            Pages.Add(new ConclusionPage());
            Pages.Add(new SummaryPage());
            Pages.Add(new BibliographyPage());
        }

        internal override void ChangeThis()
        {
            Console.WriteLine("This is changed in the Reports");
        }
    }
}
