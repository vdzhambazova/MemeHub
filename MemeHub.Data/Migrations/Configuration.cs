using System;
using System.Linq;
using MemeHub.Models.Enums;
using MemeHub.Models.Models;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace MemeHub.Data.Migrations
{
    using System.Data.Entity.Migrations;

    internal sealed class Configuration : DbMigrationsConfiguration<MemeHubContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(MemeHubContext context)
        {
            if (!context.Roles.Any(role => role.Name == "Poster"))
            {
                var store = new RoleStore<IdentityRole>(context);
                var manager = new RoleManager<IdentityRole>(store);
                var role = new IdentityRole("Poster");
                manager.Create(role);
            }

            if (!context.Roles.Any(role => role.Name == "Admin"))
            {
                var store = new RoleStore<IdentityRole>(context);
                var manager = new RoleManager<IdentityRole>(store);
                var role = new IdentityRole("Admin");
                manager.Create(role);

            }

            //context.Memes.AddOrUpdate(m => m.Id,
            //    new Meme()
            //    {
            //        MemeImageUrl = "https://img-9gag-fun.9cache.com/photo/agLj0rK_700b.jpg",
            //        Caption = "Hello there!",
            //        PostDate = new DateTime(2017, 04, 24, 12, 23, 05),
            //        MemePoints = 350,
            //        Category = Category.Awesome
            //    },
            //    new Meme()
            //    {
            //        MemeImageUrl =
            //            "https://scontent-frt3-1.xx.fbcdn.net/v/t1.0-9/18056795_1181974348594747_958012803235515982_n.jpg?oh=3beab6954310eee8c384025b432bcb28&oe=5976D709",
            //        Caption = "Life is so harsh sometimes...",
            //        PostDate = new DateTime(2017, 04, 25, 18, 47, 05),
            //        MemePoints = 259,
            //        Category = Category.Dank
            //    },
            //    new Meme()
            //    {
            //        MemeImageUrl =
            //            "https://scontent-frt3-1.xx.fbcdn.net/v/t1.0-9/18157459_1418749401479118_4275877087678573234_n.jpg?oh=74a9d459d5ee43f5d58dda1a61a4ee97&oe=5991FD65",
            //        Caption = "Welcome to the meme age",
            //        PostDate = new DateTime(2017, 04, 26, 19, 01, 05),
            //        MemePoints = 19,
            //        Category = Category.Awesome
            //    },
            //    new Meme()
            //    {
            //        MemeImageUrl =
            //            "https://scontent-frt3-1.xx.fbcdn.net/v/t1.0-9/18119362_1292654840849636_4011701886733815866_n.jpg?oh=2363901fe73c13521b9f6529ebfa6923&oe=59797AEC",
            //        Caption = "It always works both ways",
            //        PostDate = new DateTime(2017, 04, 26, 19, 02, 26),
            //        MemePoints = 134,
            //        Category = Category.Hilarious
            //    },
            //    new Meme()
            //    {
            //        MemeImageUrl =
            //            "https://scontent-frt3-1.xx.fbcdn.net/v/t1.0-0/s480x480/18058216_650850988442317_4170010041095781939_n.jpg?oh=7b59b05752bbd23657ad8ab4ae8a1bca&oe=59913227",
            //        Caption = "Savage boss is savage...",
            //        PostDate = new DateTime(2017, 04, 26, 19, 11, 26),
            //        MemePoints = 150,
            //        Category = Category.Awesome
            //    },
            //    new Meme()
            //    {
            //        MemeImageUrl =
            //            " https://scontent-frt3-1.xx.fbcdn.net/v/t1.0-9/17952973_1419640471435682_8434712308683818337_n.jpg?oh=50be29f982d5b22033fad180034d89b4&oe=59C24A16",
            //        Caption = "Sad but true...",
            //        PostDate = new DateTime(2017, 04, 26, 19, 35, 26),
            //        MemePoints = 940,
            //        Category = Category.Dank
            //    },
            //    new Meme()
            //    {
            //        MemeImageUrl =
            //            "https://tastelessgentlemen.com/wp-content/uploads/2017/04/lUnVPgxojMgV3dKmXDRVqniscHNgQJT6VIxCI1gbN10.jpg",
            //        Caption = "Darker than dark...",
            //        PostDate = new DateTime(2017, 04, 27, 13, 49, 26),
            //        MemePoints = 886,
            //        Category = Category.Dank
            //    },
            //    new Meme()
            //    {
            //        MemeImageUrl =
            //            "https://tastelessgentlemen.com/wp-content/uploads/2017/04/n5VZp1j.jpg",
            //        Caption = "Facts",
            //        PostDate = new DateTime(2017, 04, 27, 13, 50, 56),
            //        MemePoints = 150,
            //        Category = Category.Dank
            //    },
            //    new Meme()
            //    {
            //        MemeImageUrl =
            //            "https://scontent.fsof3-1.fna.fbcdn.net/v/t1.0-9/18156866_1954788721410044_3208831830926941289_n.png?oh=1388f7e5094f84617a8868950d03c1f0&oe=5992C656",
            //        Caption = "Just do it..",
            //        PostDate = new DateTime(2017, 04, 27, 14, 19, 37),
            //        MemePoints = 756,
            //        Category = Category.Awesome
            //    });
        }
    }
}

