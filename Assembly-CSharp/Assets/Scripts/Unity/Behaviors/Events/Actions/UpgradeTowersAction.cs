namespace Assets.Scripts.Unity.Behaviors.Events.Actions;

public class UpgradeTowersAction : EntityAction
{
	[SerializeField]
	public int amount; //Field offset: 0x18
	[SerializeField]
	public float range; //Field offset: 0x1C
	[SerializeField]
	public string towerId; //Field offset: 0x20
	[SerializeField]
	public int path; //Field offset: 0x28

	public virtual Model Model
	{
		 get { } //Length: 149
	}

	public virtual string Type
	{
		 get { } //Length: 44
	}

	public UpgradeTowersAction() { }

	public virtual Model get_Model() { }

	public virtual string get_Type() { }

}

