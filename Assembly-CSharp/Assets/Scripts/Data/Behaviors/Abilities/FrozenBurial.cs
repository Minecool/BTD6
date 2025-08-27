namespace Assets.Scripts.Data.Behaviors.Abilities;

[CreateAssetMenu(fileName = "FrozenBurial", menuName = "BTD6/Behaviors/Abilities/FrozenBurial")]
public class FrozenBurial : AbilityBehavior
{
	public string towerIds; //Field offset: 0x30
	public int icewallSpacing; //Field offset: 0x38
	public int icewallDelay; //Field offset: 0x3C
	public int timePerIcewall; //Field offset: 0x40
	public Projectile icewallProjectile; //Field offset: 0x48
	public Emission emission; //Field offset: 0x50

	public virtual AbilityBehaviorModel Def
	{
		 get { } //Length: 236
	}

	public FrozenBurial() { }

	public virtual AbilityBehaviorModel get_Def() { }

}

