namespace Assets.Scripts.Models.Towers.Behaviors.Abilities.Behaviors;

[Implementation(typeof(Eruption), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class EruptionModel : AbilityBehaviorModel
{
	public float projectileLifespanMult; //Field offset: 0x30
	public PrefabReference display; //Field offset: 0x38
	public AssetPathModel projectileToSwapDisplay; //Field offset: 0x40
	public AssetPathModel projectileDisplay; //Field offset: 0x48
	public AssetPathModel subProjectileToSwapDisplay; //Field offset: 0x50
	public AssetPathModel subProjectileDisplay; //Field offset: 0x58

	public EruptionModel(string name, float projectileLifespanMult, PrefabReference display, AssetPathModel projectileToSwapDisplay, AssetPathModel projectileDisplay, AssetPathModel subProjectileToSwapDisplay, AssetPathModel subProjectileDisplay) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

