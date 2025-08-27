namespace NinjaKiwi.LiNK.DataModels;

public class OnlineModel
{
	public bool isOnline; //Field offset: 0x10
	public string playSession; //Field offset: 0x18
	public TimeSpan expiresIn; //Field offset: 0x20

	public OnlineModel() { }

}

