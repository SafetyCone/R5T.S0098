using System;


namespace R5T.S0098
{
    public class SolutionContextOperations : ISolutionContextOperations
    {
        #region Infrastructure

        public static ISolutionContextOperations Instance { get; } = new SolutionContextOperations();


        private SolutionContextOperations()
        {
        }

        #endregion
    }
}
