namespace Assets.Scripts.Models.Towers.Weapons.Behaviors;

[Implementation(typeof(SwapProjectile), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class SwapProjectileModel : WeaponBehaviorModel
{
	public ProjectileModel projectileModelA; //Field offset: 0x30
	public ProjectileModel projectileModelB; //Field offset: 0x38
	public int projectileAAnimation; //Field offset: 0x40
	public int projectileBAnimation; //Field offset: 0x44
	public bool emitBoth; //Field offset: 0x48
	public int emitBothAnimation; //Field offset: 0x4C
	public float ejectXForA; //Field offset: 0x50
	public float ejectYForA; //Field offset: 0x54
	public float ejectZForA; //Field offset: 0x58
	public float ejectXForB; //Field offset: 0x5C
	public float ejectYForB; //Field offset: 0x60
	public float ejectZForB; //Field offset: 0x64
	public int swapToBAnimationState; //Field offset: 0x68
	public int swapToAAnimationState; //Field offset: 0x6C
	public SoundModel swapProjASound1; //Field offset: 0x70
	public SoundModel swapProjASound2; //Field offset: 0x78
	public SoundModel swapProjBSound1; //Field offset: 0x80
	public SoundModel swapProjBSound2; //Field offset: 0x88
	public SoundModel projASound1; //Field offset: 0x90
	public SoundModel projASound2; //Field offset: 0x98
	public SoundModel projASound3; //Field offset: 0xA0
	public SoundModel projASound4; //Field offset: 0xA8
	public SoundModel projBSound1; //Field offset: 0xB0
	public SoundModel projBSound2; //Field offset: 0xB8
	public SoundModel projBSound3; //Field offset: 0xC0
	public SoundModel projBSound4; //Field offset: 0xC8

	public SwapProjectileModel(string name, ProjectileModel projectileModelA, ProjectileModel projectileModelB, int projectileAAnimation, int projectileBAnimation, bool emitBoth, int emitBothAnimation, float ejectXForA, float ejectYForA, float ejectZForA, float ejectXForB, float ejectYForB, float ejectZForB, int swapToBAnimationState, int swapToAAnimationState, SoundModel swapProjASound1, SoundModel swapProjASound2, SoundModel swapProjBSound1, SoundModel swapProjBSound2, SoundModel projASound1, SoundModel projASound2, SoundModel projASound3, SoundModel projASound4, SoundModel projBSound1, SoundModel projBSound2, SoundModel projBSound3, SoundModel projBSound4) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

