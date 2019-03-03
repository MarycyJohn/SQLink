﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Management.Automation;
using System.Management.Automation.Runspaces;
using System.IO;
using SQLink;
using System.Windows.Forms;

namespace RemotePowerShell
{
    public class PowerShellEngine : IDisposable
    {
        private Dictionary<string, Runspace> _runspaceCache = new Dictionary<string, Runspace>();

        ~PowerShellEngine()
        {
            Clean();
        }

        public Collection<PSObject> ExecuteScriptFile(string scriptFilePath, IEnumerable<object> arguments = null, string machineAddress = null)
        {
            return ExecuteScript(File.ReadAllText(scriptFilePath), arguments, machineAddress);
        }

        public Collection<PSObject> ExecuteScript(string script, IEnumerable<object> arguments = null, string machineAddress = null)
        {
            Runspace runspace = GetOrCreateRunspace(machineAddress);
            using (PowerShell ps = PowerShell.Create())
            {
                ps.Runspace = runspace;
                ps.AddScript(script);
                if (arguments != null)
                {
                    foreach (var argument in arguments)
                    {
                        ps.AddArgument(argument);
                    }
                }

                return ps.Invoke();
            }
        }

        public void Dispose()
        {
            Clean();
            GC.SuppressFinalize(this);
        }

        private Runspace GetOrCreateLocalRunspace()
        {
            if (!_runspaceCache.ContainsKey("localhost"))
            {
                Runspace runspace = RunspaceFactory.CreateRunspace();
                runspace.Open();
                _runspaceCache.Add("localhost", runspace);
            }

            return _runspaceCache["localhost"];
        }

        private Runspace GetOrCreateRunspace(string machineAddress)
        {
            if (string.IsNullOrWhiteSpace(machineAddress))
            {
                return GetOrCreateLocalRunspace();
            }

            machineAddress = machineAddress.ToLowerInvariant();
            if (!_runspaceCache.ContainsKey(machineAddress))
            {
                WSManConnectionInfo connectionInfo = new WSManConnectionInfo();
                connectionInfo.ComputerName = machineAddress;
                Runspace runspace = RunspaceFactory.CreateRunspace(connectionInfo);
                try
                {
                    runspace.Open();
                }
                catch (Exception asd123)
                {
                    MessageBox.Show(asd123.Message, "SQLink Info");
                    runspace.Close();
                };

                _runspaceCache.Add(machineAddress, runspace);
            }

            return _runspaceCache[machineAddress];
        }

        private void Clean()
        {
            foreach (var runspaceEntry in _runspaceCache)
            {
                runspaceEntry.Value.Close();
            }

            _runspaceCache.Clear();
        }
    }
}
