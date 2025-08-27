namespace Assets.Scripts.Unity.Towers.Weapons;

public abstract class WeaponBehavior : CascadingItemProxy
{
	[CompilerGenerated]
	private readonly WeaponBehaviorModel <Def>k__BackingField; //Field offset: 0x88

	public override WeaponBehaviorModel Def
	{
		[CompilerGenerated]
		 get { } //Length: 8
	}

	public virtual Model Model
	{
		 get { } //Length: 20
	}

	protected WeaponBehavior() { }

	[CompilerGenerated]
	public override WeaponBehaviorModel get_Def() { }

	public virtual Model get_Model() { }

}

