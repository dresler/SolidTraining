using System;
using Castle.Windsor;

namespace SolidTraining.DIP
{
    /// <summary>
    /// The “D” in SOLID is for Dependency Inversion Principle, 
    /// which states that high-level modules shouldn’t depend on low-level modules, 
    /// but both should depend on shared abstractions. 
    /// In addition, abstractions should not depend on details – instead, 
    /// details should depend on abstractions.
    /// 
    /// Types of dependencies
    /// - .Net Framework
    /// - Third-party Libraries
    /// - Database
    /// - File system
    /// - Email
    /// - Web Services
    /// - System Resources (Clock)
    /// - Configuration
    /// - The new keyword
    /// - Static methods
    /// - Thread.Sleep
    /// - Random
    /// 
    /// </summary>
    public class DependencyInversionPrinciple
    {
        // How to test GreetingsProvider?

        public static void Run()
        {
            var container = new WindsorContainer();
            container.Install(new DummyInstaller());

            var guidWrapper1 = container.Resolve<IGuidWrapper>();
            Console.WriteLine(guidWrapper1.GetGuid());

            var guidWrapper2 = container.Resolve<IGuidWrapper>();
            Console.WriteLine(guidWrapper2.GetGuid());
        }
    }
}