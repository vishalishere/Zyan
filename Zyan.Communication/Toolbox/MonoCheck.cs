﻿using System;

namespace Zyan.Communication.Toolbox
{
	/// <summary>
	/// Tool to test for Mono runtime environment.
	/// </summary>
	internal static class MonoCheck
	{
		static Lazy<bool> _runningOnMono = new Lazy<bool>(() => Type.GetType("Mono.Runtime") != null, true);

		/// <summary>
		/// Returns true if Zyan is running on Mono.
		/// </summary>
		public static bool IsRunningOnMono
		{
			get { return _runningOnMono.Value; }
		}
	}
}
