namespace Assets.Scripts.Unity.Cascade.Variable;

[ExecuteInEditMode]
public class ModVariables : MonoBehaviour
{
	private GameObject lastFrom; //Field offset: 0x20
	public GameObject from; //Field offset: 0x28

	public ModVariables() { }

	public GenericVariable[] GetVariables() { }

	private void InvalidateUses() { }

	private void OnDestroy() { }

	private void Update() { }

}

