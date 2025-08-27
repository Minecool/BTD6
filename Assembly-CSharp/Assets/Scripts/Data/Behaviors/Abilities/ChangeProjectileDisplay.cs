namespace Assets.Scripts.Data.Behaviors.Abilities;

[CreateAssetMenu(fileName = "ChangeProjectileDisplay", menuName = "BTD6/Behaviors/Abilities/ChangeProjectileDisplay")]
public class ChangeProjectileDisplay : AbilityBehavior
{
	public float lifespan; //Field offset: 0x30
	public AssetPath display; //Field offset: 0x38
	public Projectile projectile; //Field offset: 0x40
	public string mutatorId; //Field offset: 0x48

	public virtual AbilityBehaviorModel Def
	{
		 get { } //Length: 231
	}

	public ChangeProjectileDisplay() { }

	public virtual AbilityBehaviorModel get_Def() { }

}

