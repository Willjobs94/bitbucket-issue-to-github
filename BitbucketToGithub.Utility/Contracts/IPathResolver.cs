namespace BitbucketToGithub.Utility.Contracts
{
    public interface IPathResolver
    {
        /// <summary>
        ///     Represent the path in which the entire project is. Ej: C:\projects\
        /// </summary>
        string RootPath { get; }

        /// <summary>
        ///     Represent the path of the BitbucketToGithub project
        /// </summary>
        string BaseProject { get; }

        /// <summary>
        ///     Represents the path ot the BitbucketToGithub.Test TestProject
        /// </summary>
        string TestProject { get; }

        /// <summary>
        ///     Represents the path ot the BitbucketToGithub.Data Class Library
        /// </summary>
        string DataProject { get; }

        /// <summary>
        ///     Get the path of the solution which enclose all projects
        /// </summary>
        string SolutionPath { get; }
    }
}