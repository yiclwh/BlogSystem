﻿namespace BlogSystem.Data
{
    using Microsoft.AspNet.Identity.EntityFramework;
    using System.Data.Entity;
    //using BlogSystem.Data.Migrations;
    using BlogSystem.Models;

    public class BlogSystemDbContext : IdentityDbContext
    {
        public BlogSystemDbContext()
            : base("BlogSystemConnection")
        {
            //Database.SetInitializer(new MigrateDatabaseToLatestVersion<BlogSystemDbContext, Configuration>());
        }

        IDbSet<ApplicationUser> Users
        {
            get;
            set;
        }

        IDbSet<Post> Posts
        {
            get;
            set;
        }

        public static BlogSystemDbContext Create()
        {
            return new BlogSystemDbContext();
        }
    }
}
