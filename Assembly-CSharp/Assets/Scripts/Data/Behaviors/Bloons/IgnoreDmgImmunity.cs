namespace Assets.Scripts.Data.Behaviors.Bloons;

[CreateAssetMenu(fileName = "IgnoreDmgImmunity", menuName = "BTD6/Behaviors/Bloons/IgnoreDmgImmunity")]
public class IgnoreDmgImmunity : BloonBehavior
{
	public string damageType; //Field offset: 0x30
	public float chance; //Field offset: 0x38

	public virtual BloonBehaviorModel Def
	{
		 get { } //Length: 177
	}

	public IgnoreDmgImmunity() { }

	public virtual BloonBehaviorModel get_Def() { }

}

