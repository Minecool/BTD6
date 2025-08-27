namespace SteamNative;

internal struct CSteamID
{
	public ulong Value; //Field offset: 0x0

	public static CSteamID op_Implicit(ulong value) { }

	public static ulong op_Implicit(CSteamID value) { }

}

