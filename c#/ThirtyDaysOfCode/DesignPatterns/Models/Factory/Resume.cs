namespace DesignPatterns.Models.Factory
{
    /// <summary>
    /// A 'ConcreteCreator' class
    /// </summary>
    public class Resume : Document
    {
        protected override void CreatePages()
        {
            Pages.Add(new SkillsPage());
            Pages.Add(new EducationPage());
            Pages.Add(new ExperiencePage());
        }
    }
}