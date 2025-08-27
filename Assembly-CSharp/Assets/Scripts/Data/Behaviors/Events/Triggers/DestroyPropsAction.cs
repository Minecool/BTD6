namespace Assets.Scripts.Data.Behaviors.Events.Triggers;

public class DestroyPropsAction : EntityAction
{
	[SerializeField]
	public float range; //Field offset: 0x28

	public virtual Model Model
	{
		 get { } //Length: 92
	}

	public DestroyPropsAction() { }

	public virtual Model get_Model() { }

}

