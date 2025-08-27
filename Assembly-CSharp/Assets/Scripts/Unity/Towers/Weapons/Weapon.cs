namespace Assets.Scripts.Unity.Towers.Weapons;

public class Weapon : CascadingItemProxy
{
	public Weapon parent; //Field offset: 0x88
	public int animationState; //Field offset: 0x90
	[FormerlySerializedAs("expAnimation")]
	public string expAnimationState; //Field offset: 0x98
	public float animationOffset; //Field offset: 0xA0
	public string expAnimationOffset; //Field offset: 0xA8
	public float rate; //Field offset: 0xB0
	public string expRate; //Field offset: 0xB8
	public string fireWithoutTarget; //Field offset: 0xC0
	public string expFireWithoutTarget; //Field offset: 0xC8
	public string fireBetweenRounds; //Field offset: 0xD0
	public string expFireBetweenRounds; //Field offset: 0xD8
	public Emission emission; //Field offset: 0xE0
	public Emission expEmission; //Field offset: 0xE8
	public bool useAttackPosition; //Field offset: 0xF0
	public string expUseAttackPosition; //Field offset: 0xF8
	public bool startInCooldown; //Field offset: 0x100
	public string expStartInCooldown; //Field offset: 0x108
	public float customStartCooldown; //Field offset: 0x110
	public string expCustomStartCooldown; //Field offset: 0x118
	public bool animateOnMainAttack; //Field offset: 0x120
	public string expAnimateOnMainAttack; //Field offset: 0x128
	public GameObject throwMarker; //Field offset: 0x130

	public WeaponModel Def
	{
		 get { } //Length: 1567
	}

	public virtual Model Model
	{
		 get { } //Length: 7
	}

	public Weapon() { }

	public WeaponModel get_Def() { }

	public virtual Model get_Model() { }

}

