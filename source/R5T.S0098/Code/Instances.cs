using System;


namespace R5T.S0098
{
    public static class Instances
    {
        public static L0038.IApplicationContextOperator ApplicationContextOperator => L0038.ApplicationContextOperator.Instance;
        public static O0010.IProjectContextOperations ProjectContextOperations => O0010.ProjectContextOperations.Instance;
        public static F0033.INotepadPlusPlusOperator NotepadPlusPlusOperator => F0033.NotepadPlusPlusOperator.Instance;
        public static O0005.IProjectOperations ProjectOperations => O0005.ProjectOperations.Instance;
        public static O0013.O001.ISampleSolutionOperations SampleSolutionOperations => O0013.O001.SampleSolutionOperations.Instance;
        public static ISolutionContextOperations SolutionContextOperations => S0098.SolutionContextOperations.Instance;
        public static O0013.ISolutionContextOperationSets SolutionContextOperationSets => O0013.SolutionContextOperationSets.Instance;
        public static O0014.ISolutionGenerationOperations SolutionGenerationOperations => O0014.SolutionGenerationOperations.Instance;
        public static O0015.ISolutionSpecificationGenerationOperations SolutionSpecificationGenerationOperations => O0015.SolutionSpecificationGenerationOperations.Instance;
        public static IValues Values => S0098.Values.Instance;
        public static F0088.IVisualStudioOperator VisualStudioOperator => F0088.VisualStudioOperator.Instance;
    }
}