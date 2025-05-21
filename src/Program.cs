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
 *                                                                   v2.0.0
 *
 * https://github.com/APrettyCoolProgram/Tingen-DevDeploy
 * Copyright (c) A Pretty Cool Program. All rights reserved.
 * Licensed under the Apache 2.0 license.
 */

// u250521_code
// u250521_documentation

using TingenLieutenant.WebServiceDeployer;

namespace TingenDevDeploy
{
    /// <summary>The main class for Tingen-DevDeploy.</summary>
    internal class Program
    {
        /// <summary>The main entry point for Tingen-DevDeploy.</summary>
        public static void Main()
        {
            Console.Clear();

            ViaDevDeploy.DeployEnvironment("./AppData/devdeploy-conf.json");
        }
    }
}