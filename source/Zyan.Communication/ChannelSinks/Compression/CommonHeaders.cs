/*
 THIS CODE IS BASED ON:
 -------------------------------------------------------------------------------------------------------------- 
 Remoting Compression Channel Sink

 November, 12, 2008 - Initial revision.
 Alexander Schmidt - http://www.alexschmidt.net

 Originally published at CodeProject:
 http://www.codeproject.com/KB/IP/remotingcompression.aspx

 Copyright � 2008 Alexander Schmidt. All Rights Reserved.
 Distributed under the terms of The Code Project Open License (CPOL).
 --------------------------------------------------------------------------------------------------------------
*/
namespace Zyan.Communication.ChannelSinks.Compression
{
	internal class CommonHeaders
	{
		/// <summary>Header to hold the compression state.</summary>
		public const string CompressionEnabled = "X-CY_COMPRESSION_ENABLED";

		/// <summary>Header to hold the compression supported flag.</summary>
		public const string CompressionSupported = "X-CY_COMPRESSION_SUPPORTED";

		/// <summary>Header to hold the compression method.</summary>
		public const string CompressionMethod = "X-CY_COMPRESSION_METHOD";
	}
}
