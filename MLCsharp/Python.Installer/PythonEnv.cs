using System;
using System.Collections.Generic;
using System.Text;

namespace MLCsharp.Python.Installer
{
    public static class PythonEnv
    {
        /// <summary>
        /// Set PythonEnv.DeployEmbeddedPython to false to use system Python installation
        /// </summary>
        public static bool DeployEmbeddedPython { get; set; } = true;
    }
}
