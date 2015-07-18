﻿using ServiceStack.Text;
using System;
using System.Diagnostics;

namespace ServiceStack.Authentication.Aad.SelfHostTest
{
    class Program
    {
        static void Main(string[] args)
        {
            var port = 8088;
            new AppHost().Init().Start("http://*:{0}/".Fmt(port));
            "ServiceStack SelfHost listening at http://localhost:{0}".Fmt(port).Print();
            //Process.Start("http://localhost:{0}/secure".Fmt(port)); // TODO: Support starting at /secure. Seem to have trouble w/ redirect URL
            Process.Start("http://localhost:{0}/auth/aad".Fmt(port));
            Console.ReadLine();
        }
    }
}
