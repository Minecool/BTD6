namespace Assets.Scripts.Data.Knowledge;

[Extension]
public static class BinaryEncoderExtensions_ActiveKnowledge
{

	[Extension]
	public static ActiveKnowledge ReadActiveKnowledge(BinaryReader reader) { }

	[Extension]
	public static void Write(BinaryWriter writer, ActiveKnowledge knowledge) { }

}

