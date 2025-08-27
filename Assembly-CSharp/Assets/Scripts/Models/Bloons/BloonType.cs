namespace Assets.Scripts.Models.Bloons;

public static class BloonType
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass33_0
	{
		public string bloonType; //Field offset: 0x10

		public <>c__DisplayClass33_0() { }

		internal bool <IsValid>b__0(string t) { }

	}

	public const string sRed = "Red"; //Field offset: 0x0
	public const string sRegrow = "Regrow"; //Field offset: 0x0
	public static readonly String[] baseTypes; //Field offset: 0x0
	public const string sBad = "Bad"; //Field offset: 0x0
	public const string sDdt = "Ddt"; //Field offset: 0x0
	public const string sZomg = "Zomg"; //Field offset: 0x0
	public const string sBfb = "Bfb"; //Field offset: 0x0
	public const string sMoab = "Moab"; //Field offset: 0x0
	public const string sRainbow = "Rainbow"; //Field offset: 0x0
	public const string sFortified = "Fortified"; //Field offset: 0x0
	public const string sCeramic = "Ceramic"; //Field offset: 0x0
	public const string sZebra = "Zebra"; //Field offset: 0x0
	public const string sPurple = "Purple"; //Field offset: 0x0
	public const string sWhite = "White"; //Field offset: 0x0
	public const string sBlack = "Black"; //Field offset: 0x0
	public const string sPink = "Pink"; //Field offset: 0x0
	public const string sYellow = "Yellow"; //Field offset: 0x0
	public const string sGreen = "Green"; //Field offset: 0x0
	public const string sBlue = "Blue"; //Field offset: 0x0
	public const string sLead = "Lead"; //Field offset: 0x0
	public const string sCamo = "Camo"; //Field offset: 0x0

	private static BloonType() { }

	public static string BaseType(string bloonType) { }

	public static bool CanBeCamo(string bloonType) { }

	public static bool CanBeFortified(string bloonType) { }

	public static bool CanBeRegrow(string bloonType) { }

	public static string Construct(string baseType, bool camo, bool regrow, bool fortified) { }

	public static bool IsCamo(string bloonType) { }

	public static bool IsCeramic(string bloonType) { }

	public static bool IsDdt(string bloonType) { }

	public static bool IsFortified(string bloonType) { }

	public static bool IsLead(string bloonType) { }

	public static bool IsMoab(string bloonType) { }

	public static bool IsRegrow(string bloonType) { }

	public static bool IsValid(string bloonType) { }

}

