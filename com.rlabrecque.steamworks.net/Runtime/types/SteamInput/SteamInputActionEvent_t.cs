// This file is provided under The MIT License as part of Steamworks.NET.
// Copyright (c) 2013-2021 Riley Labrecque
// Please see the included LICENSE.txt for additional information.

// This file is automatically generated.
// Changes to this file will be reverted when you update Steamworks.NET

#if !(UNITY_STANDALONE_WIN || UNITY_STANDALONE_LINUX || UNITY_STANDALONE_OSX || STEAMWORKS_WIN || STEAMWORKS_LIN_OSX)
	#define DISABLESTEAMWORKS
#endif

#if !DISABLESTEAMWORKS

using System.Runtime.InteropServices;
using IntPtr = System.IntPtr;

namespace Steamworks
{
	//-----------------------------------------------------------------------------
	// Purpose: when callbacks are enabled this fires each time a controller action
	// state changes
	//-----------------------------------------------------------------------------
	[System.Serializable]
	[StructLayout(LayoutKind.Sequential)]
	public struct SteamInputActionEvent_t
	{
		public InputHandle_t controllerHandle;

		public ESteamInputActionEventType eEventType;

		/// Option value
		public OptionValue m_val;

		[System.Serializable]
		[StructLayout(LayoutKind.Sequential)]
		public struct AnalogAction_t
		{
				public InputAnalogActionHandle_t actionHandle;

				public InputAnalogActionData_t analogActionData;
		}

		[System.Serializable]
		[StructLayout(LayoutKind.Sequential)]
		public struct DigitalAction_t
		{
				public InputDigitalActionHandle_t actionHandle;

				public InputDigitalActionData_t digitalActionData;
		}

		[System.Serializable]
		[StructLayout(LayoutKind.Explicit)]
		public struct OptionValue
		{
			[FieldOffset(0)]
			public AnalogAction_t analogAction;

			[FieldOffset(0)]
			public DigitalAction_t digitalAction;
		}
	}
}

#endif // !DISABLESTEAMWORKS