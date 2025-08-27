namespace Assets.Scripts.Models.Difficulty;

[Extension]
public static class ModeType
{
	public const string Standard = "Standard"; //Field offset: 0x0
	public static readonly String[] allModes; //Field offset: 0x0
	public const string GameEditor = "GameEditor"; //Field offset: 0x0
	public const string MapEditor = "MapEditor"; //Field offset: 0x0
	public const string Sandbox = "Sandbox"; //Field offset: 0x0
	public const string CHIMPS = "Clicks"; //Field offset: 0x0
	public const string Impoppable = "Impoppable"; //Field offset: 0x0
	public const string DoubleMoabHealth = "DoubleMoabHealth"; //Field offset: 0x0
	public const string AlternateBloonsRounds = "AlternateBloonsRounds"; //Field offset: 0x0
	public const string MagicOnly = "MagicOnly"; //Field offset: 0x0
	public const string Reverse = "Reverse"; //Field offset: 0x0
	public const string Apopalypse = "Apopalypse"; //Field offset: 0x0
	public const string MilitaryOnly = "MilitaryOnly"; //Field offset: 0x0
	public const string Deflation = "Deflation"; //Field offset: 0x0
	public const string PrimaryOnly = "PrimaryOnly"; //Field offset: 0x0
	public const string HalfCash = "HalfCash"; //Field offset: 0x0
	public static readonly String[] easyModes; //Field offset: 0x8
	public static readonly String[] mediumModes; //Field offset: 0x10
	public static readonly String[] hardModes; //Field offset: 0x18

	private static ModeType() { }

	public static String[] GetModesForDifficulty(string difficulty) { }

	public static string GetRegularDifficultyForMode(string mode) { }

	[Extension]
	public static bool IsEditorMode(string gameMode) { }

}

