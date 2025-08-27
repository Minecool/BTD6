namespace UnityEngine.UI;

[AddComponentMenu(null)]
public class SolidShadow : BaseMeshEffect
{
	internal class SelectionListener : MonoBehaviour, ISelectHandler, IEventSystemHandler, IDeselectHandler
	{
		public Action onSelect; //Field offset: 0x20
		public Action onDeselect; //Field offset: 0x28

		public SelectionListener() { }

		public override void OnDeselect(BaseEventData eventData) { }

		public override void OnSelect(BaseEventData eventData) { }

	}

	private const float kMaxEffectDistance = 600; //Field offset: 0x0
	private Material origMaterial; //Field offset: 0x28
	private SolidShadowConfig config; //Field offset: 0x30
	private Graphic targetGraphic; //Field offset: 0x38
	private bool m_UseGraphicAlpha; //Field offset: 0x40
	private Vector2 modPivot; //Field offset: 0x44

	private SolidShadowConfig Config
	{
		private get { } //Length: 169
	}

	private Color m_OutlineColor
	{
		private get { } //Length: 48
	}

	private float m_OutlinePadding
	{
		private get { } //Length: 31
	}

	private Color m_ShadowColor
	{
		private get { } //Length: 48
	}

	private Vector2 m_ShadowOffset
	{
		private get { } //Length: 44
	}

	public SolidShadow() { }

	protected void ApplyShadow(List<UIVertex> verts, Color32 color, int start, int end, Vector2 offset, bool first) { }

	protected void ApplyShadowZeroAlloc(List<UIVertex> verts, Color32 color, int start, int end, Vector2 offset, bool first) { }

	public static Button AutoAddButton(GameObject target) { }

	public static Button AutoAddButton(GameObject target, Graphic graphic) { }

	public static Button AutoAddSelectedButton(GameObject target, Action onSelect, Action onDeselect) { }

	protected virtual void Awake() { }

	private SolidShadowConfig get_Config() { }

	private Color get_m_OutlineColor() { }

	private float get_m_OutlinePadding() { }

	private Color get_m_ShadowColor() { }

	private Vector2 get_m_ShadowOffset() { }

	public virtual void ModifyMesh(VertexHelper vh) { }

	protected virtual void OnDisable() { }

	protected virtual void OnEnable() { }

	public void OverrideMaterials(Material origMaterial, Material overrideMaterial) { }

	public void Redraw() { }

}

