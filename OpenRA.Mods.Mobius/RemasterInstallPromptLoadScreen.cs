#region Copyright & License Information
/*
 * Copyright 2007-2021 The OpenRA Developers (see AUTHORS)
 * This file is part of OpenRA, which is free software. It is made
 * available to you under the terms of the GNU General Public License
 * as published by the Free Software Foundation, either version 3 of
 * the License, or (at your option) any later version. For more
 * information, see COPYING.
 */
#endregion

using OpenRA.Mods.Cnc;
using OpenRA.Widgets;

namespace OpenRA.Mods.Mobius
{
	public sealed class RemasterInstallPromptLoadScreen : CncLoadScreen
	{
		public override void StartGame(Arguments args)
		{
			Ui.OpenWindow("PROMPT_CONTAINER", new WidgetArgs());
		}
	}
}
