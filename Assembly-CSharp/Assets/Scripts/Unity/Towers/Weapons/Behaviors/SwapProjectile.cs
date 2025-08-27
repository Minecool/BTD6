namespace Assets.Scripts.Unity.Towers.Weapons.Behaviors;

public class SwapProjectile : WeaponBehavior
{
	public SwapProjectile parent; //Field offset: 0x90
	public Projectile projectileA; //Field offset: 0x98
	public Projectile expProjectileA; //Field offset: 0xA0
	public Projectile projectileB; //Field offset: 0xA8
	public Projectile expProjectileB; //Field offset: 0xB0
	public int projectileAAnimation; //Field offset: 0xB8
	public string expProjectileAAnimation; //Field offset: 0xC0
	public int projectileBAnimation; //Field offset: 0xC8
	public string expProjectileBAnimation; //Field offset: 0xD0
	public bool emitBoth; //Field offset: 0xD8
	public string expEmitBoth; //Field offset: 0xE0
	public int emitBothAnimation; //Field offset: 0xE8
	public string expEmitBothAnimation; //Field offset: 0xF0
	public GameObject throwMarkerForA; //Field offset: 0xF8
	public GameObject expThrowMarkerForA; //Field offset: 0x100
	public GameObject throwMarkerForB; //Field offset: 0x108
	public GameObject expThrowMarkerForB; //Field offset: 0x110
	public int swapToBAnimationState; //Field offset: 0x118
	public string expSwapToBAnimationState; //Field offset: 0x120
	public int swapToAAnimationState; //Field offset: 0x128
	public string expSwapToAAnimationState; //Field offset: 0x130
	public AudioClip swapProjASound1; //Field offset: 0x138
	public AudioClip expSwapProjASound1; //Field offset: 0x140
	public AudioClip swapProjASound2; //Field offset: 0x148
	public AudioClip expSwapProjASound2; //Field offset: 0x150
	public AudioClip swapProjBSound1; //Field offset: 0x158
	public AudioClip expSwapProjBSound1; //Field offset: 0x160
	public AudioClip swapProjBSound2; //Field offset: 0x168
	public AudioClip expSwapProjBSound2; //Field offset: 0x170
	public AudioClip projASound1; //Field offset: 0x178
	public AudioClip expProjASound1; //Field offset: 0x180
	public AudioClip projASound2; //Field offset: 0x188
	public AudioClip expProjASound2; //Field offset: 0x190
	public AudioClip projASound3; //Field offset: 0x198
	public AudioClip expProjASound3; //Field offset: 0x1A0
	public AudioClip projASound4; //Field offset: 0x1A8
	public AudioClip expProjASound4; //Field offset: 0x1B0
	public AudioClip projBSound1; //Field offset: 0x1B8
	public AudioClip expProjBSound1; //Field offset: 0x1C0
	public AudioClip projBSound2; //Field offset: 0x1C8
	public AudioClip expProjBSound2; //Field offset: 0x1D0
	public AudioClip projBSound3; //Field offset: 0x1D8
	public AudioClip expProjBSound3; //Field offset: 0x1E0
	public AudioClip projBSound4; //Field offset: 0x1E8
	public AudioClip expProjBSound4; //Field offset: 0x1F0

	public virtual WeaponBehaviorModel Def
	{
		 get { } //Length: 3299
	}

	public SwapProjectile() { }

	public virtual WeaponBehaviorModel get_Def() { }

}

