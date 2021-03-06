using System;
using Core.Portable;
using Core.Shell.Common.Commands;

namespace Core.Shell.Platform.Commands
{
	public sealed class WindowsExecutableSubsystem : RegularExecutableSubsystem
	{
		protected override bool IsValidExecutable (string fullPath)
		{
			return fullPath.EndsWith (".exe", StringComparison.OrdinalIgnoreCase);
		}
	}

}

