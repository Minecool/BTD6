namespace Assets.Scripts.Data.Behaviors.Abilities;

[CreateAssetMenu(fileName = "PhoenixRebirth", menuName = "BTD6/Behaviors/Abilities/PhoenixRebirth")]
public class PhoenixRebirth : AbilityBehavior
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<Tower, TowerModel> <>9__12_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal TowerModel <get_Def>b__12_0(Tower x) { }

	}

	public float duration; //Field offset: 0x30
	public Effect effectTower; //Field offset: 0x38
	public Effect effectSubTower; //Field offset: 0x40
	public Effect effectEndSubTower; //Field offset: 0x48
	public Tower[] disabledSubTowers; //Field offset: 0x50
	public Projectile projectileExplosion; //Field offset: 0x58
	public int manaPerZombieZOMG; //Field offset: 0x60
	public int maxZombieZOMGs; //Field offset: 0x64
	public int zombieBFBsPerZOMG; //Field offset: 0x68
	public Projectile projectileZOMG; //Field offset: 0x70
	public Projectile projectileBFB; //Field offset: 0x78

	public virtual AbilityBehaviorModel Def
	{
		 get { } //Length: 791
	}

	public PhoenixRebirth() { }

	public virtual AbilityBehaviorModel get_Def() { }

}

