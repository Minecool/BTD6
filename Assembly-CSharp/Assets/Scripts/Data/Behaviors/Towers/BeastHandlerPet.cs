namespace Assets.Scripts.Data.Behaviors.Towers;

[CreateAssetMenu(fileName = "BeastHandlerPet", menuName = "BTD6/Behaviors/Towers/BeastHandlerPet")]
public class BeastHandlerPet : TowerBehavior
{
	public int tier; //Field offset: 0x30
	public int path; //Field offset: 0x34
	public int requiredCount; //Field offset: 0x38
	public bool canMove; //Field offset: 0x3C
	public bool rotateWhenMoved; //Field offset: 0x3D
	public int basePower; //Field offset: 0x40
	public int maxPower; //Field offset: 0x44
	public bool enableContribution; //Field offset: 0x48
	public float cooldownScaleRange; //Field offset: 0x4C
	public int pierceRange; //Field offset: 0x50
	public int damageRange; //Field offset: 0x54
	public float destroyTimeScaleRangePiranha; //Field offset: 0x58
	public float thrashKnockbackLifetimeRange; //Field offset: 0x5C
	public float stunBonusDivideMicroraptor; //Field offset: 0x60
	public int damageRangeGrappleGyrfalcon; //Field offset: 0x64
	public float speedRangeGyrfalcon; //Field offset: 0x68
	public SpriteReference genericIcon; //Field offset: 0x70
	public BeastHandlerPetDisplayStep[] displaySteps; //Field offset: 0x78

	public virtual TowerBehaviorModel Def
	{
		 get { } //Length: 538
	}

	public BeastHandlerPet() { }

	public virtual TowerBehaviorModel get_Def() { }

}

