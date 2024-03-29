﻿/*
Author: Peter Forsling
Date: 12 October 2020
Course: CS 4540, University of Utah, School of Computing
Copyright: CS 4540 and Peter Forsling - This work may not be copied for use in Academic Coursework.

I, Peter Forsling, certify that I wrote this code from scratch and did not copy it in part or whole from
another source. Any references used in the completion of the assignment are cited in my README file.

File Contents
This file contains the code necessary to seed the identity database
*/


using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using URC.Areas.Identity.Data;

namespace URC.Data
{
    public class SeedUserRolesDB
    {

        /// <summary>
        /// Seeds the UserRolesDB if empty
        /// </summary>
        /// <param name="userManager"></param>
        /// <param name="roleManager"></param>
        public static void Seed(UserRolesDB context, UserManager<URCUser> userManager, RoleManager<IdentityRole> roleManager)
        {

            context.Database.EnsureCreated();
            //https://alexcodetuts.com/2019/05/22/how-to-seed-users-and-roles-in-asp-net-core/

            //Seed roles
            if (!roleManager.RoleExistsAsync("Student").Result)
            {
                IdentityRole studentRole = new IdentityRole
                {
                    Name = "Student"
                };
                IdentityResult studentRoleResult = roleManager.CreateAsync(studentRole).Result;
            }

            if (!roleManager.RoleExistsAsync("Professor").Result)
            {
                IdentityRole professorRole = new IdentityRole
                {
                    Name = "Professor"
                };
                IdentityResult professorRoleResult = roleManager.CreateAsync(professorRole).Result;
            }

            if (!roleManager.RoleExistsAsync("Administrator").Result)
            {
                IdentityRole administratorRole = new IdentityRole
                {
                    Name = "Administrator"
                };
                IdentityResult administratorRoleResult = roleManager.CreateAsync(administratorRole).Result;
            }


            //Seed users
            if (userManager.FindByEmailAsync("jabrail@localhost").Result == null)
            {
                URCUser jabrail = new URCUser
                {
                    UserName = "jabrail@localhost",
                    Email = "jabrail@localhost",
                    EmailConfirmed = true
                };

                IdentityResult result = userManager.CreateAsync(jabrail, "123ABC!@#def").Result;

                if (result.Succeeded)
                {
                    userManager.AddToRoleAsync(jabrail, "Student").Wait();
                }
            }
            if (userManager.FindByEmailAsync("parker@localhost").Result == null)
            {
                URCUser parker = new URCUser
                {
                    UserName = "parker@localhost",
                    Email = "parker@localhost",
                    EmailConfirmed = true
                };

                IdentityResult result = userManager.CreateAsync(parker, "123ABC!@#def").Result;

                if (result.Succeeded)
                {
                    userManager.AddToRoleAsync(parker, "Professor").Wait();
                }
            }
            if (userManager.FindByEmailAsync("peter@localhost").Result == null)
            {
                URCUser peter = new URCUser
                {
                    UserName = "peter@localhost",
                    Email = "peter@localhost",
                    EmailConfirmed = true
                };

                IdentityResult result = userManager.CreateAsync(peter, "123ABC!@#def").Result;

                if (result.Succeeded)
                {
                    userManager.AddToRoleAsync(peter, "Administrator").Wait();
                }
            }



            //Required for assignment
            if (userManager.FindByEmailAsync("admin@utah.edu").Result == null)
            {
                URCUser admin = new URCUser
                {
                    UserName = "admin",
                    Email = "admin@utah.edu",
                    EmailConfirmed = true
                };

                IdentityResult result = userManager.CreateAsync(admin, "123ABC!@#def").Result;

                if (result.Succeeded)
                {
                    userManager.AddToRoleAsync(admin, "Administrator").Wait();
                }
            }

            if (userManager.FindByEmailAsync("professor@utah.edu").Result == null)
            {
                URCUser professor = new URCUser
                {
                    UserName = "professor",
                    Email = "professor@utah.edu",
                    EmailConfirmed = true
                };

                IdentityResult result = userManager.CreateAsync(professor, "123ABC!@#def").Result;

                if (result.Succeeded)
                {
                    userManager.AddToRoleAsync(professor, "Professor").Wait();
                }
            }
            if (userManager.FindByEmailAsync("professor_mary@utah.edu").Result == null)
            {
                URCUser mary = new URCUser
                {
                    UserName = "professor_mary",
                    Email = "professor_mary@utah.edu",
                    EmailConfirmed = true
                };

                IdentityResult result = userManager.CreateAsync(mary, "123ABC!@#def").Result;

                if (result.Succeeded)
                {
                    userManager.AddToRoleAsync(mary, "Professor").Wait();
                }
            }

            if (userManager.FindByEmailAsync("u1234567@utah.edu").Result == null)
            {
                URCUser u1234567 = new URCUser
                {
                    UserName = "u1234567",
                    Email = "u1234567@utah.edu",
                    EmailConfirmed = true
                };

                IdentityResult result = userManager.CreateAsync(u1234567, "123ABC!@#def").Result;

                if (result.Succeeded)
                {
                    userManager.AddToRoleAsync(u1234567, "Student").Wait();
                }
            }
            if (userManager.FindByEmailAsync("u0000000@utah.edu").Result == null)
            {
                URCUser u0000000 = new URCUser
                {
                    UserName = "u0000000",
                    Email = "u0000000@utah.edu",
                    EmailConfirmed = true
                };

                IdentityResult result = userManager.CreateAsync(u0000000, "123ABC!@#def").Result;

                if (result.Succeeded)
                {
                    userManager.AddToRoleAsync(u0000000, "Student").Wait();
                }
            }

            if (userManager.FindByEmailAsync("test@utah.edu").Result == null)
            {
                URCUser test = new URCUser
                {
                    UserName = "test",
                    Email = "test@utah.edu",
                    EmailConfirmed = true
                };

                IdentityResult result = userManager.CreateAsync(test, "123ABC!@#def").Result;

                if (result.Succeeded)
                {
                    userManager.AddToRoleAsync(test, "Student").Wait();
                }
            }

            if (userManager.FindByEmailAsync("u0000001@utah.edu").Result == null)
            {
                URCUser u0000001 = new URCUser
                {
                    UserName = "u0000001@utah.edu",
                    Email = "u0000001@utah.edu",
                    EmailConfirmed = true
                };

                IdentityResult result = userManager.CreateAsync(u0000001, "123ABC!@#def").Result;

                if (result.Succeeded)
                {
                    userManager.AddToRoleAsync(u0000001, "Student").Wait();
                }
            }

            if (userManager.FindByEmailAsync("u0000002@utah.edu").Result == null)
            {
                URCUser u0000002 = new URCUser
                {
                    UserName = "u0000002@utah.edu",
                    Email = "u0000002@utah.edu",
                    EmailConfirmed = true
                };

                IdentityResult result = userManager.CreateAsync(u0000002, "123ABC!@#def").Result;

                if (result.Succeeded)
                {
                    userManager.AddToRoleAsync(u0000002, "Student").Wait();
                }
            }

            if (userManager.FindByEmailAsync("u0000003@utah.edu").Result == null)
            {
                URCUser u0000003 = new URCUser
                {
                    UserName = "u0000003@utah.edu",
                    Email = "u0000003@utah.edu",
                    EmailConfirmed = true
                };

                IdentityResult result = userManager.CreateAsync(u0000003, "123ABC!@#def").Result;

                if (result.Succeeded)
                {
                    userManager.AddToRoleAsync(u0000003, "Student").Wait();
                }
            }



        }
    }
}
