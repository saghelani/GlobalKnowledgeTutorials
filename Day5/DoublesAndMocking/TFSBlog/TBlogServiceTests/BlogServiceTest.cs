
using System.Collections.Generic;
using System.Linq;

using Microsoft.VisualStudio.TestTools.UnitTesting;

using TBlogService;
using TBlogService.Models;
using TFSBlogRepository;
using Moq;

namespace TBlogServiceTests
{
    [TestClass]
    public class BlogServiceTest
    {

        private Mock<IBlogRepository> blogRepository;

        [TestInitialize]
        public void TestInitialize()
        {
            this.blogRepository = new Mock<IBlogRepository>();
        }

        [TestMethod]
        public void GetBlogs_LessThanPageSizeBlogs_ReturnsAllBlogs()
        {
            IQueryable<BlogModel.Blog> blogs = new List<BlogModel.Blog>
            {
                new BlogModel.Blog { User = new BlogModel.User { Name = "Cal" } },
                new BlogModel.Blog { User = new BlogModel.User { Name = "Michael" } }
            }.AsQueryable();

            blogRepository.Setup(b => b.GetBlogs()).Returns(blogs);

            BlogService target = new BlogService(blogRepository.Object);

            IEnumerable<Blog> actual = target.GetBlogs();

            Assert.AreEqual(2, actual.Count());
        }
    }
}
