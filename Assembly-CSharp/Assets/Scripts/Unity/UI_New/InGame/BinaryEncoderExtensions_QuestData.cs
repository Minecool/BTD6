namespace Assets.Scripts.Unity.UI_New.InGame;

[Extension]
public static class BinaryEncoderExtensions_QuestData
{

	[Extension]
	public static QuestGameData ReadQuestData(BinaryReader reader) { }

	[Extension]
	public static void Write(BinaryWriter writer, QuestGameData questData) { }

}

