namespace NinjaKiwi.LiNK.Endpoints;

public class SetPlaySessionResponse
{
	internal class OtherSession
	{
		public string sessionID; //Field offset: 0x10
		public int expiresIn; //Field offset: 0x18

		public OtherSession() { }

	}

	public bool success; //Field offset: 0x10
	public OtherSession otherSession; //Field offset: 0x18

	public SetPlaySessionResponse() { }

}

