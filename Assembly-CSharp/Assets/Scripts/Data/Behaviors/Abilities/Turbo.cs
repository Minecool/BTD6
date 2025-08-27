namespace Assets.Scripts.Data.Behaviors.Abilities;

[CreateAssetMenu(fileName = "Turbo", menuName = "BTD6/Behaviors/Abilities/Turbo")]
public class Turbo : AbilityBehavior
{
	public float lifespan; //Field offset: 0x30
	public float multiplier; //Field offset: 0x34
	public AssetPath projectileDisplay; //Field offset: 0x38
	public int extraDamage; //Field offset: 0x40
	public float projectileRadiusScaleBonus; //Field offset: 0x44
	public bool dontRemoveMutatorOnDestroy; //Field offset: 0x48

	public virtual AbilityBehaviorModel Def
	{
		 get { } //Length: 274
	}

	public Turbo() { }

	public virtual AbilityBehaviorModel get_Def() { }

}

