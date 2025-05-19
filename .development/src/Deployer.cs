/*
 * ████████╗██╗███╗   ██╗ ██████╗ ███████╗███╗   ██╗
 *    ██║   ██║██╔██╗ ██║██║  ███╗█████╗  ██╔██╗ ██║
 *    ██║   ██║██║ ╚████║╚██████╔╝███████╗██║ ╚████║
 *    ╚═╝   ╚═╝╚═╝  ╚═══╝ ╚═════╝ ╚══════╝╚═╝  ╚═══╝
 *
 * ██████╗ ███████╗██╗   ██╗██████╗ ███████╗██████╗ ██╗      ██████╗ ██╗   ██╗╝
 * ██║  ██║█████╗  ██║   ██║██║  ██║█████╗  ██████╔╝██║     ██║   ██║ ╚████╔╝  
 * ██████╔╝███████╗ ╚████╔╝ ██████╔╝███████╗██║     ███████╗╚██████╔╝   ██║   
 * ╚═════╝ ╚══════╝  ╚═══╝  ╚═════╝ ╚══════╝╚═╝     ╚══════╝ ╚═════╝    ╚═╝                                                                      
 *                                              TingenDevDeploy.Deployer.cs
 *                                                              
 * https://github.com/APrettyCoolProgram/Tingen-DevDeploy
 * Copyright (c) A Pretty Cool Program. All rights reserved.
 * Licensed under the Apache 2.0 license.
 */


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TingenDevDeploy
{
    internal class Deployer
    {
        public string LogRoot { get; set; }
        public string StagingRoot { get; set; }
        public string ZipUrl { get; set; }
        public string ZipDownloadPath { get; set; }
        public string TingenUatServiceRoot { get; set; }
        public string TingenUatServiceRoslynPath { get; set; }
        public string TingenUatServiceAppDataPath { get; set; }
        public string TingenUatServiceAppDataRuntimePath { get; set; }
        public string TingenStagingBinPath { get; set; }
        public string TingenUatServiceBinPath { get; set; }
        public string TingenStagingServiceRoot { get; set; }






    }
}

/*

        private const string LogRoot                            = @"C:\Tingen_Data\DevDeploy\Logs";
        private const string StagingRoot                        = @"C:\Tingen_Data\DevDeploy\Staging";
        private const string ZipUrl                             = "https://github.com/spectrum-health-systems/Tingen-WebService/archive/refs/heads/development.zip";
        private const string ZipDownloadPath                    = @"C:\Tingen_Data\DevDeploy\Staging\Tingen-WebService.zip";
        private const string TingenUatServiceRoot               = @"C:\Tingen\UAT";
        private const string TingenUatServiceRoslynPath         = @"C:\Tingen\UAT\bin\roslyn";
        private const string TingenUatServiceAppDataPath        = @"C:\Tingen\UAT\bin\AppData";
        private const string TingenUatServiceAppDataRuntimePath = @"C:\Tingen\UAT\bin\AppData\Runtime";
        private const string TingenStagingBinPath               = @"C:\Tingen_Data\DevDeploy\Staging\Tingen-WebService-development\src\bin";
        private const string TingenUatServiceBinPath            = @"C:\Tingen\UAT\bin";
        private const string TingenStagingServiceRoot           = @"C:\Tingen_Data\DevDeploy\Staging\Tingen-WebService-development\src";

*/