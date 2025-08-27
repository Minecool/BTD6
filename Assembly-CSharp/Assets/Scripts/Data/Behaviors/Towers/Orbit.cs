namespace Assets.Scripts.Data.Behaviors.Towers;

[CreateAssetMenu(fileName = "Orbit", menuName = "BTD6/Behaviors/Towers/Orbit")]
public class Orbit : TowerBehavior
{
	public int count; //Field offset: 0x30
	public float range; //Field offset: 0x34
	public Projectile projectile; //Field offset: 0x38

	public virtual TowerBehaviorModel Def
	{
		 get { } //Length: 180
	}

	public Orbit() { }

	public virtual TowerBehaviorModel get_Def() { }

}

