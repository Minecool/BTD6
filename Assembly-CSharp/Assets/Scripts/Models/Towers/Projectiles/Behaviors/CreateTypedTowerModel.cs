namespace Assets.Scripts.Models.Towers.Projectiles.Behaviors;

[Implementation(typeof(CreateTypedTower), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class CreateTypedTowerModel : ProjectileBehaviorModel
{
	public TowerModel crushingTower; //Field offset: 0x38
	public TowerModel boomTower; //Field offset: 0x40
	public TowerModel coldTower; //Field offset: 0x48
	public TowerModel energyTower; //Field offset: 0x50
	public PrefabReference crushingDisplay; //Field offset: 0x58
	public PrefabReference boomDisplay; //Field offset: 0x60
	public PrefabReference coldDisplay; //Field offset: 0x68
	public PrefabReference energyDisplay; //Field offset: 0x70

	public CreateTypedTowerModel(string name, TowerModel crushingTower, TowerModel boomTower, TowerModel coldTower, TowerModel energyTower, PrefabReference crushingDisplay, PrefabReference boomDisplay, PrefabReference coldDisplay, PrefabReference energyDisplay) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

