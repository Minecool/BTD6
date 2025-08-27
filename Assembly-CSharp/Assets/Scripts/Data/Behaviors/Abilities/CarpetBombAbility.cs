namespace Assets.Scripts.Data.Behaviors.Abilities;

[CreateAssetMenu(fileName = "CarpetBombAbility", menuName = "BTD6/Behaviors/Abilities/CarpetBombAbility")]
public class CarpetBombAbility : AbilityBehavior
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<OffsetPosition, Vector3> <>9__14_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal Vector3 <get_Def>b__14_0(OffsetPosition e) { }

	}

	public PrefabReference targetDisplay; //Field offset: 0x30
	public Projectile projectile; //Field offset: 0x38
	public PrefabReference bombersPrefab; //Field offset: 0x40
	public PrefabReference lineDisplayGreenIndicator; //Field offset: 0x48
	public PrefabReference lineDisplayRedIndicator; //Field offset: 0x50
	public OffsetPosition[] ejectMarkers; //Field offset: 0x58
	public float bomberDropDelay; //Field offset: 0x60
	public float pointSwitchDistance; //Field offset: 0x64
	public float minPathDistance; //Field offset: 0x68
	public float lineDelay; //Field offset: 0x6C
	public float dotSpacing; //Field offset: 0x70
	public float dotOffset; //Field offset: 0x74
	public float numProjectiles; //Field offset: 0x78

	public virtual AbilityBehaviorModel Def
	{
		 get { } //Length: 682
	}

	public CarpetBombAbility() { }

	public virtual AbilityBehaviorModel get_Def() { }

}

