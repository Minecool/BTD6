namespace NinjaKiwi.LiNK.Transfer;

internal sealed class NullSession : Session
{

	public virtual bool Exists
	{
		 get { } //Length: 3
	}

	public NullSession() { }

	public virtual bool get_Exists() { }

}

