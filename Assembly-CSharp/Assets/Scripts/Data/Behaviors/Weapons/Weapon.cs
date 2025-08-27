namespace Assets.Scripts.Data.Behaviors.Weapons;

[CreateAssetMenu(fileName = "Weapon", menuName = "BTD6/Behaviors/Weapon Asset", order = 1)]
public class Weapon : EntityBehavior<WeaponModel>
{
	[JsonConverter(typeof(BehaviorConverter))]
	public Emission emission; //Field offset: 0x28
	[JsonConverter(typeof(BehaviorConverter))]
	public WeaponBehavior[] behaviors; //Field offset: 0x30
	[JsonConverter(typeof(BehaviorConverter))]
	public Projectile projectile; //Field offset: 0x38
	[JsonConverter(typeof(BehaviorConverter))]
	public OffsetPosition throwMarker; //Field offset: 0x40
	public float rate; //Field offset: 0x48
	public int animationState; //Field offset: 0x4C
	public float animationOffset; //Field offset: 0x50
	public bool fireWithoutTarget; //Field offset: 0x54
	public bool fireBetweenRounds; //Field offset: 0x55
	public bool useAttackPosition; //Field offset: 0x56
	public bool startInCooldown; //Field offset: 0x57
	public float customStartCooldown; //Field offset: 0x58
	public bool animateOnMainAttack; //Field offset: 0x5C
	public bool useThrowMarker; //Field offset: 0x5D

	[JsonIgnore]
	public virtual WeaponModel Def
	{
		 get { } //Length: 611
	}

	public Weapon() { }

	public virtual WeaponModel get_Def() { }

}

