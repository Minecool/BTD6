namespace Assets.Scripts.Unity.Behaviors.Events.Triggers;

public class OnTowerUpgradedTrigger : EntityTrigger
{
	[SerializeField]
	public String[] towerIds; //Field offset: 0x18
	[SerializeField]
	public int selectedPath; //Field offset: 0x20
	[SerializeField]
	public int tier; //Field offset: 0x24
	[SerializeField]
	public bool includeTiersAbove; //Field offset: 0x28

	public virtual Model Model
	{
		 get { } //Length: 149
	}

	public virtual string Type
	{
		 get { } //Length: 44
	}

	public OnTowerUpgradedTrigger() { }

	public virtual Model get_Model() { }

	public virtual string get_Type() { }

}

