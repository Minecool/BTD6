namespace Assets.Scripts.Unity.Map.Effects;

public class PlayEffectOnRemoveableSold : OnRemoveableSold
{
	public GameObject effectPrefab; //Field offset: 0x28
	public bool useGameObjectPosition; //Field offset: 0x30
	public Vector3 position; //Field offset: 0x34
	public Vector3 rotation; //Field offset: 0x40
	public float delay; //Field offset: 0x4C
	public float duration; //Field offset: 0x50
	private GameObject effect; //Field offset: 0x58
	private float triggerTime; //Field offset: 0x60
	private float endTime; //Field offset: 0x64
	private float particleLifespan; //Field offset: 0x68
	private Vector3 positionUsingGameObjectTransform; //Field offset: 0x6C
	private Quaternion rotationUsingGameObjectTransform; //Field offset: 0x78

	public PlayEffectOnRemoveableSold() { }

	public virtual void PerformAction() { }

	public virtual void SetToOriginalState(bool mapEventActive) { }

	private void Update() { }

}

