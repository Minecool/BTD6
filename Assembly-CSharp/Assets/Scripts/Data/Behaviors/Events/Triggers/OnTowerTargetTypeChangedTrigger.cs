namespace Assets.Scripts.Data.Behaviors.Events.Triggers;

public class OnTowerTargetTypeChangedTrigger : EntityTrigger
{
	[TowerType]
	public String[] towerIds; //Field offset: 0x28
	public TargetType targetType; //Field offset: 0x30

	public virtual Model Model
	{
		 get { } //Length: 143
	}

	public OnTowerTargetTypeChangedTrigger() { }

	public virtual Model get_Model() { }

}

