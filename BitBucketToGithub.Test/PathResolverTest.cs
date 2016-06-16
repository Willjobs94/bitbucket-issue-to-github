using System.IO;
using BitbucketToGithub.Utility;
using BitbucketToGithub.Utility.Contracts;
using NUnit.Framework;

namespace BitBucketToGithub.Test
{
    [TestFixture]
    public class PathResolverTest
    {
        [SetUp]
        public void SetUp()
        {
            _sut = new PathResolver();
        }

        [Test]
        public void ShouldGetBaseProjectPath()
        {
            Assert.That(_sut.BaseProject, Is.EqualTo(Path.Combine(SolutionPath, "BitbucketToGithub\\")));
        }

        [Test]
        public void ShouldGetDataProjectPath()
        {
            Assert.That(_sut.DataProject, Is.EqualTo(Path.Combine(SolutionPath, "BitbucketToGithub.Data\\")));
        }

        [Test]
        public void ShouldGetRootPath()
        {
            const string rootPath = "C:\\Users\\William Bello\\Source\\Repos\\";
            Assert.That(_sut.RootPath, Is.EqualTo(rootPath));
        }

        [Test]
        public void ShouldGetSolutionPath()
        {
            Assert.That(_sut.SolutionPath, Is.EqualTo(SolutionPath));
        }

        [Test]
        public void ShouldGetTestProjectPath()
        {
            Assert.That(_sut.TestProject, Is.EqualTo(Path.Combine(SolutionPath, "BitbucketToGithub.Test\\")));
        }

        private const string SolutionPath = "C:\\Users\\William Bello\\Source\\Repos\\BitbucketToGithub\\";
        private IPathResolver _sut;
    }
}