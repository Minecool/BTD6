namespace Assets.Scripts.Data.Knowledge;

[Extension]
public static class BinaryEncoderExtensions_ActiveRelicKnowledge
{

	[Extension]
	public static ulong BitMask(ContestedTerritoryRelicType type) { }

	[Extension]
	public static bool HasRelicType(ulong mask, ContestedTerritoryRelicType relicType) { }

	[Extension]
	public static ActiveRelicKnowledge ReadActiveRelicKnowledge(BinaryReader reader) { }

	[Extension]
	public static void Write(BinaryWriter writer, ActiveRelicKnowledge knowledge) { }

}

