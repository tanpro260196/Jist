﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TShockAPI;

namespace Wolfje.Plugins.Jist.Extensions {

    public static class TShockCommandExtensions {

        /// <summary>
        /// Invokes a command ignoring permissions
        /// </summary>
		public static bool RunWithoutPermissions(this TShockAPI.Command cmd, string msg, TShockAPI.TSPlayer ply, List<string> parms, bool silent = false) {
            try {
                TShockAPI.CommandDelegate cmdDelegateRef = cmd.CommandDelegate;

                cmdDelegateRef(new TShockAPI.CommandArgs(msg, silent, ply, parms));
            } catch (Exception e) {
                ply.SendErrorMessage("Command failed, check logs for more details.");
                TShock.Log.Error(e.ToString());
            }

            return true;
        }

    }
}
