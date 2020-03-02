using System;
using System.Threading.Tasks;
using Microsoft.CodeAnalysis.MSBuild;

namespace Walterlv.Demo.Roslyn
{
    class Program
    {
        async static Task Main(string[] args)
        {
            var solution = await MSBuildWorkspace.Create().OpenSolutionAsync(
       @"D:\WIP\Desktop\Walterlv.Demo.Roslyn\CodeScanTest.sln");
        }
    }
}
