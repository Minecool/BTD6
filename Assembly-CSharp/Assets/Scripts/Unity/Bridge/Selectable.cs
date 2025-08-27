namespace Assets.Scripts.Unity.Bridge;

public abstract class Selectable
{

	public abstract ObjectId id
	{
		 get { } //Length: 0
	}

	protected Selectable() { }

	public abstract ObjectId get_id() { }

}

