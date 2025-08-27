namespace UnityEngine;

[NativeHeader("Runtime/Graphics/GraphicsScriptBindings.h")]
[NativeHeader("Runtime/Graphics/Renderer.h")]
[RequireComponent(typeof(Transform))]
[UsedByNativeCode]
public class Renderer : Component
{

	[NativeProperty("IsDynamicOccludee")]
	public bool allowOcclusionWhenDynamic
	{
		 get { } //Length: 51
		 set { } //Length: 66
	}

	public Bounds bounds
	{
		[FreeFunction(Name = "RendererScripting::GetWorldBounds", HasExplicitThis = True)]
		 get { } //Length: 81
	}

	public bool enabled
	{
		 get { } //Length: 51
		 set { } //Length: 66
	}

	public bool forceRenderingOff
	{
		 set { } //Length: 66
	}

	public LightProbeUsage lightProbeUsage
	{
		 set { } //Length: 64
	}

	public Bounds localBounds
	{
		[FreeFunction(Name = "RendererScripting::GetLocalBounds", HasExplicitThis = True)]
		 get { } //Length: 81
	}

	public Material material
	{
		 get { } //Length: 51
		 set { } //Length: 66
	}

	public Material[] materials
	{
		 get { } //Length: 51
		 set { } //Length: 101
	}

	public MotionVectorGenerationMode motionVectorGenerationMode
	{
		 set { } //Length: 64
	}

	public bool receiveShadows
	{
		 set { } //Length: 66
	}

	public ReflectionProbeUsage reflectionProbeUsage
	{
		 set { } //Length: 64
	}

	public ShadowCastingMode shadowCastingMode
	{
		 set { } //Length: 64
	}

	public Material sharedMaterial
	{
		 get { } //Length: 51
		 set { } //Length: 66
	}

	public Material[] sharedMaterials
	{
		 get { } //Length: 51
		 set { } //Length: 101
	}

	internal int sortingGroupID
	{
		internal get { } //Length: 51
	}

	internal int sortingGroupOrder
	{
		internal get { } //Length: 51
	}

	public int sortingLayerID
	{
		 get { } //Length: 51
		 set { } //Length: 64
	}

	public string sortingLayerName
	{
		 set { } //Length: 66
	}

	public int sortingOrder
	{
		 get { } //Length: 51
		 set { } //Length: 64
	}

	public Renderer() { }

	public bool get_allowOcclusionWhenDynamic() { }

	[FreeFunction(Name = "RendererScripting::GetWorldBounds", HasExplicitThis = True)]
	public Bounds get_bounds() { }

	private void get_bounds_Injected(out Bounds ret) { }

	public bool get_enabled() { }

	[FreeFunction(Name = "RendererScripting::GetLocalBounds", HasExplicitThis = True)]
	public Bounds get_localBounds() { }

	private void get_localBounds_Injected(out Bounds ret) { }

	public Material get_material() { }

	public Material[] get_materials() { }

	public Material get_sharedMaterial() { }

	public Material[] get_sharedMaterials() { }

	internal int get_sortingGroupID() { }

	internal int get_sortingGroupOrder() { }

	public int get_sortingLayerID() { }

	public int get_sortingOrder() { }

	[FreeFunction(Name = "RendererScripting::GetMaterial", HasExplicitThis = True)]
	private Material GetMaterial() { }

	[FreeFunction(Name = "RendererScripting::GetMaterialArray", HasExplicitThis = True)]
	private Material[] GetMaterialArray() { }

	public void GetPropertyBlock(MaterialPropertyBlock properties) { }

	[FreeFunction(Name = "RendererScripting::GetSharedMaterial", HasExplicitThis = True)]
	private Material GetSharedMaterial() { }

	[NativeName("GetMaterialArray")]
	private Material[] GetSharedMaterialArray() { }

	[FreeFunction(Name = "RendererScripting::GetPropertyBlock", HasExplicitThis = True)]
	internal void Internal_GetPropertyBlock(MaterialPropertyBlock dest) { }

	[FreeFunction(Name = "RendererScripting::SetPropertyBlock", HasExplicitThis = True)]
	internal void Internal_SetPropertyBlock(MaterialPropertyBlock properties) { }

	public void set_allowOcclusionWhenDynamic(bool value) { }

	public void set_enabled(bool value) { }

	public void set_forceRenderingOff(bool value) { }

	public void set_lightProbeUsage(LightProbeUsage value) { }

	public void set_material(Material value) { }

	public void set_materials(Material[] value) { }

	public void set_motionVectorGenerationMode(MotionVectorGenerationMode value) { }

	public void set_receiveShadows(bool value) { }

	public void set_reflectionProbeUsage(ReflectionProbeUsage value) { }

	public void set_shadowCastingMode(ShadowCastingMode value) { }

	public void set_sharedMaterial(Material value) { }

	public void set_sharedMaterials(Material[] value) { }

	public void set_sortingLayerID(int value) { }

	public void set_sortingLayerName(string value) { }

	public void set_sortingOrder(int value) { }

	[FreeFunction(Name = "RendererScripting::SetMaterial", HasExplicitThis = True)]
	private void SetMaterial(Material m) { }

	[FreeFunction(Name = "RendererScripting::SetMaterialArray", HasExplicitThis = True)]
	private void SetMaterialArray(Material[] m, int length) { }

	private void SetMaterialArray(Material[] m) { }

	public void SetPropertyBlock(MaterialPropertyBlock properties) { }

}

