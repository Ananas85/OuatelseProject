using System;
using System.Linq;

namespace Ouatelse
{
    public static class DatabaseInjector
    {

        public static IDatabase Database
        {
            get { return IsInUnitTest ? (IDatabase)TestDatabase.Instance : Ouatelse.Database.Instance; }
        }

        public static bool IsInUnitTest
        {
            get
            {
                const string testAssemblyName = "Microsoft.VisualStudio.QualityTools.UnitTestFramework";
                return AppDomain.CurrentDomain.GetAssemblies()
                    .Any(a => a.FullName.StartsWith(testAssemblyName));
            }
        }
    }
}
