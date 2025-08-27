namespace Assets.Scripts.Unity.Behaviors.Events.Actions;

public class GainLivesAction : EntityAction
{
	[SerializeField]
	public float amount; //Field offset: 0x18

	public virtual Model Model
	{
		 get { } //Length: 92
	}

	public virtual string Type
	{
		 get { } //Length: 44
	}

	public GainLivesAction() { }

	public virtual Model get_Model() { }

	public virtual string get_Type() { }

}

