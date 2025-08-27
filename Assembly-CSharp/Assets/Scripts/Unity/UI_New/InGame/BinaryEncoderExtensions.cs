namespace Assets.Scripts.Unity.UI_New.InGame;

[Extension]
public static class BinaryEncoderExtensions
{

	[Extension]
	public static BossGameData ReadBossData(BinaryReader reader) { }

	[Extension]
	public static void Write(BinaryWriter writer, BossGameData bossData) { }

}

