using System;
using System.Threading.Tasks;

using R5T.F0000;
using R5T.L0031.Extensions;
using R5T.L0038;
using R5T.T0132;
using R5T.T0172.Extensions;
using R5T.T0187.Extensions;
using R5T.T0195.Extensions;
using R5T.T0197.Extensions;
using R5T.T0198;
using R5T.T0201;


namespace R5T.S0098
{
    [FunctionalityMarker]
    public partial interface ISolutionGenerationScripts : IFunctionalityMarker
    {
        public async Task In_New_SampleSolutionContext()
        {
            /// Run.
            var (humanOutputTextFilePath, logFilePath) = await Instances.ApplicationContextOperator.In_ApplicationContext_Undated(
                Instances.Values.ApplicationName,
                ApplicationContextOperation);

            static async Task ApplicationContextOperation(IApplicationContext applicationContext)
            {
                var libraryName = Instances.Values.Sample_LibraryName.Value.ToUnadjustedLibraryName();
                var libraryDescription = Instances.Values.Sample_LibraryDescription;
                var isPrivate = true;
                var repositoryUrl = new IsSet<IRepositoryUrl>();

                var solutionSpecification = Instances.SolutionSpecificationGenerationOperations.Get_WebLibraryWithConstructionSolutionSpecification(
                    libraryName,
                    libraryDescription,
                    isPrivate);

                var creationOutput = new WebLibraryWithConstructionCreationOutput();

                var solutionContextOperations = Instances.SolutionContextOperationSets.Create_WebLibraryForBlazorWithConstructionServerAndClient(
                    solutionSpecification,
                    repositoryUrl,
                    creationOutput);

                await Instances.SampleSolutionOperations.In_New_SampleSolutionContext(
                    applicationContext.TextOutput,
                    solutionContextOperations);

                Instances.VisualStudioOperator.OpenSolutionFile(
                    creationOutput.SolutionFilePath.Value);
            }

            Instances.NotepadPlusPlusOperator.Open(
                humanOutputTextFilePath
                // Ignore the log file.
                );
        }

        public async Task Create_SampleRazorLibraryWithWebAssemblyClientAndServerSolution()
        {
            /// Run.
            var (humanOutputTextFilePath, logFilePath) = await Instances.ApplicationContextOperator.In_ApplicationContext_Undated(
                Instances.Values.ApplicationName,
                ApplicationContextOperation);

            static async Task ApplicationContextOperation(IApplicationContext applicationContext)
            {
                var libraryName = Instances.Values.Sample_LibraryName.Value.ToUnadjustedLibraryName();
                var libraryDescription = Instances.Values.Sample_LibraryDescription;
                var isPrivate = true;
                var repositoryUrl = new IsSet<IRepositoryUrl>();

                var solutionSpecification = Instances.SolutionSpecificationGenerationOperations.Get_WebLibraryWithConstructionSolutionSpecification(
                    libraryName,
                    libraryDescription,
                    isPrivate);

                var creationOutput = new WebLibraryWithConstructionCreationOutput();

                var solutionContextOperations = Instances.SolutionContextOperationSets.Create_WebLibraryForBlazorWithConstructionServerAndClient(
                    solutionSpecification,
                    repositoryUrl,
                    creationOutput);

                await Instances.SampleSolutionOperations.In_New_SampleSolutionContext(
                    applicationContext.TextOutput,
                    solutionContextOperations);

                Instances.VisualStudioOperator.OpenSolutionFile(
                    creationOutput.SolutionFilePath.Value);
            }

            Instances.NotepadPlusPlusOperator.Open(
                humanOutputTextFilePath
                // Ignore the log file.
                );
        }

        /// <summary>
        /// Create an empty solution.
        /// </summary>
        public async Task Create_EmptySolution()
        {
            /// Inputs.
            var solutionDirectoryPath = @"C:\Code\DEV\Git\GitHub\SafetyCone\Sample.Repository.Private\source\".ToSolutionDirectoryPath();
            var solutionName = "Sample.Repository".ToSolutionName();
            var isPrivate = true;


            /// Run.
            var (humanOutputTextFilePath, logFilePath) = await Instances.ApplicationContextOperator.In_ApplicationContext_Undated(
                Instances.Values.ApplicationName,
                ApplicationContextOperation);

            async Task ApplicationContextOperation(IApplicationContext applicationContext)
            {
                var solutionCreationResult = await Instances.SolutionGenerationOperations.Create_EmptySolution(
                    solutionDirectoryPath,
                    solutionName,
                    isPrivate,
                    applicationContext.TextOutput);

                Instances.VisualStudioOperator.OpenSolutionFile(
                    solutionCreationResult.SolutionFilePath.Value);
            }

            Instances.NotepadPlusPlusOperator.Open(
                humanOutputTextFilePath
                // Ignore the log file.
                );
        }
    }
}
