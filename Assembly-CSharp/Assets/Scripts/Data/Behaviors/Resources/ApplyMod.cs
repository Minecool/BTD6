namespace Assets.Scripts.Data.Behaviors.Resources;

public abstract class ApplyMod : Behavior<ApplyModModel>
{

	public virtual Model Model
	{
		 get { } //Length: 20
	}

	protected ApplyMod() { }

	public virtual Model get_Model() { }

}

