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
 *                                                              Release 1.5
 *                                                              
 * https://github.com/APrettyCoolProgram/Tingen-DevDeploy
 * Copyright (c) A Pretty Cool Program. All rights reserved.
 * Licensed under the Apache 2.0 license.
 */

// u250519_code
// u250519_documentation

using System.IO.Compression;
using System.Net;

namespace TingenDevDeploy
{
    /// <summary>The main entry point for the application.</summary>
    internal static class Program
    {




        /// <summary>Refresh the UAT Tingen web service.</summary>
        /// <remarks>
        ///  <para>
        ///   - When the TingenUatRoslynPath is created, it will also create the:
        ///    - TingenUatServicePath
        ///    - TingenUatServicePath\bin
        ///  </para>
        /// </remarks>
        /// <param name="dateTimeStamp">The date/time when Tingen-DevDeploy was executed.</param>
        private static void RefreshServiceDirectory(string dateTimeStamp)
        {
            if (Directory.Exists(TingenUatServiceRoot))
            {
                StatusUpdate("Refreshing the UAT Tingen Web Service directory...", dateTimeStamp);
                Directory.Delete(TingenUatServiceRoot, true);
                Directory.CreateDirectory(TingenUatServiceRoslynPath);
                Directory.CreateDirectory(TingenUatServiceAppDataPath);
                Directory.CreateDirectory(TingenUatServiceAppDataRuntimePath);
            }
            else
            {
                Directory.CreateDirectory(TingenUatServiceRoslynPath);
            }
        }

        /// <summary>Copy the Tingen-Development bin files to the UAT Tingen web service directory.</summary>
        /// <param name="dateTimeStamp">The date/time when Tingen-DevDeploy was executed.</param>
        private static void CopyBinFiles(string dateTimeStamp)
        {
            StatusUpdate("Copying Tingen Web Service files to the UAT Tingen Web Service directory...", dateTimeStamp);

            CopyDirectory(TingenStagingBinPath, TingenUatServiceBinPath, dateTimeStamp);
        }

        /// <summary>Copy the Tingen-Development service files to the UAT Tingen web service directory.</summary>
        /// <param name="dateTimeStamp">The date/time when Tingen-DevDeploy was executed.</param>
        private static void CopyServiceFiles(string dateTimeStamp)
        {
            foreach (string serviceFile in GetServiceFiles())
            {
                StatusUpdate($"Copying {serviceFile}...", dateTimeStamp);
                File.Copy($@"{TingenStagingServiceRoot}\{serviceFile}", $@"{TingenUatServiceRoot}\{serviceFile}");
            }
        }

        /// <summary>Copy the source directory to the target directory.</summary>
        /// <param name="sourcePath">The source path to copy from.</param>
        /// <param name="targetPath">The target path to copy to.</param>
        /// <param name="dateTimeStamp">The date/time when Tingen-DevDeploy was executed.</param>


        /// <summary>Get the subdirectories of the source directory.</summary>
        /// <param name="sourcePath">The path to get the subdirectories of.</param>
        /// <returns>The subdirectories of the sourcePath.</returns>
 

        /// <summary>Write a status update to the console and log file.</summary>
        /// <param name="message">The status update to display/write.</param>
        /// <param name="dateTimeStamp">The date/time when Tingen-DevDeploy was executed.</param>
        private static void StatusUpdate(string message, string dateTimeStamp)
        {
            Console.WriteLine(message);
            File.AppendAllText($@"{LogRoot}\{dateTimeStamp}.devdeploy", $"{message}{Environment.NewLine}");
        }

        /// <summary>Creates a list of the required Tingen-DevDeploy directories.</summary>
        /// <remarks>
        ///  <para>
        ///   - There are actually four directories that are required for Tingen-DevDeploy, but the other two are
        ///   created when these two are.
        ///  </para>
        /// </remarks>
        /// <returns></returns>
        private static List<string> GetListOfDataDirectories() =>
        [
            LogRoot,
            StagingRoot
        ];

        /// <summary>Get the list of service files to copy to the UAT Tingen web service directory.</summary>
        /// <returns>A list of the required Tingen service files.</returns>
        private static List<string> GetServiceFiles()
        {
            return
            [
                "TingenWebService.asmx",
                "TingenWebService.asmx.cs",
                "packages.config",
                "Web.config",
                "Web.Debug.config",
                "Web.Release.config"
            ];
        }
    }
}