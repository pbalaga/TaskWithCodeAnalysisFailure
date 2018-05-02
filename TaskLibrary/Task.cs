using Microsoft.Build.Utilities;

namespace TaskLibrary
{
    public class SampleTask : Task
    {
        public override bool Execute()
        {
            var projectDependencyWorks = new TaskDependencyLibrary.ProjectDependencyClass();
            var nugetDependencyWorks = new NodaTime.AnnualDate();
            var codeAnalysisDependencyDoesNotWork = Microsoft.CodeAnalysis.CSharp.CSharpSyntaxTree.ParseText("using System;");
            return true;
        }
    }
}
