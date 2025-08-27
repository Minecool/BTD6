namespace Assets.Scripts.Unity.Behaviors.Events.Triggers;

public class OnTowerUpgradeUnlockedTrigger : EntityTrigger
{
	[TowerType]
	public String[] towerIds; //Field offset: 0x18
	public int path; //Field offset: 0x20

	public virtual Model Model
	{
		 get { } //Length: 112
	}

	public virtual string Type
	{
		 get { } //Length: 44
	}

	public OnTowerUpgradeUnlockedTrigger() { }

	public virtual Model get_Model() { }

	public virtual string get_Type() { }

}

