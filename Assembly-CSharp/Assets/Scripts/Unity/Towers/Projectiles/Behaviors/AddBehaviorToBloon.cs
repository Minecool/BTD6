namespace Assets.Scripts.Unity.Towers.Projectiles.Behaviors;

public class AddBehaviorToBloon : ProjectileBehavior
{
	public AddBehaviorToBloon parent; //Field offset: 0x88
	public float lifespan; //Field offset: 0x90
	public string expLifespan; //Field offset: 0x98
	public int layers; //Field offset: 0xA0
	public string expLayers; //Field offset: 0xA8
	public string mutationId; //Field offset: 0xB0
	public string expMutationId; //Field offset: 0xB8
	public BloonBehavior behavior; //Field offset: 0xC0
	public string overlayType; //Field offset: 0xC8
	public string expOverlayType; //Field offset: 0xD0
	public Filter bloonFilter; //Field offset: 0xD8
	public Filter expBloonFilter; //Field offset: 0xE0
	public GameObject bloonFilters; //Field offset: 0xE8
	public GameObject expBloonFilters; //Field offset: 0xF0
	public bool isUnique; //Field offset: 0xF8
	public string expIsUnique; //Field offset: 0x100
	public bool lastAppliesFirst; //Field offset: 0x108
	public string expLastAppliesFirst; //Field offset: 0x110
	public bool processThisFrame; //Field offset: 0x118
	public string expProcessThisFrame; //Field offset: 0x120
	public bool cascadeMutators; //Field offset: 0x128
	public string expCascadeMutators; //Field offset: 0x130
	public bool applyOnlyIfDamaged; //Field offset: 0x138
	public string expApplyOnlyIfDamaged; //Field offset: 0x140
	public int stackCount; //Field offset: 0x148
	public string expStackCount; //Field offset: 0x150
	public bool dontCopy; //Field offset: 0x158
	public string expDontCopy; //Field offset: 0x160
	public Damage parentDamageBehaviour; //Field offset: 0x168
	public float chance; //Field offset: 0x170
	public string expChance; //Field offset: 0x178
	public bool dontRemoveOnBloonDegrade; //Field offset: 0x180
	public string expDontRemoveOnBloonDegrade; //Field offset: 0x188

	public virtual ProjectileBehaviorModel Def
	{
		 get { } //Length: 1356
	}

	public AddBehaviorToBloon() { }

	public virtual ProjectileBehaviorModel get_Def() { }

}

