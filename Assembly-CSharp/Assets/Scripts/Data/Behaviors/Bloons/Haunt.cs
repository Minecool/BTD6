namespace Assets.Scripts.Data.Behaviors.Bloons;

[CreateAssetMenu(fileName = "Haunt", menuName = "BTD6/Behaviors/Bloons/Haunt")]
public class Haunt : BloonBehavior
{
	public float bonusEnergyDamage; //Field offset: 0x30
	public int manaPerRbe; //Field offset: 0x34
	public Projectile projectileOnDestroy; //Field offset: 0x38
	public Effect effectOnDestroy; //Field offset: 0x40

	public virtual BloonBehaviorModel Def
	{
		 get { } //Length: 244
	}

	public Haunt() { }

	public virtual BloonBehaviorModel get_Def() { }

}

