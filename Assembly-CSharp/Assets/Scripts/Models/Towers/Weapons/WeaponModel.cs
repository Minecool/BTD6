namespace Assets.Scripts.Models.Towers.Weapons;

[Implementation(typeof(Weapon), True, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class WeaponModel : Model
{
	public int animation; //Field offset: 0x30
	[SerializeField]
	private float animationOffset; //Field offset: 0x34
	public int animationOffsetFrames; //Field offset: 0x38
	public EmissionModel emission; //Field offset: 0x40
	public float ejectX; //Field offset: 0x48
	public float ejectY; //Field offset: 0x4C
	public float ejectZ; //Field offset: 0x50
	public ProjectileModel projectile; //Field offset: 0x58
	public bool fireWithoutTarget; //Field offset: 0x60
	public bool fireBetweenRounds; //Field offset: 0x61
	public Model[] behaviors; //Field offset: 0x68
	[SerializeField]
	private float rate; //Field offset: 0x70
	public int rateFrames; //Field offset: 0x74
	public bool useAttackPosition; //Field offset: 0x78
	public bool startInCooldown; //Field offset: 0x79
	[SerializeField]
	private float customStartCooldown; //Field offset: 0x7C
	public int customStartCooldownFrames; //Field offset: 0x80
	public bool animateOnMainAttack; //Field offset: 0x84
	public bool isStunned; //Field offset: 0x85

	public float Rate
	{
		 get { } //Length: 6
		 set { } //Length: 21
	}

	public bool UseThrowMarker
	{
		 get { } //Length: 45
	}

	public WeaponModel(string name = null, int animation = 1, float rate = 1, ProjectileModel projectile = null, float ejectX = 0, float ejectY = 0, float ejectZ = 0, float animationOffset = 0.2, bool fireWithoutTarget = false, bool fireBetweenRounds = false, EmissionModel emission = null, Model[] behaviors = null, bool useAttackPosition = false, bool startInCooldown = false, float customStartCooldown = 0, bool animateOnMainAttack = false, bool isStunned = false) { }

	public virtual Model[] BehaviorModels() { }

	public virtual Model Clone() { }

	public float get_Rate() { }

	public bool get_UseThrowMarker() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

	public void set_Rate(float value) { }

	public virtual void SetBehaviorModels(Model[] behaviors) { }

}

