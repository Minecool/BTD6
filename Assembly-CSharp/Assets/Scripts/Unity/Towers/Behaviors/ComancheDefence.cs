namespace Assets.Scripts.Unity.Towers.Behaviors;

public class ComancheDefence : TowerBehavior
{
	public Tower tower; //Field offset: 0x98
	public int reinforcementCount; //Field offset: 0xA0
	public string expReinforcementCount; //Field offset: 0xA8
	public float duration; //Field offset: 0xB0
	public string expDuration; //Field offset: 0xB8
	public float cooldown; //Field offset: 0xC0
	public string expCooldown; //Field offset: 0xC8
	public bool immediate; //Field offset: 0xD0
	public string expImmediate; //Field offset: 0xD8
	public AudioClip sound; //Field offset: 0xE0
	public AudioClip expSound; //Field offset: 0xE8
	public int maxActivationsPerRound; //Field offset: 0xF0
	public string expMaxActivationsPerRound; //Field offset: 0xF8

	public virtual TowerBehaviorModel Def
	{
		 get { } //Length: 517
	}

	public ComancheDefence() { }

	public virtual TowerBehaviorModel get_Def() { }

}

