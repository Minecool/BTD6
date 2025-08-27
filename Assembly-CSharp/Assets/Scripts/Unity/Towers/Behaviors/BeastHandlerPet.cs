namespace Assets.Scripts.Unity.Towers.Behaviors;

public class BeastHandlerPet : TowerBehavior
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<BeastHandlerPetDisplayStep, Single> <>9__36_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal float <get_Def>b__36_0(BeastHandlerPetDisplayStep step) { }

	}

	public BeastHandlerPet parent; //Field offset: 0x98
	public int tier; //Field offset: 0xA0
	public string expTier; //Field offset: 0xA8
	public int path; //Field offset: 0xB0
	public string expPath; //Field offset: 0xB8
	public int requiredCount; //Field offset: 0xC0
	public string expRequiredCount; //Field offset: 0xC8
	public bool canMove; //Field offset: 0xD0
	public string expCanMove; //Field offset: 0xD8
	public bool rotateWhenMoved; //Field offset: 0xE0
	public string expRotateWhenMoved; //Field offset: 0xE8
	public int basePower; //Field offset: 0xF0
	public string expBasePower; //Field offset: 0xF8
	public int maxPower; //Field offset: 0x100
	public string expMaxPower; //Field offset: 0x108
	public bool enableContribution; //Field offset: 0x110
	public string expEnableContribution; //Field offset: 0x118
	public float cooldownScaleRange; //Field offset: 0x120
	public string expCooldownScaleRange; //Field offset: 0x128
	public int pierceRange; //Field offset: 0x130
	public string expPierceRange; //Field offset: 0x138
	public int damageRange; //Field offset: 0x140
	public string expDamageRange; //Field offset: 0x148
	public float destroyTimeScaleRangePiranha; //Field offset: 0x150
	public string expDestroyTimeScaleRangePiranha; //Field offset: 0x158
	public float thrashKnockbackLifetimeRange; //Field offset: 0x160
	public string expThrashKnockbackLifetimeRange; //Field offset: 0x168
	public float stunBonusDivideMicroraptor; //Field offset: 0x170
	public string expStunBonusDivideMicroraptor; //Field offset: 0x178
	public int damageRangeGrappleGyrfalcon; //Field offset: 0x180
	public string expDamageRangeGrappleGyrfalcon; //Field offset: 0x188
	public float speedRangeGyrfalcon; //Field offset: 0x190
	public string expSpeedRangeGyrfalcon; //Field offset: 0x198
	public GameObject genericIcon; //Field offset: 0x1A0
	public GameObject expGenericIcon; //Field offset: 0x1A8

	public virtual TowerBehaviorModel Def
	{
		 get { } //Length: 1648
	}

	public BeastHandlerPet() { }

	public virtual TowerBehaviorModel get_Def() { }

}

