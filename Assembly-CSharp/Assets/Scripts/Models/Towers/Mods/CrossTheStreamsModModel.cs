namespace Assets.Scripts.Models.Towers.Mods;

public class CrossTheStreamsModModel : MutatorModModel
{
	[ExtendedDrawer]
	public ProjectileModel projectile; //Field offset: 0x30
	public EffectModel effectModel; //Field offset: 0x38
	[SerializeField]
	private float rate; //Field offset: 0x40
	public int rateFrames; //Field offset: 0x44
	public float positionRandomness; //Field offset: 0x48
	public float endPointOffset; //Field offset: 0x4C

	public CrossTheStreamsModModel(string name, ProjectileModel projectile, EffectModel effectModel, float rate, float positionRandomness, float endPointOffset) { }

	public virtual Model Clone() { }

	public virtual bool Mutate(GameModel model, GameModel unmodded) { }

}

