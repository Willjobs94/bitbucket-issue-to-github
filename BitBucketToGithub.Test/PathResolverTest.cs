using System.IO;
using BitbucketToGithub.Utility;
using BitbucketToGithub.Utility.Contracts;
using NUnit.Framework;

namespace BitBucketToGithub.Test
{
    [TestFixture]
    public class PathResolverTest
    {

        [Test]
        public void ShouldGetBaseProjectPath()
        {
            Assert.That(_sut.BaseProject, Is.EqualTo(Path.Combine(_solutionPath, "BitbucketToGithub\\")));
        }

        [Test]
        public void ShouldGetDataProjectPath()
        {
            Assert.That(_sut.DataProject, Is.EqualTo(Path.Combine(_solutionPath, "BitbucketToGithub.Data\\")));
        }

        [Test]
        public void ShouldGetRootPath()
        {
            const string rootPath = "C:\\Users\\William Bello\\Source\\Repos\\";
            const string appveyorRootPath = "C:\\projects\\bitbucket-issue-to-github\\";
            Assert.That(_sut.RootPath, Is.EqualTo(rootPath).Or.EqualTo(appveyorRootPath));
        }

        [Test]
        public void ShouldGetSolutionPath()
        {
            Assert.That(_sut.SolutionPath, Is.EqualTo(_solutionPath));
        }

        [Test]
        public void ShouldGetTestProjectPath()
        {
            Assert.That(_sut.TestProject, Is.EqualTo(Path.Combine(_solutionPath, "BitbucketToGithub.Test\\")));
        }

        private static IPathResolver _sut = new PathResolver();
        private readonly string _solutionPath = _sut.SolutionPath;
    }
}