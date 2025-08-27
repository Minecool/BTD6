namespace Assets.Scripts.Models.Towers.Behaviors.Abilities.Behaviors;

[Implementation(typeof(FrozenBurial), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class FrozenBurialModel : AbilityBehaviorModel
{
	public int icewallSpacing; //Field offset: 0x30
	public int icewallDelay; //Field offset: 0x34
	public int timePerIcewall; //Field offset: 0x38
	public ProjectileModel icewallProjectile; //Field offset: 0x40
	public EmissionModel emission; //Field offset: 0x48

	public FrozenBurialModel(string name, int icewallSpacing, int icewallDelay, int timePerIcewall, ProjectileModel projectile, EmissionModel emission) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

