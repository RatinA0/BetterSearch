﻿//using Sony.Vegas;
using ScriptPortal.Vegas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;
using System.Collections;

namespace BetterSearch
{
    public class DockControl : DockableControl
    {
        private MainForm mainForm = null;
        public DockControl() : base("IBetterSearch")
        {
            // name of the tab in Vegas
            DisplayName = "BetterSearch";
        }

        public override DockWindowStyle DefaultDockWindowStyle
        {
            get { return DockWindowStyle.Detached; }
        }

        public override Size DefaultFloatingSize
        {
            // TODO: change later
            get { return new Size(270, 250); }
        }

        // load Handler

        protected override void OnLoad(EventArgs e)
        {
            mainForm = new MainForm(myVegas)
            {
                Dock = DockStyle.Fill,
            };

            // add manual OnClosed invoke from MainForm
            //mainForm.Close += OnClosed;

            Controls.Add(mainForm);
        }

        //public void OnClosed(object sender, EventArgs args)
        //{
        //    OnClosed(args);
        //}

        // close Handler
        protected override void OnClosed(EventArgs args)
        {
            // remove manual invoke
            //mainForm.Close -= OnClosed;

            base.OnClosed(args);
        }
    }
}

/// <summary>
/// Handle user click under the selected CommandCategory menu
/// </summary>
public class CustomCommandModule : ICustomCommandModule
{
    public Vegas myVegas = null;
    // name of the tab in Vegas under the VIEW category
    CustomCommand CCM = new CustomCommand(CommandCategory.View, "BetterSearch");

    public void InitializeModule(Vegas vegas)
    {
        myVegas = vegas;
        CCM.MenuItemName = "BetterSearch";
    }

    public ICollection GetCustomCommands()
    {
        // handle MenuPopup and Invoke of the CustomCommand
        CCM.MenuPopup += HandleMenuPopup;
        CCM.Invoked += HandleInvoked;
        CustomCommand[] cmds = new CustomCommand[] { CCM };
        return cmds;
    }

    private void HandleMenuPopup(object sender, EventArgs e)
    {
        // find and see if the extension is docked or not
        CCM.Checked = myVegas.FindDockView("IBetterSearch");
    }

    private void HandleInvoked(object sender, EventArgs e)
    {
        // if it isn't docked yet
        if (!myVegas.ActivateDockView("IBetterSearch"))
        {
            // create the new DockControl
            BetterSearch.DockControl Dock = new BetterSearch.DockControl
            {
                AutoLoadCommand = CCM,
                // keeps it open all the time + reload on Vegas reload
                PersistDockWindowState = true
            };
            myVegas.LoadDockView(Dock);
        }
    }
}