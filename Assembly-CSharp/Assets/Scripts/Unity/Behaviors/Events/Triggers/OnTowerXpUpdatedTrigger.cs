namespace Assets.Scripts.Unity.Behaviors.Events.Triggers;

public class OnTowerXpUpdatedTrigger : EntityTrigger
{
	[TowerType]
	public String[] towerIds; //Field offset: 0x18

	public virtual Model Model
	{
		 get { } //Length: 90
	}

	public virtual string Type
	{
		 get { } //Length: 44
	}

	public OnTowerXpUpdatedTrigger() { }

	public virtual Model get_Model() { }

	public virtual string get_Type() { }

}

