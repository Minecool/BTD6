namespace Assets.Scripts.Unity.Towers.Behaviors;

public class BeastHandlerLeash : TowerBehavior
{
	public BeastHandlerLeash parent; //Field offset: 0x98
	public Tower tower; //Field offset: 0xA0
	public Tower expTower; //Field offset: 0xA8
	public Attack spawnerAttack; //Field offset: 0xB0
	public Tower secondTower; //Field offset: 0xB8
	public Tower expSecondTower; //Field offset: 0xC0
	public Attack secondSpawnerAttack; //Field offset: 0xC8
	public int moveAnimationState; //Field offset: 0xD0
	public string expMoveAnimationState; //Field offset: 0xD8
	public bool rotateToLeashedTower; //Field offset: 0xE0
	public string expRotateToLeashedTower; //Field offset: 0xE8
	public GameObject contributedToLineDisplay; //Field offset: 0xF0
	public GameObject expContributedToLineDisplay; //Field offset: 0xF8
	public GameObject contributedFromLineDisplay; //Field offset: 0x100
	public GameObject expContributedFromLineDisplay; //Field offset: 0x108
	public float contributionDotOffset; //Field offset: 0x110
	public string expContributionDotOffset; //Field offset: 0x118
	public float contributionDotSpacing; //Field offset: 0x120
	public string expContributionDotSpacing; //Field offset: 0x128
	public float contributionDotSpeed; //Field offset: 0x130
	public string expContributionDotSpeed; //Field offset: 0x138
	public GameObject buffedTextDisplay; //Field offset: 0x140
	public GameObject expBuffedTextDisplay; //Field offset: 0x148
	public GameObject mergedTextDisplay; //Field offset: 0x150
	public GameObject expMergedTextDisplay; //Field offset: 0x158
	public GameObject powerTextDisplay; //Field offset: 0x160
	public GameObject expPowerTextDisplay; //Field offset: 0x168
	public GameObject validMergeTargetObject; //Field offset: 0x170
	public GameObject expValidMergeTargetObject; //Field offset: 0x178
	public BeastHandlerPet piranhaPet; //Field offset: 0x180
	public BeastHandlerPet microraptorPet; //Field offset: 0x188
	public BeastHandlerPet gyrfalconPet; //Field offset: 0x190
	public AudioClip mergeSound; //Field offset: 0x198
	public AudioClip expMergeSound; //Field offset: 0x1A0

	public virtual TowerBehaviorModel Def
	{
		 get { } //Length: 1541
	}

	public BeastHandlerLeash() { }

	public virtual TowerBehaviorModel get_Def() { }

}

