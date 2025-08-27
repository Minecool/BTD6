namespace Assets.Scripts.Data.Behaviors.Bloons;

[CreateAssetMenu(fileName = "CarryProjectile", menuName = "BTD6/Behaviors/Bloons/CarryProjectile")]
public class CarryProjectile : BloonBehavior
{
	public Projectile projectile; //Field offset: 0x30
	public Emission emission; //Field offset: 0x38

	public virtual BloonBehaviorModel Def
	{
		 get { } //Length: 215
	}

	public CarryProjectile() { }

	public virtual BloonBehaviorModel get_Def() { }

}

