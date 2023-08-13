using System;
using System.Threading.Tasks;


namespace R5T.S0098
{
    class Program
    {
        static async Task Main()
        {
            //await SolutionGenerationScripts.Instance.In_New_SampleSolutionContext();
            //await SolutionGenerationScripts.Instance.Create_EmptySolution();
            await SolutionGenerationScripts.Instance.Create_SampleRazorLibraryWithWebAssemblyClientAndServerSolution();
        }
    }
}