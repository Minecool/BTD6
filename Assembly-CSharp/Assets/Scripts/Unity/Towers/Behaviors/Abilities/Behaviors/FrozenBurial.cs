namespace Assets.Scripts.Unity.Towers.Behaviors.Abilities.Behaviors;

public class FrozenBurial : AbilityBehavior
{
	public FrozenBurial parent; //Field offset: 0x88
	public int icewallSpacing; //Field offset: 0x90
	public string expIcewallSpacing; //Field offset: 0x98
	public int icewallStartDelay; //Field offset: 0xA0
	public string expIcewallStartDelay; //Field offset: 0xA8
	public int timePerIcewall; //Field offset: 0xB0
	public string expTimePerIcewall; //Field offset: 0xB8
	public Projectile icewallProjectile; //Field offset: 0xC0
	public Projectile expIcewallProjectile; //Field offset: 0xC8
	public Emission emission; //Field offset: 0xD0
	public Emission expEmission; //Field offset: 0xD8

	public virtual AbilityBehaviorModel Def
	{
		 get { } //Length: 281
	}

	public FrozenBurial() { }

	public virtual AbilityBehaviorModel get_Def() { }

}

