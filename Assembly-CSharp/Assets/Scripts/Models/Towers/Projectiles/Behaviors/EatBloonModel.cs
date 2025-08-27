namespace Assets.Scripts.Models.Towers.Projectiles.Behaviors;

[Implementation(typeof(EatBloon), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class EatBloonModel : ProjectileBehaviorModel
{
	public float rbeCapacity; //Field offset: 0x38
	public float rbeCashMultiplier; //Field offset: 0x3C
	public ProjectileModel projectile; //Field offset: 0x40
	public EmissionModel emission; //Field offset: 0x48
	public int animationStateOpen; //Field offset: 0x50
	public int animationStateClosed; //Field offset: 0x54
	[SerializeField]
	private float timeUntilClose; //Field offset: 0x58
	public int timeUntilCloseFrames; //Field offset: 0x5C
	public EffectModel effectOnEatModel; //Field offset: 0x60
	public SoundModel bloonTrapOpenSound; //Field offset: 0x68
	public SoundModel bloonTrapCloseSound; //Field offset: 0x70

	public EatBloonModel(string name, float rbeCapacity, float rbeCashMultiplier, ProjectileModel projectile, EmissionModel emission, int animationStateOpen, int animationStateClosed, float timeUntilClose, EffectModel effectOnEatModel, SoundModel bloonTrapOpenSound, SoundModel bloonTrapCloseSound) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

