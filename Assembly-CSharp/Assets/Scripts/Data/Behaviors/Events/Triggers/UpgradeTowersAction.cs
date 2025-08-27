namespace Assets.Scripts.Data.Behaviors.Events.Triggers;

public class UpgradeTowersAction : EntityAction
{
	[SerializeField]
	public int amount; //Field offset: 0x28
	[SerializeField]
	public float range; //Field offset: 0x2C
	[SerializeField]
	public string towerId; //Field offset: 0x30
	[SerializeField]
	public int path; //Field offset: 0x38

	public virtual Model Model
	{
		 get { } //Length: 149
	}

	public UpgradeTowersAction() { }

	public virtual Model get_Model() { }

}

