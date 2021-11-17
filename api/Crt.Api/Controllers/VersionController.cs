﻿using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System.Reflection;
using System.Runtime.Versioning;
using Crt.Model;
using Crt.Api.Controllers.Base;
using Crt.Model.Utils;
using System.Threading.Tasks;
using System;

namespace Crt.Api.Controllers
{
    [ApiVersion("1.0")]
    [Route("api/version")]
    [ApiController]
    public class VersionController : CrtControllerBase
    {
        private const string CommitKey = "OPENSHIFT_BUILD_COMMIT";

        private IConfiguration _config;
        private IWebHostEnvironment _env;
        
        public VersionController(CrtCurrentUser currentUser, IConfiguration config, IWebHostEnvironment env)
                : base(currentUser)
        {
            _config = config;
            _env = env;
        }

        [HttpGet]
        public ActionResult<VersionInfo> GetVersionInfo()
        {
            var assembly = Assembly.GetExecutingAssembly();

            var creationTime = System.IO.File.GetLastWriteTimeUtc(assembly.Location);

            var versionInfo = new VersionInfo()
            {
                Name = assembly.GetName().Name,
                Version = _config.GetSection("Constants:Version").Value,
                Description = assembly.GetCustomAttribute<AssemblyDescriptionAttribute>().Description,
                Copyright = assembly.GetCustomAttribute<AssemblyCopyrightAttribute>().Copyright,
                FileVersion = assembly.GetCustomAttribute<AssemblyFileVersionAttribute>().Version,
                FileCreationTime = creationTime.ToString("O"),
                InformationalVersion = assembly.GetCustomAttribute<AssemblyInformationalVersionAttribute>().InformationalVersion,
                TargetFramework = assembly.GetCustomAttribute<TargetFrameworkAttribute>().FrameworkName,
                ImageRuntimeVersion = assembly.ImageRuntimeVersion,
                Commit = _config[CommitKey],
                Environment = _config.GetEnvironment()
            };

            return Ok(versionInfo);
        }
    }
}