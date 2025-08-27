namespace NinjaKiwi.LiNK.Lobbies;

public class ReceivedMessage : IDisposable
{
	public readonly byte FromPlayer; //Field offset: 0x10
	public readonly BinaryReader Content; //Field offset: 0x18

	public ReceivedMessage(byte fromPlayer, BinaryReader content) { }

	public override void Dispose() { }

}

