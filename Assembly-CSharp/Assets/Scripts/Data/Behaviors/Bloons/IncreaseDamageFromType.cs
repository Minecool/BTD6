namespace Assets.Scripts.Data.Behaviors.Bloons;

[CreateAssetMenu(fileName = "IncreaseDamageFromType", menuName = "BTD6/Behaviors/Bloons/IncreaseDamageFromType")]
public class IncreaseDamageFromType : BloonBehavior
{
	public string damageTypes; //Field offset: 0x30
	public float extraDamage; //Field offset: 0x38
	public bool useOriginalType; //Field offset: 0x3C

	public virtual BloonBehaviorModel Def
	{
		 get { } //Length: 201
	}

	public IncreaseDamageFromType() { }

	public virtual BloonBehaviorModel get_Def() { }

}

