namespace Assets.Scripts.Models.Towers.Behaviors.Abilities.Behaviors;

[Implementation(typeof(VineRupture), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class VineRuptureModel : AbilityBehaviorModel
{
	public EffectModel effectModel; //Field offset: 0x30
	[SerializeField]
	private float interval; //Field offset: 0x38
	public int intervalFrames; //Field offset: 0x3C
	[ExtendedDrawer]
	public ProjectileModel projectileModel; //Field offset: 0x40
	[ExtendedDrawer]
	public ProjectileModel projectileModelHardThorns; //Field offset: 0x48
	public SingleEmissionModel emission; //Field offset: 0x50
	public SoundModel sound1; //Field offset: 0x58
	public SoundModel sound2; //Field offset: 0x60
	public SoundModel sound3; //Field offset: 0x68
	public SoundModel sound4; //Field offset: 0x70

	public VineRuptureModel(string name, EffectModel effectModel, float interval, ProjectileModel projectileModel, ProjectileModel projectileModelHardThorns, SoundModel sound1, SoundModel sound2, SoundModel sound3, SoundModel sound4) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

