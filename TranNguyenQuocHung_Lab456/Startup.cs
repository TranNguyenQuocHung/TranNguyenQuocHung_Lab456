﻿using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TranNguyenQuocHung_Lab456.Startup))]
namespace TranNguyenQuocHung_Lab456
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
