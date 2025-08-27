namespace Assets.Scripts.Data.Behaviors.Events.Actions;

public class LoseLivesAction : EntityAction
{
	[SerializeField]
	public float amount; //Field offset: 0x28

	public virtual Model Model
	{
		 get { } //Length: 92
	}

	public LoseLivesAction() { }

	public virtual Model get_Model() { }

}

