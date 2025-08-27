namespace Assets.Scripts.Unity.Towers.Behaviors.Abilities.Behaviors;

public class PhoenixRebirth : AbilityBehavior
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<Tower, TowerModel> <>9__16_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal TowerModel <get_Def>b__16_0(Tower x) { }

	}

	public float duration; //Field offset: 0x88
	public Effect effectTower; //Field offset: 0x90
	public Effect expEffectTower; //Field offset: 0x98
	public Effect effectSubTower; //Field offset: 0xA0
	public Effect expEffectSubTower; //Field offset: 0xA8
	public Effect effectEndSubTower; //Field offset: 0xB0
	public Effect expEffectEndSubTower; //Field offset: 0xB8
	public Tower[] disabledSubTowers; //Field offset: 0xC0
	public Projectile projectileExplosion; //Field offset: 0xC8
	public Projectile expProjectileExplosion; //Field offset: 0xD0
	public int manaPerZombieZOMG; //Field offset: 0xD8
	public int maxZombieZOMGs; //Field offset: 0xDC
	public int zombieBFBsPerZOMG; //Field offset: 0xE0
	public Projectile projectileZOMG; //Field offset: 0xE8
	public Projectile projectileBFB; //Field offset: 0xF0

	public virtual AbilityBehaviorModel Def
	{
		 get { } //Length: 746
	}

	public PhoenixRebirth() { }

	public virtual AbilityBehaviorModel get_Def() { }

}

