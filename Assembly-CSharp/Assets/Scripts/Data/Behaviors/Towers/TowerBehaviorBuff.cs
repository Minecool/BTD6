namespace Assets.Scripts.Data.Behaviors.Towers;

public abstract class TowerBehaviorBuff : EntityBehavior<TowerBehaviorModel>
{
	public string buffLocsName; //Field offset: 0x28
	public string buffIconName; //Field offset: 0x30

	protected TowerBehaviorBuff() { }

}

