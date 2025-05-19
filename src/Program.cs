/*
 * ████████╗██╗███╗   ██╗ ██████╗ ███████╗███╗   ██╗
 * ╚══██╔══╝██║████╗  ██║██╔════╝ ██╔════╝████╗  ██║
 *    ██║   ██║██╔██╗ ██║██║  ███╗█████╗  ██╔██╗ ██║
 *    ██║   ██║██║╚██╗██║██║   ██║██╔══╝  ██║╚██╗██║
 *    ██║   ██║██║ ╚████║╚██████╔╝███████╗██║ ╚████║
 *    ╚═╝   ╚═╝╚═╝  ╚═══╝ ╚═════╝ ╚══════╝╚═╝  ╚═══╝
 *
 * ██████╗ ███████╗██╗   ██╗██████╗ ███████╗██████╗ ██╗      ██████╗ ██╗   ██╗
 * ██╔══██╗██╔════╝██║   ██║██╔══██╗██╔════╝██╔══██╗██║     ██╔═══██╗╚██╗ ██╔╝
 * ██║  ██║█████╗  ██║   ██║██║  ██║█████╗  ██████╔╝██║     ██║   ██║ ╚████╔╝
 * ██║  ██║██╔══╝  ╚██╗ ██╔╝██║  ██║██╔══╝  ██╔═══╝ ██║     ██║   ██║  ╚██╔╝
 * ██████╔╝███████╗ ╚████╔╝ ██████╔╝███████╗██║     ███████╗╚██████╔╝   ██║
 * ╚═════╝ ╚══════╝  ╚═══╝  ╚═════╝ ╚══════╝╚═╝     ╚══════╝ ╚═════╝    ╚═╝
 *                                A deployment utility for Tingen projects.
 *                                                                     v2.0
 *
 * https://github.com/APrettyCoolProgram/Tingen-DevDeploy
 * Copyright (c) A Pretty Cool Program. All rights reserved.
 * Licensed under the Apache 2.0 license.
 */

// u250519_code
// u250519_documentation

using TingenLieutenant;

namespace TingenDevDeploy
{
    internal class Program
    {
        /// <summary>Entry point for Tingen-DevDeploy.</summary>
        /// <remarks>
        ///     <para>
        ///         Tingen-DevDeploy accepts two command-line arguments:
        ///         <list type="bullet">
        ///             <item>The "<c>command</c>" tells DevDeploy what needs to be done</item>
        ///             <item>The (optional) "<c>environment</c>" tells DevDeploy what environment will be used</item>
        ///         </list>
        ///         The command line syntax is as follows:
        ///         <code>
        ///             TingenDevDeploy &lt;command&gt; &lt;environment&gt;
        ///         </code>
        ///         <example>
        ///             For example, to setup/reset the local environment to deploy the Tingen Web Service:
        ///             <code>
        ///                 TingenDevDeploy &lt;reset&gt; &lt;local&gt;
        ///             </code>
        ///         </example>
        ///     </para>
        /// </remarks>
        /// <param name="args">The command-line arguments.</param>
        public static void Main(string[] args)
        {
            Console.Clear();

            ValidateArgsLength(args);

            Deployer.ValidateConfigFile("./AppData/devdeploy.conf", true);

            string command     = GetValidCommand(args[0]);
            string environment = "use_config_value";

            if (args.Length == 2)
            {
                environment = GetValidEnvironment(args[1]);
            }
    
            ParseArguments(command, environment);
        }

        private static void ValidateArgsLength(string[] args)
        {
            switch (args.Length)
            {
                case <1:
                    Console.WriteLine("Usage: TingenDevDeploy <command> [<environment>]");
                    Environment.Exit(1);
                    break;

                case >2:
                    Console.WriteLine("Error: Too many arguments provided.");
                    Environment.Exit(1);
                    break;
            }
        }
        private static string GetValidCommand(string commandArg)
        {
            List<string> validCommands = BuildList("command");

            if (!validCommands.Contains(commandArg.ToLower()))
            {
                Console.WriteLine($"Invalid command '{commandArg}'. Valid commands are: {string.Join(", ", validCommands)}.");
                Environment.Exit(1);

                return "Invalid command";
            }
            else
            {
                return commandArg.ToLower();
            }
        }

        private static string GetValidEnvironment(string environmentArg)
        {
            List<string> validEnvironments = BuildList("environment");

            if (!validEnvironments.Contains(environmentArg.ToLower()))
            {
                Console.WriteLine($"Invalid environment '{environmentArg}'. Valid environments are: {string.Join(", ", validEnvironments)}.");
                Environment.Exit(1);

                return "Invalid environment";
            }
            else
            {
                return environmentArg.ToLower();
            }
        }

        private static void ParseArguments(string command, string environment)
        {
            if (command == "reset")
            {
                Deployer.ResetEnvironment(environment, true);
            }
            else if (command == "deploy")
            {
                //DeployEnvironment(env);
            }
            else
            {
                Console.WriteLine("Invalid command. Use 'reset' or 'deploy'.");
                Environment.Exit(1);
            }
        }

        private static List<string> BuildList(string type)
        {
            return type switch
            {
                "command" => new List<string>
                {
                    "deploy",
                    "reset"
                },
                "environment" => new List<string>
                {
                    "local",
                    "remote"
                },
                _ => []
            };
        }




    }
}
