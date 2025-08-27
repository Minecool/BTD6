namespace Assets.Scripts.Unity.SimulationBehaviors;

public class AnniversaryChallengeQuest : SimulationBehavior
{
	public string targetBloonName; //Field offset: 0x18
	public float badHealthMutliplier; //Field offset: 0x20
	public float badSpeedMutliplier; //Field offset: 0x24
	public float badScaleMutliplier; //Field offset: 0x28
	public int numAllowedLeaks; //Field offset: 0x2C
	public int numRoundsBeforeSpawningTarget; //Field offset: 0x30

	public virtual Model Model
	{
		 get { } //Length: 189
	}

	public virtual string Type
	{
		 get { } //Length: 44
	}

	public AnniversaryChallengeQuest() { }

	public virtual Model get_Model() { }

	public virtual string get_Type() { }

}

