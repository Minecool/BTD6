namespace Assets.Scripts.Unity.Behaviors.Events.Triggers;

public class OnTowerTargetTypeChangedTrigger : EntityTrigger
{
	[TowerType]
	public String[] towerIds; //Field offset: 0x18
	public TargetType targetType; //Field offset: 0x20

	public virtual Model Model
	{
		 get { } //Length: 143
	}

	public virtual string Type
	{
		 get { } //Length: 44
	}

	public OnTowerTargetTypeChangedTrigger() { }

	public virtual Model get_Model() { }

	public virtual string get_Type() { }

}

