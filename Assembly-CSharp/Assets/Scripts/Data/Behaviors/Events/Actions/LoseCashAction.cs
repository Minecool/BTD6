namespace Assets.Scripts.Data.Behaviors.Events.Actions;

public class LoseCashAction : EntityAction
{
	[SerializeField]
	public float amount; //Field offset: 0x28

	public virtual Model Model
	{
		 get { } //Length: 92
	}

	public LoseCashAction() { }

	public virtual Model get_Model() { }

}

