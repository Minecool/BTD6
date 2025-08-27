namespace Assets.Scripts.Unity.Behaviors.Events.Actions;

public class SpawnPropAction : EntityAction
{
	[SerializeField]
	public Prop prop; //Field offset: 0x18

	public virtual Model Model
	{
		 get { } //Length: 180
	}

	public virtual string Type
	{
		 get { } //Length: 44
	}

	public SpawnPropAction() { }

	public virtual Model get_Model() { }

	public virtual string get_Type() { }

}

