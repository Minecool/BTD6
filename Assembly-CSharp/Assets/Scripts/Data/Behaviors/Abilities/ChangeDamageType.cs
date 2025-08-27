namespace Assets.Scripts.Data.Behaviors.Abilities;

[CreateAssetMenu(fileName = "ChangeDamageType", menuName = "BTD6/Behaviors/Abilities/ChangeDamageType")]
public class ChangeDamageType : AbilityBehavior
{
	public float lifespan; //Field offset: 0x30
	public bool cantBeAbsorbed; //Field offset: 0x34
	public string damageType; //Field offset: 0x38

	public virtual AbilityBehaviorModel Def
	{
		 get { } //Length: 206
	}

	public ChangeDamageType() { }

	public virtual AbilityBehaviorModel get_Def() { }

}

