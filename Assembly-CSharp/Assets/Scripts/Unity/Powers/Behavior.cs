namespace Assets.Scripts.Unity.Powers;

public class Behavior : CascadingItem
{

	public override PowerDetailsModel Def
	{
		 get { } //Length: 3
	}

	public virtual Model Model
	{
		 get { } //Length: 20
	}

	public Behavior() { }

	public override PowerDetailsModel get_Def() { }

	public virtual Model get_Model() { }

}

