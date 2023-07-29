using System;

namespace FutrOS_CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(@"
    ███████╗██╗░░░██╗████████╗██████╗░  ░█████╗░░██████╗
    ██╔════╝██║░░░██║╚══██╔══╝██╔══██╗  ██╔══██╗██╔════╝
    █████╗░░██║░░░██║░░░██║░░░██████╔╝  ██║░░██║╚█████╗░
    ██╔══╝░░██║░░░██║░░░██║░░░██╔══██╗  ██║░░██║░╚═══██╗
    ██║░░░░░╚██████╔╝░░░██║░░░██║░░██║  ╚█████╔╝██████╔╝
    ╚═╝░░░░░░╚═════╝░░░░╚═╝░░░╚═╝░░╚═╝  ░╚════╝░╚═════╝░ C#
                    Now in C Sharp! BETA 1.0.0CS
          (c) 2020-2023 Futr. All rights reserved.
");

            Console.WriteLine(@"
[1] Continue with setup
[2] I've already done setup
");

            string setup = Console.ReadLine();
            if (setup == "1")
            {
                Console.Write("Please enter your username to be displayed: ");
                string name = Console.ReadLine();

                Console.Write("Please enter your Password to login: ");
                string pas = Console.ReadLine();

                Console.Write("Please enter your email address: ");
                string email = Console.ReadLine();

                using (var f = new System.IO.StreamWriter("username.txt"))
                {
                    f.Write(name);
                }
            }

            Console.WriteLine("[1] About [2] Apps [3] Release Notes\n©2020-2023 Futr. All rights reserved. ");
            setup = Console.ReadLine();

            if (setup == "1")
            {
                Console.WriteLine(@"
    ╔═══╦╗───────╔╗     
    ║╔═╗║║──────╔╝╚╗
    ║║─║║╚═╦══╦╗╠╗╔╝
    ║╚═╝║╔╗║╔╗║║║║║
    ║╔═╗║╚╝║╚╝║╚╝║╚╗
    ╚╝─╚╩══╩══╩══╩═╝  

    ███████╗██╗░░░██╗████████╗██████╗░  ░█████╗░░██████╗
    ██╔════╝██║░░░██║╚══██╔══╝██╔══██╗  ██╔══██╗██╔════╝
    █████╗░░██║░░░██║░░░██║░░░██████╔╝  ██║░░██║╚█████╗░
    ██╔══╝░░██║░░░██║░░░██║░░░██╔══██╗  ██║░░██║░╚═══██╗
    ██║░░░░░╚██████╔╝░░░██║░░░██║░░██║  ╚█████╔╝██████╔╝
    ╚═╝░░░░░░╚═════╝░░░░╚═╝░░░╚═╝░░╚═╝  ░╚════╝░╚═════╝░ C#
    BETA Version 1.0.0CS
    ©2020-2023 Futr. All rights reserved. This is a licensed and authentic version of FutrOS.
");
            }
            else if (setup == "2")
            {
                // App name's go here 
                string appname1 = "App name not assigned";
                string appname2 = "App name not assigned";
                string appname3 = "App name not assigned";

                Console.WriteLine(@"
                                                            ╔═══╗
                                                            ║╔═╗║
                                                            ║║─║╠══╦══╦══╗
                                                            ║╚═╝║╔╗║╔╗║══╣
                                                            ║╔═╗║╚╝║╚╝╠══║
                                                            ╚╝─╚╣╔═╣╔═╩══╝
                                                            ────║║─║║
                                                            ────╚╝─╚╝
");
                Console.WriteLine($"[1] {appname1}");
                Console.WriteLine($"[2] {appname2}");
                Console.WriteLine($"[3] {appname3}");
            }
            else if (setup == "3")
            {
                Console.WriteLine(@"
                                                ╔═══╗──╔╗─────────────╔═╗─╔╗──╔╗
                                                ║╔═╗║──║║─────────────║║╚╗║║─╔╝╚╗
                                                ║╚═╝╠══╣║╔══╦══╦══╦══╗║╔╗╚╝╠═╩╗╔╬══╦══╗
                                                ║╔╗╔╣║═╣║║║═╣╔╗║══╣║═╣║║╚╗║║╔╗║║║║═╣══╣
                                                ║║║╚╣║═╣╚╣║═╣╔╗╠══║║═╣║║─║║║╚╝║╚╣║═╬══║
                                                ╚╝╚═╩══╩═╩══╩╝╚╩══╩══╝╚╝─╚═╩══╩═╩══╩══╝
                                                      Welcome to FutrOS v1 C#!

                                                        Major Features:
                                    Terminal - Modify and view software info, all in FutrOS.
                                    Easier App Assignment - Quickly assign code to app slots.
                                        Setup - Setup your email, name and password.
");
            }
            else if (setup == "routing")
            {
                Console.WriteLine(@"
      FutrOS Manual Routing.
");
            }
            else if (setup == "v1")
            {
                Console.WriteLine(@"
      Thanks for using FutrOS, we hope you enjoy using v1.0.0! Now in C#!
");
            }
            else if (setup == "cs")
            {
                Console.WriteLine("FutrOS! Now in C#!");
            }
            else if (setup == "codename")
            {
                Console.WriteLine(@"
      V1
");
            }
            else if (setup == "c")
            {
                Console.WriteLine(@"
        (c) 2020-2023 Futr. All rights reserved.
");
            }
            else if (setup == "switchverlocation")
            {
                Console.WriteLine(@"
        Version specific location switching isn't available on this device.
");
            }
            else if (setup == "upgrade")
            {
                Console.WriteLine(@"
      Upgrade to newer versions of FutrOS at https://bit.ly/futrosupdate.
");
            }
            else if (setup == "beta")
            {
                Console.WriteLine(@"
This is a beta version of FutrOS
");
            }
            else if (setup == "archive")
            {
                Console.WriteLine(@"
This version of FutrOS is archived
");
            }
            else if (setup == "ver")
            {
                Console.WriteLine("v1.0.0CS-U (C#-Universal)");
            }
            else if (setup == "verletter")
            {
                Console.WriteLine(@"
       U - Universal version of FutrOS - Currently installed version
       L - Lite version of FutrOS 
       E - Embedded system version of FutrOS 
       M - Modified version of FutrOS
       CS - C# Version of FutrOS
");
            }
            else if (setup == "help")
            {
                Console.WriteLine(@"
All commands:
eos - End of Support Info
Routing - Routing Info
c - Copyright Info for FutrOS 0.1
Upgrade - How to upgrade FutrOS
beta - Beta Info
Archive - OS Archive Info
--------------------------------
Commands are case-sensitive. ");
            }
            else if (setup == "awesome")
            {
                Console.WriteLine(@"
╔══╦╗──────╔╗────────╔╗──────────────────────────╔╗───╔╗─────────╔╗
╚╗╔╣╚╦═╗╔═╦╣╠╗╔╦╦═╦╦╗║╚╦═╗╔═╦═╦═╦═╦╦╦╦╦═╦═╦╦═╗╔╦╦╣╚╦═╗║╚╦═╦╗╔═╦═╦╝║
─║║║║║╬╚╣║║║═╣║║║╬║║║║╔╣╬║║╩╬╗║╔╣╩╣╔╣║║╬║║║║╩╣║║║║║║╬║║║║╩╣╚╣╬║╩╣╬║
─╚╝╚╩╩══╩╩═╩╩╝╠╗╠═╩═╝╚═╩═╝╚═╝╚═╝╚═╩╝╠╗╠═╩╩═╩═╝╚══╩╩╩═╝╚╩╩═╩═╣╔╩═╩═╝
──────────────╚═╝───────────────────╚═╝─────────────────────╚╝
─────╔╗──╔══╗╔╗──╔═╦══╗
╔═╦═╦╝╠═╗║═╦╬╣╚╦╦╣║║══╣
║═╣╬║╬║╩╣║╔╣║║╔╣╔╣║╠══║
╚═╩═╩═╩═╝╚╝╚═╩═╩╝╚═╩══╝ Now in C#!
");
            }
        }
    }
}
