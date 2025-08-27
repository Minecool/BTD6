namespace Assets.Scripts.Data.Behaviors.Towers;

[CreateAssetMenu(fileName = "Submerge", menuName = "BTD6/Behaviors/Towers/Submerge")]
public class Submerge : TowerBehaviorBuff
{
	public Attack submergeAttack; //Field offset: 0x38
	public float abilitySpeedScale; //Field offset: 0x40
	public float globalAbilitySpeedScale; //Field offset: 0x44
	public float heroXpScale; //Field offset: 0x48
	public PrefabReference attackDisplay; //Field offset: 0x50
	public float submergeDepth; //Field offset: 0x58
	public float submergeSpeed; //Field offset: 0x5C
	public Sound submergeSound; //Field offset: 0x60
	public Sound emergeSound; //Field offset: 0x68
	public int supportMutatorPriority; //Field offset: 0x70
	public MonkeySubParagonSupport paragonSupport; //Field offset: 0x78
	public float abilitySpeedScaleParagon; //Field offset: 0x80
	public int animateOnSubmerge; //Field offset: 0x84
	public int animateOnExitSubmerge; //Field offset: 0x88
	public Effect submergeEffect; //Field offset: 0x90
	public Effect unsubmergeEffect; //Field offset: 0x98

	public virtual TowerBehaviorModel Def
	{
		 get { } //Length: 914
	}

	public Submerge() { }

	public virtual TowerBehaviorModel get_Def() { }

}

