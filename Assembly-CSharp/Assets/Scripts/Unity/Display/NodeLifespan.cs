namespace Assets.Scripts.Unity.Display;

public class NodeLifespan : MonoBehaviour
{
	public float lifespan; //Field offset: 0x20
	private float startLifespan; //Field offset: 0x24
	private bool valid; //Field offset: 0x28
	private UnityDisplayNode node; //Field offset: 0x30

	public NodeLifespan() { }

	public void Create() { }

	public void Init(UnityDisplayNode node) { }

	public void Update() { }

}

