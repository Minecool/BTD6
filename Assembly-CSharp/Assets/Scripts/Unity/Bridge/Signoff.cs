namespace Assets.Scripts.Unity.Bridge;

public class Signoff : IBtd6MessageType
{
	public int currentStep; //Field offset: 0x10
	public int signoffStep; //Field offset: 0x14

	public Signoff(int currentStep, int signoffStep) { }

	public static Signoff Decode(BinaryReader reader) { }

	public static void Encode(BinaryWriter writer, Signoff signoff) { }

}

