namespace Assets.Scripts.Data.Behaviors.Towers;

[CreateAssetMenu(fileName = "BeastHandlerLeash", menuName = "BTD6/Behaviors/Towers/BeastHandlerLeash")]
public class BeastHandlerLeash : TowerBehavior
{
	public Tower tower; //Field offset: 0x30
	public Attack spawnerAttack; //Field offset: 0x38
	public Tower secondTower; //Field offset: 0x40
	public Attack secondSpawnerAttack; //Field offset: 0x48
	public int moveAnimationState; //Field offset: 0x50
	public bool rotateToLeashedTower; //Field offset: 0x54
	public PrefabReference contributedToLineDisplay; //Field offset: 0x58
	public PrefabReference contributedFromLineDisplay; //Field offset: 0x60
	public float contributionDotOffset; //Field offset: 0x68
	public float contributionDotSpacing; //Field offset: 0x6C
	public float contributionDotSpeed; //Field offset: 0x70
	public PrefabReference buffedTextDisplay; //Field offset: 0x78
	public PrefabReference mergedTextDisplay; //Field offset: 0x80
	public PrefabReference powerTextDisplay; //Field offset: 0x88
	public PrefabReference validMergeTargetObject; //Field offset: 0x90
	public BeastHandlerPet piranhaPet; //Field offset: 0x98
	public BeastHandlerPet microraptorPet; //Field offset: 0xA0
	public BeastHandlerPet gyrfalconPet; //Field offset: 0xA8
	public Sound mergeSound; //Field offset: 0xB0

	public virtual TowerBehaviorModel Def
	{
		 get { } //Length: 1226
	}

	public BeastHandlerLeash() { }

	public virtual TowerBehaviorModel get_Def() { }

}

