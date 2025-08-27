namespace Assets.Scripts.Data.Behaviors.Abilities;

[CreateAssetMenu(fileName = "FrozenCascade", menuName = "BTD6/Behaviors/Abilities/FrozenCascade")]
public class FrozenCascade : AbilityBehavior
{
	public string towerId; //Field offset: 0x30
	public int maxExplosions; //Field offset: 0x38
	public float timeScale; //Field offset: 0x3C
	public Emission emission; //Field offset: 0x40
	public Projectile projectile; //Field offset: 0x48

	public virtual AbilityBehaviorModel Def
	{
		 get { } //Length: 240
	}

	public FrozenCascade() { }

	public virtual AbilityBehaviorModel get_Def() { }

}

