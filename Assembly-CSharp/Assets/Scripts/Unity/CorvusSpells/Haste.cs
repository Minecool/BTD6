namespace Assets.Scripts.Unity.CorvusSpells;

public class Haste : CorvusInstantSpell
{
	private HasteModel def; //Field offset: 0x158
	public float orbitSpeedMultiplier; //Field offset: 0x160
	public string expOrbitSpeedMultiplier; //Field offset: 0x168
	public float turnSpeedMultiplier; //Field offset: 0x170
	public string expTurnSpeedMultiplier; //Field offset: 0x178

	public virtual TowerBehaviorModel Def
	{
		 get { } //Length: 751
	}

	public Haste() { }

	public virtual TowerBehaviorModel get_Def() { }

}

