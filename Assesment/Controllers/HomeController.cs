using System.Diagnostics;
using Assesment.Models;
using Microsoft.AspNetCore.Mvc;

namespace Assesment.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            var tree = new List<TreeNode>
            {
                new TreeNode
                {
                    Name = "USA",
                    City = "All",
                    Children = new List<TreeNode>
                    {
                        new TreeNode
                        {
                            Name = "New York",
                            Children = new List<TreeNode>
                            {
                                new TreeNode { Name = "New York City", City = "New York City" },
                                new TreeNode { Name = "Buffalo", City = "Buffalo" },
                                new TreeNode { Name = "Albany", City = "Albany" }
                            }
                        },
                        new TreeNode
                        {
                            Name = "Alabama",
                            Children = new List<TreeNode>
                            {
                                new TreeNode { Name = "", City = "" },
                                //new TreeNode { Name = "Buffalo", City = "Buffalo" },
                                //new TreeNode { Name = "Albany", City = "Albany" }
                            }
                        },
                        new TreeNode
                        {
                            Name = "California",
                            Children = new List<TreeNode>
                            {
                                new TreeNode { Name = "", City = "" },
                                //new TreeNode { Name = "Buffalo", City = "Buffalo" },
                                //new TreeNode { Name = "Albany", City = "Albany" }
                            }
                        }
                    }
                },
                new TreeNode
                {
                    Name = "Canada",
                    City = "All",
                    Children = new List<TreeNode>
                    {
                        new TreeNode
                        {
                            Name = "Ontano",
                            Children = new List<TreeNode>
                            {
                                new TreeNode { Name = "", City = "" }
                            }
                        },
                        new TreeNode
                        {
                            Name = "British Columbia",
                            Children = new List<TreeNode>
                            {
                                new TreeNode { Name = "", City = "" }
                            }
                        }
                    }
                },
                new TreeNode
                {
                    Name = "Australia",
                    City = "All",
                    Children = new List<TreeNode>
                    {
                        new TreeNode
                        {
                            Name = "New South Wales",
                            Children = new List<TreeNode>
                            {
                                new TreeNode { Name = "", City = "" }
                            }
                        },
                        new TreeNode
                        {
                            Name = "QueenIsland",
                            Children = new List<TreeNode>
                            {
                                new TreeNode { Name = "", City = "" }
                            }
                        }
                    }
                }
            };

            return View(tree);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
