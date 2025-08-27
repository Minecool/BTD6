namespace Assets.Scripts.Data.Behaviors.Weapons;

[CreateAssetMenu(fileName = "SwapProjectile", menuName = "BTD6/Behaviors/Weapons/SwapProjectile")]
public class SwapProjectile : WeaponBehavior
{
	public Projectile projectileA; //Field offset: 0x30
	public Projectile projectileB; //Field offset: 0x38
	public int projectileAAnimation; //Field offset: 0x40
	public int projectileBAnimation; //Field offset: 0x44
	public bool emitBoth; //Field offset: 0x48
	public int emitBothAnimation; //Field offset: 0x4C
	public OffsetPosition throwMarkerForA; //Field offset: 0x50
	public OffsetPosition throwMarkerForB; //Field offset: 0x58
	public int swapToBAnimationState; //Field offset: 0x60
	public int swapToAAnimationState; //Field offset: 0x64
	public Sound swapProjASound1; //Field offset: 0x68
	public Sound swapProjASound2; //Field offset: 0x70
	public Sound swapProjBSound1; //Field offset: 0x78
	public Sound swapProjBSound2; //Field offset: 0x80
	public Sound projASound1; //Field offset: 0x88
	public Sound projASound2; //Field offset: 0x90
	public Sound projASound3; //Field offset: 0x98
	public Sound projASound4; //Field offset: 0xA0
	public Sound projBSound1; //Field offset: 0xA8
	public Sound projBSound2; //Field offset: 0xB0
	public Sound projBSound3; //Field offset: 0xB8
	public Sound projBSound4; //Field offset: 0xC0

	public virtual WeaponBehaviorModel Def
	{
		 get { } //Length: 1272
	}

	public SwapProjectile() { }

	public virtual WeaponBehaviorModel get_Def() { }

}

