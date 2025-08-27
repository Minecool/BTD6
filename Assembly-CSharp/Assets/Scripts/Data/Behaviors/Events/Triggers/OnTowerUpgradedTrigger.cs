namespace Assets.Scripts.Data.Behaviors.Events.Triggers;

public class OnTowerUpgradedTrigger : EntityTrigger
{
	[SerializeField]
	public String[] towerIds; //Field offset: 0x28
	[SerializeField]
	public int selectedPath; //Field offset: 0x30
	[SerializeField]
	public int tier; //Field offset: 0x34
	[SerializeField]
	public bool includeTiersAbove; //Field offset: 0x38

	public virtual Model Model
	{
		 get { } //Length: 149
	}

	public OnTowerUpgradedTrigger() { }

	public virtual Model get_Model() { }

}

