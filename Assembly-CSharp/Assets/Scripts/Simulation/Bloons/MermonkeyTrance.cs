namespace Assets.Scripts.Simulation.Bloons;

public class MermonkeyTrance : BloonBehavior
{
	private const float bloonZoffset = 45; //Field offset: 0x0
	public MermonkeyTranceModel tranceModel; //Field offset: 0x70
	public float rotation; //Field offset: 0x78
	public int elapsedTime; //Field offset: 0x7C
	public Vector3 originalBloonPos; //Field offset: 0x80
	public bool enteredOrbit; //Field offset: 0x8C
	public bool isInSequence; //Field offset: 0x8D
	public int sequenceEndedAt; //Field offset: 0x90
	public Tower towerToOrbit; //Field offset: 0x98

	public MermonkeyTrance() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	private void MoveInCirclePattern() { }

	private bool MoveTowardsTarget(Vector3 targetPos) { }

	protected virtual void OnDestroy() { }

	public virtual void PostDegrade(DamageResult damageResult, List<Bloon> childrenCreatedOut, List<Projectile> collidingWith, bool createEffect, Tower tower) { }

	private void Process(int elapsed) { }

	public void SetOrbitTower(Tower towerToOrbit) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

