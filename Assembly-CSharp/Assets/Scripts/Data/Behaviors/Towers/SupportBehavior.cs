namespace Assets.Scripts.Data.Behaviors.Towers;

public abstract class SupportBehavior : EntityBehavior<TowerBehaviorModel>
{
	public string buffLocsName; //Field offset: 0x28
	public string buffIconName; //Field offset: 0x30
	public bool onlyAffectParagon; //Field offset: 0x38
	public TowerFilter[] towerFilters; //Field offset: 0x40

	protected SupportBehavior() { }

	public TowerFilterModel[] GatherFilters() { }

}

