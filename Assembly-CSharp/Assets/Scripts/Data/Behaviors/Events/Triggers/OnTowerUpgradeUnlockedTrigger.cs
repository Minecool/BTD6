namespace Assets.Scripts.Data.Behaviors.Events.Triggers;

public class OnTowerUpgradeUnlockedTrigger : EntityTrigger
{
	[TowerType]
	public String[] towerIds; //Field offset: 0x28
	public int path; //Field offset: 0x30

	public virtual Model Model
	{
		 get { } //Length: 112
	}

	public OnTowerUpgradeUnlockedTrigger() { }

	public virtual Model get_Model() { }

}

