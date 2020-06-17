using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TranNguyenQuocHung_Lab456.Models;
using TranNguyenQuocHung_Lab456.ViewModels;

namespace TranNguyenQuocHung_Lab456.ViewModels
{
    public class CoursesViewModel
    {
        public IEnumerable<Course> UpComingCourses { get; set; }
        public bool ShowAction { get; set; }
    }
}