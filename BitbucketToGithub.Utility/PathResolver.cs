using System;
using System.IO;
using System.Text.RegularExpressions;
using BitbucketToGithub.Utility.Contracts;

namespace BitbucketToGithub.Utility
{
    public class PathResolver : IPathResolver
    {
        public string RootPath
        {
            get
            {
                const string pattern = @"(Bit[B | b]ucketToGithub).+";
                var basePath = AppDomain.CurrentDomain.BaseDirectory;
                var basePathRegEx = new Regex(pattern);
                return basePathRegEx.Replace(basePath, "");
            }
        }

        public string BaseProject
            => Path.Combine(SolutionPath, "BitbucketToGithub\\");

        public string TestProject
            => Path.Combine(SolutionPath, "BitbucketToGithub.Test\\");

        public string DataProject
            => Path.Combine(SolutionPath, "BitbucketToGithub.Data\\");

        public string SolutionPath
            => Path.Combine(RootPath, "BitbucketToGithub\\");
    }
}