namespace Assets.Scripts.Data.Behaviors.Events.Actions;

public class WinGameAction : EntityAction
{
	[SerializeField]
	public float amount; //Field offset: 0x28

	public virtual Model Model
	{
		 get { } //Length: 92
	}

	public WinGameAction() { }

	public virtual Model get_Model() { }

}

