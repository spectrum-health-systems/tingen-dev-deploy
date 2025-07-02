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
 *                                 A deployment utility for Tingen projects
 *                                                                   v2.3.0
 *
 * https://github.com/spectrum-health-systems/tingen-dev-deploy
 * Copyright (c) A Pretty Cool Program. All rights reserved.
 * Licensed under the Apache 2.0 license.
 */

/* u250703_code
 * u250703_documentation
 */

using TingenLieutenant.DevDeploy;

namespace TingenDevDeploy
{
    /// <summary>The main class for Tingen DevDeploy.</summary>
    /// <remarks>
    ///     This class doesn't do much, it just calls the <c>DeploymentProcess</c> method<br/>
    ///     from the <c>TingenLieutenant.WebService.Deploy</c> namespace.
    /// </remarks>
    internal class Program
    {
        /// <summary>The main entry point for Tingen DevDeploy.</summary>
        /// <remarks>
        ///     The configuration file path is hard coded to "<c>./AppData/devdeploy-conf.json</c>".<br/>
        ///     <br/>
        ///     Since this is a console application, we will pass <c>useCli</c> as <c>true</c>.
        /// </remarks>
        public static void Main(string[] args)
        {
            Console.Clear();

            var arg = string.Empty;

            /* This is a quick and dirty way to handle the archiving functionality. Future versions
             * will have a more robust way to handle multiple arguments.
             */
            if (args.Length >= 1)
            {
                arg = args[0];
            }
            else
            {
                arg = "none";
            }

            DeployWsvc.DeploymentProcess("./AppData/devdeploy-conf.json", arg, true);
        }
    }
}