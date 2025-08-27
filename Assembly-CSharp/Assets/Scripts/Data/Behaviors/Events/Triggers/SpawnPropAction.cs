namespace Assets.Scripts.Data.Behaviors.Events.Triggers;

public class SpawnPropAction : EntityAction
{
	[SerializeField]
	public Prop prop; //Field offset: 0x28

	public virtual Model Model
	{
		 get { } //Length: 192
	}

	public SpawnPropAction() { }

	public virtual Model get_Model() { }

}

