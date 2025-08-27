namespace Assets.Scripts.Unity.CorvusSpells.PassiveBonuses;

public class Attunement : TowerBehavior
{
	private AttunementModel def; //Field offset: 0x98
	public float maxSpeedMultiplier; //Field offset: 0xA0
	public string expMaxSpeedMultiplier; //Field offset: 0xA8
	public float maxDamageMultiplier; //Field offset: 0xB0
	public string expMaxDamageMultiplier; //Field offset: 0xB8

	public virtual TowerBehaviorModel Def
	{
		 get { } //Length: 179
	}

	public Attunement() { }

	public virtual TowerBehaviorModel get_Def() { }

}

