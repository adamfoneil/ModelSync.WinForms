﻿using JsonSettings;
using JsonSettings.Library;
using ModelSync.App.Controls;
using ModelSync.App.Models;
using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using WinForms.Library.Models;

namespace ModelSync.App
{
    public partial class frmMain : Form
    {
        private Settings _settings;
        private Solution _solution;
        private string _solutionFile;

        public string[] StartupArgs { get; set; }       

        public frmMain()
        {
            InitializeComponent();
        }
        
        public string SolutionFile
        {
            get { return _solutionFile; }
            set 
            { 
                _solutionFile = value;
                Text = $"ModelSync - {Path.GetFileName(_solutionFile)}";
            }
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            try
            {
                _settings = SettingsBase.Load<Settings>();
                _settings.Position?.Apply(this);

                _solution = (LoadSolutionOnStartup(out string fileName)) ?
                    JsonFile.Load<Solution>(fileName) :
                    Solution.Create();

                _solutionFile = fileName;

                LoadSolution(_solution);
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private bool LoadSolutionOnStartup(out string fileName)
        {
            if (StartupArgs?.Length > 0)
            {
                string baseFile = Path.GetFileNameWithoutExtension(StartupArgs[0]);

                fileName = Path.Combine(
                    Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData),
                    "ModelSync", baseFile + ".json");

                return File.Exists(fileName);
            }

            fileName = null;
            return false;
        }

        private void LoadSolution(Solution solution)
        {
            // todo: save current solution

            SuspendLayout();

            try
            {                
                if (solution?.Merges.Any() ?? false)
                {
                    int index = 0;
                    foreach (var merge in _solution.Merges)
                    {
                        var tab = new TabPage(merge.Title ?? $"merge {index}");
                        var ui = new SyncUI() { Dock = DockStyle.Fill, Document = merge };
                        tab.Controls.Add(ui);
                        tabMain.TabPages.Insert(index, tab);
                        index++;
                    }
                    tabMain.SelectedIndex = 0;
                }
            }
            finally
            {
                ResumeLayout();
            }            
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                _settings.Position = FormPosition.FromForm(this);
                _settings.Save();

                if (_solution != null)
                {
                    JsonFile.Save(SolutionFile, _solution);
                }                
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void tabMain_SelectedIndexChanged(object sender, EventArgs e)
        {
            int lastIndex = tabMain.TabPages.Count - 1;
            if (tabMain.SelectedIndex == lastIndex)
            {
                var tab = new TabPage($"merge {tabMain.TabPages.Count}");
                var ui = new SyncUI() { Dock = DockStyle.Fill };
                tab.Controls.Add(ui);
                tabMain.TabPages.Insert(lastIndex, tab);
                tabMain.SelectedIndex = lastIndex;
            }
        }
    }
}
