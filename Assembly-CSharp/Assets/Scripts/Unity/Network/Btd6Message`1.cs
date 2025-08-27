namespace Assets.Scripts.Unity.Network;

public class Btd6Message : Writable, Writable, IBtd6Message
{
	private readonly MessageCode code; //Field offset: 0x0
	public readonly T content; //Field offset: 0x0

	public override MessageCode Code
	{
		 get { } //Length: 94
	}

	public Btd6Message`1(MessageCode code, T content) { }

	public Btd6Message`1(MessageCode code, ReceivedMessage received) { }

	public override MessageCode get_Code() { }

	public override void WriteTo(BinaryWriter output) { }

}

