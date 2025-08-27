namespace UnityEngine;

[NativeHeader("Runtime/Graphics/ShaderScriptBindings.h")]
[NativeHeader("Runtime/Shaders/Material.h")]
public class Material : object
{

	public Color color
	{
		 get { } //Length: 235
		 set { } //Length: 208
	}

	public bool doubleSidedGI
	{
		 get { } //Length: 51
		 set { } //Length: 66
	}

	public LocalKeyword[] enabledKeywords
	{
		 get { } //Length: 51
		 set { } //Length: 66
	}

	[NativeProperty("EnableInstancingVariants")]
	public bool enableInstancing
	{
		 get { } //Length: 51
		 set { } //Length: 66
	}

	public MaterialGlobalIlluminationFlags globalIlluminationFlags
	{
		 get { } //Length: 51
		 set { } //Length: 64
	}

	public Texture mainTexture
	{
		 get { } //Length: 182
		 set { } //Length: 198
	}

	public Vector2 mainTextureOffset
	{
		 get { } //Length: 225
		 set { } //Length: 216
	}

	public Vector2 mainTextureScale
	{
		 get { } //Length: 225
		 set { } //Length: 216
	}

	public int passCount
	{
		[NativeName("GetShader()->GetPassCount")]
		 get { } //Length: 51
	}

	internal int rawRenderQueue
	{
		[NativeName("GetCustomRenderQueue")]
		internal get { } //Length: 51
	}

	public int renderQueue
	{
		[NativeName("GetActualRenderQueue")]
		 get { } //Length: 51
		[NativeName("SetCustomRenderQueue")]
		 set { } //Length: 64
	}

	public Shader shader
	{
		 get { } //Length: 51
		 set { } //Length: 66
	}

	public String[] shaderKeywords
	{
		 get { } //Length: 51
		 set { } //Length: 66
	}

	public Material(Shader shader) { }

	[RequiredByNativeCode]
	public Material(Material source) { }

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Obsolete("Creating materials from shader source string is no longer supported. Use Shader assets instead.", False)]
	public Material(string contents) { }

	public int ComputeCRC() { }

	[FreeFunction("MaterialScripting::CopyMatchingPropertiesFrom", HasExplicitThis = True)]
	public void CopyMatchingPropertiesFromMaterial(Material mat) { }

	[FreeFunction("MaterialScripting::CopyPropertiesFrom", HasExplicitThis = True)]
	public void CopyPropertiesFromMaterial(Material mat) { }

	[Obsolete("Creating materials from shader source string will be removed in the future. Use Shader assets instead.", False)]
	public static Material Create(string scriptContents) { }

	[FreeFunction("MaterialScripting::CreateWithMaterial")]
	private static void CreateWithMaterial(Material self, Material source) { }

	[FreeFunction("MaterialScripting::CreateWithShader")]
	private static void CreateWithShader(Material self, Shader shader) { }

	[FreeFunction("MaterialScripting::CreateWithString")]
	private static void CreateWithString(Material self) { }

	public void DisableKeyword(in LocalKeyword keyword) { }

	public void DisableKeyword(string keyword) { }

	[FreeFunction("MaterialScripting::DisableKeyword", HasExplicitThis = True)]
	private void DisableLocalKeyword(LocalKeyword keyword) { }

	private void DisableLocalKeyword_Injected(ref LocalKeyword keyword) { }

	public void EnableKeyword(in LocalKeyword keyword) { }

	public void EnableKeyword(string keyword) { }

	[FreeFunction("MaterialScripting::EnableKeyword", HasExplicitThis = True)]
	private void EnableLocalKeyword(LocalKeyword keyword) { }

	private void EnableLocalKeyword_Injected(ref LocalKeyword keyword) { }

	private void ExtractColorArray(int name, List<Color> values) { }

	[FreeFunction(Name = "MaterialScripting::ExtractColorArray", HasExplicitThis = True)]
	private void ExtractColorArrayImpl(int name, out Color[] val) { }

	private void ExtractFloatArray(int name, List<Single> values) { }

	[FreeFunction(Name = "MaterialScripting::ExtractFloatArray", HasExplicitThis = True)]
	private void ExtractFloatArrayImpl(int name, out Single[] val) { }

	private void ExtractMatrixArray(int name, List<Matrix4x4> values) { }

	[FreeFunction(Name = "MaterialScripting::ExtractMatrixArray", HasExplicitThis = True)]
	private void ExtractMatrixArrayImpl(int name, out Matrix4x4[] val) { }

	private void ExtractVectorArray(int name, List<Vector4> values) { }

	[FreeFunction(Name = "MaterialScripting::ExtractVectorArray", HasExplicitThis = True)]
	private void ExtractVectorArrayImpl(int name, out Vector4[] val) { }

	public int FindPass(string passName) { }

	public Color get_color() { }

	public bool get_doubleSidedGI() { }

	public LocalKeyword[] get_enabledKeywords() { }

	public bool get_enableInstancing() { }

	public MaterialGlobalIlluminationFlags get_globalIlluminationFlags() { }

	public Texture get_mainTexture() { }

	public Vector2 get_mainTextureOffset() { }

	public Vector2 get_mainTextureScale() { }

	[NativeName("GetShader()->GetPassCount")]
	public int get_passCount() { }

	[NativeName("GetCustomRenderQueue")]
	internal int get_rawRenderQueue() { }

	[NativeName("GetActualRenderQueue")]
	public int get_renderQueue() { }

	public Shader get_shader() { }

	public String[] get_shaderKeywords() { }

	public GraphicsBufferHandle GetBuffer(string name) { }

	[NativeName("GetBufferFromScript")]
	private GraphicsBufferHandle GetBufferImpl(int name) { }

	private void GetBufferImpl_Injected(int name, out GraphicsBufferHandle ret) { }

	public Color GetColor(int nameID) { }

	public Color GetColor(string name) { }

	public Color[] GetColorArray(int nameID) { }

	public void GetColorArray(string name, List<Color> values) { }

	public Color[] GetColorArray(string name) { }

	public void GetColorArray(int nameID, List<Color> values) { }

	[FreeFunction(Name = "MaterialScripting::GetColorArrayCount", HasExplicitThis = True)]
	private int GetColorArrayCountImpl(int name) { }

	[FreeFunction(Name = "MaterialScripting::GetColorArray", HasExplicitThis = True)]
	private Color[] GetColorArrayImpl(int name) { }

	[NativeName("GetColorFromScript")]
	private Color GetColorImpl(int name) { }

	private void GetColorImpl_Injected(int name, out Color ret) { }

	public GraphicsBufferHandle GetConstantBuffer(string name) { }

	[NativeName("GetConstantBufferFromScript")]
	private GraphicsBufferHandle GetConstantBufferImpl(int name) { }

	private void GetConstantBufferImpl_Injected(int name, out GraphicsBufferHandle ret) { }

	internal static Material GetDefaultLineMaterial() { }

	internal static Material GetDefaultMaterial() { }

	internal static Material GetDefaultParticleMaterial() { }

	[FreeFunction("MaterialScripting::GetEnabledKeywords", HasExplicitThis = True)]
	private LocalKeyword[] GetEnabledKeywords() { }

	[NativeName("GetFirstPropertyNameIdByAttributeFromScript")]
	private int GetFirstPropertyNameIdByAttribute(ShaderPropertyFlags attributeFlag) { }

	public float GetFloat(string name) { }

	public float GetFloat(int nameID) { }

	public Single[] GetFloatArray(string name) { }

	public Single[] GetFloatArray(int nameID) { }

	public void GetFloatArray(int nameID, List<Single> values) { }

	public void GetFloatArray(string name, List<Single> values) { }

	[FreeFunction(Name = "MaterialScripting::GetFloatArrayCount", HasExplicitThis = True)]
	private int GetFloatArrayCountImpl(int name) { }

	[FreeFunction(Name = "MaterialScripting::GetFloatArray", HasExplicitThis = True)]
	private Single[] GetFloatArrayImpl(int name) { }

	[NativeName("GetFloatFromScript")]
	private float GetFloatImpl(int name) { }

	public int GetInt(int nameID) { }

	public int GetInt(string name) { }

	public int GetInteger(string name) { }

	public int GetInteger(int nameID) { }

	[NativeName("GetIntFromScript")]
	private int GetIntImpl(int name) { }

	public Matrix4x4 GetMatrix(int nameID) { }

	public Matrix4x4 GetMatrix(string name) { }

	public Matrix4x4[] GetMatrixArray(int nameID) { }

	public Matrix4x4[] GetMatrixArray(string name) { }

	public void GetMatrixArray(string name, List<Matrix4x4> values) { }

	public void GetMatrixArray(int nameID, List<Matrix4x4> values) { }

	[FreeFunction(Name = "MaterialScripting::GetMatrixArrayCount", HasExplicitThis = True)]
	private int GetMatrixArrayCountImpl(int name) { }

	[FreeFunction(Name = "MaterialScripting::GetMatrixArray", HasExplicitThis = True)]
	private Matrix4x4[] GetMatrixArrayImpl(int name) { }

	[NativeName("GetMatrixFromScript")]
	private Matrix4x4 GetMatrixImpl(int name) { }

	private void GetMatrixImpl_Injected(int name, out Matrix4x4 ret) { }

	public string GetPassName(int pass) { }

	public String[] GetPropertyNames(MaterialPropertyType type) { }

	[FreeFunction("MaterialScripting::GetPropertyNames", HasExplicitThis = True)]
	private String[] GetPropertyNamesImpl(int propertyType) { }

	[FreeFunction("MaterialScripting::GetShaderKeywords", HasExplicitThis = True)]
	private String[] GetShaderKeywords() { }

	[FreeFunction("MaterialScripting::GetShaderPassEnabled", HasExplicitThis = True)]
	public bool GetShaderPassEnabled(string passName) { }

	public string GetTag(string tag, bool searchFallbacks) { }

	public string GetTag(string tag, bool searchFallbacks, string defaultValue) { }

	[NativeName("GetTag")]
	private string GetTagImpl(string tag, bool currentSubShaderOnly, string defaultValue) { }

	public Texture GetTexture(string name) { }

	public Texture GetTexture(int nameID) { }

	[NativeName("GetTextureFromScript")]
	private Texture GetTextureImpl(int name) { }

	public Vector2 GetTextureOffset(int nameID) { }

	public Vector2 GetTextureOffset(string name) { }

	public void GetTexturePropertyNameIDs(List<Int32> outNames) { }

	[FreeFunction("MaterialScripting::GetTexturePropertyNameIDs", HasExplicitThis = True)]
	public Int32[] GetTexturePropertyNameIDs() { }

	[FreeFunction("MaterialScripting::GetTexturePropertyNameIDsInternal", HasExplicitThis = True)]
	private void GetTexturePropertyNameIDsInternal(object outNames) { }

	public void GetTexturePropertyNames(List<String> outNames) { }

	[FreeFunction("MaterialScripting::GetTexturePropertyNames", HasExplicitThis = True)]
	public String[] GetTexturePropertyNames() { }

	[FreeFunction("MaterialScripting::GetTexturePropertyNamesInternal", HasExplicitThis = True)]
	private void GetTexturePropertyNamesInternal(object outNames) { }

	public Vector2 GetTextureScale(string name) { }

	public Vector2 GetTextureScale(int nameID) { }

	[NativeName("GetTextureScaleAndOffsetFromScript")]
	private Vector4 GetTextureScaleAndOffsetImpl(int name) { }

	private void GetTextureScaleAndOffsetImpl_Injected(int name, out Vector4 ret) { }

	public Vector4 GetVector(int nameID) { }

	public Vector4 GetVector(string name) { }

	public void GetVectorArray(string name, List<Vector4> values) { }

	public Vector4[] GetVectorArray(string name) { }

	public void GetVectorArray(int nameID, List<Vector4> values) { }

	public Vector4[] GetVectorArray(int nameID) { }

	[FreeFunction(Name = "MaterialScripting::GetVectorArrayCount", HasExplicitThis = True)]
	private int GetVectorArrayCountImpl(int name) { }

	[FreeFunction(Name = "MaterialScripting::GetVectorArray", HasExplicitThis = True)]
	private Vector4[] GetVectorArrayImpl(int name) { }

	public bool HasBuffer(string name) { }

	public bool HasBuffer(int nameID) { }

	[NativeName("HasBufferFromScript")]
	private bool HasBufferImpl(int name) { }

	public bool HasColor(string name) { }

	public bool HasColor(int nameID) { }

	public bool HasConstantBuffer(string name) { }

	public bool HasConstantBuffer(int nameID) { }

	[NativeName("HasConstantBufferFromScript")]
	private bool HasConstantBufferImpl(int name) { }

	public bool HasFloat(int nameID) { }

	public bool HasFloat(string name) { }

	[NativeName("HasFloatFromScript")]
	private bool HasFloatImpl(int name) { }

	public bool HasInt(int nameID) { }

	public bool HasInt(string name) { }

	public bool HasInteger(string name) { }

	public bool HasInteger(int nameID) { }

	[NativeName("HasIntegerFromScript")]
	private bool HasIntImpl(int name) { }

	public bool HasMatrix(int nameID) { }

	public bool HasMatrix(string name) { }

	[NativeName("HasMatrixFromScript")]
	private bool HasMatrixImpl(int name) { }

	[NativeName("HasPropertyFromScript")]
	public bool HasProperty(int nameID) { }

	public bool HasProperty(string name) { }

	public bool HasTexture(string name) { }

	public bool HasTexture(int nameID) { }

	[NativeName("HasTextureFromScript")]
	private bool HasTextureImpl(int name) { }

	public bool HasVector(int nameID) { }

	public bool HasVector(string name) { }

	[NativeName("HasVectorFromScript")]
	private bool HasVectorImpl(int name) { }

	public bool IsKeywordEnabled(string keyword) { }

	public bool IsKeywordEnabled(in LocalKeyword keyword) { }

	[FreeFunction("MaterialScripting::IsKeywordEnabled", HasExplicitThis = True)]
	private bool IsLocalKeywordEnabled(LocalKeyword keyword) { }

	private bool IsLocalKeywordEnabled_Injected(ref LocalKeyword keyword) { }

	[FreeFunction("MaterialScripting::Lerp", HasExplicitThis = True)]
	[NativeThrows]
	public void Lerp(Material start, Material end, float t) { }

	public void set_color(Color value) { }

	public void set_doubleSidedGI(bool value) { }

	public void set_enabledKeywords(LocalKeyword[] value) { }

	public void set_enableInstancing(bool value) { }

	public void set_globalIlluminationFlags(MaterialGlobalIlluminationFlags value) { }

	public void set_mainTexture(Texture value) { }

	public void set_mainTextureOffset(Vector2 value) { }

	public void set_mainTextureScale(Vector2 value) { }

	[NativeName("SetCustomRenderQueue")]
	public void set_renderQueue(int value) { }

	public void set_shader(Shader value) { }

	public void set_shaderKeywords(String[] value) { }

	public void SetBuffer(string name, ComputeBuffer value) { }

	public void SetBuffer(int nameID, ComputeBuffer value) { }

	public void SetBuffer(string name, GraphicsBuffer value) { }

	public void SetBuffer(int nameID, GraphicsBuffer value) { }

	[NativeName("SetBufferFromScript")]
	private void SetBufferImpl(int name, ComputeBuffer value) { }

	public void SetColor(int nameID, Color value) { }

	public void SetColor(string name, Color value) { }

	public void SetColorArray(string name, Color[] values) { }

	private void SetColorArray(int name, Color[] values, int count) { }

	public void SetColorArray(string name, List<Color> values) { }

	public void SetColorArray(int nameID, List<Color> values) { }

	public void SetColorArray(int nameID, Color[] values) { }

	[FreeFunction(Name = "MaterialScripting::SetColorArray", HasExplicitThis = True)]
	private void SetColorArrayImpl(int name, Color[] values, int count) { }

	[NativeName("SetColorFromScript")]
	private void SetColorImpl(int name, Color value) { }

	private void SetColorImpl_Injected(int name, ref Color value) { }

	public void SetConstantBuffer(string name, GraphicsBuffer value, int offset, int size) { }

	public void SetConstantBuffer(string name, ComputeBuffer value, int offset, int size) { }

	public void SetConstantBuffer(int nameID, GraphicsBuffer value, int offset, int size) { }

	public void SetConstantBuffer(int nameID, ComputeBuffer value, int offset, int size) { }

	[NativeName("SetConstantBufferFromScript")]
	private void SetConstantBufferImpl(int name, ComputeBuffer value, int offset, int size) { }

	[NativeName("SetConstantBufferFromScript")]
	private void SetConstantGraphicsBufferImpl(int name, GraphicsBuffer value, int offset, int size) { }

	[FreeFunction("MaterialScripting::SetEnabledKeywords", HasExplicitThis = True)]
	private void SetEnabledKeywords(LocalKeyword[] keywords) { }

	public void SetFloat(int nameID, float value) { }

	public void SetFloat(string name, float value) { }

	public void SetFloatArray(int nameID, Single[] values) { }

	public void SetFloatArray(string name, Single[] values) { }

	private void SetFloatArray(int name, Single[] values, int count) { }

	public void SetFloatArray(int nameID, List<Single> values) { }

	public void SetFloatArray(string name, List<Single> values) { }

	[FreeFunction(Name = "MaterialScripting::SetFloatArray", HasExplicitThis = True)]
	private void SetFloatArrayImpl(int name, Single[] values, int count) { }

	[NativeName("SetFloatFromScript")]
	private void SetFloatImpl(int name, float value) { }

	[NativeName("SetBufferFromScript")]
	private void SetGraphicsBufferImpl(int name, GraphicsBuffer value) { }

	public void SetInt(int nameID, int value) { }

	public void SetInt(string name, int value) { }

	public void SetInteger(string name, int value) { }

	public void SetInteger(int nameID, int value) { }

	[NativeName("SetIntFromScript")]
	private void SetIntImpl(int name, int value) { }

	public void SetKeyword(in LocalKeyword keyword, bool value) { }

	[FreeFunction("MaterialScripting::SetKeyword", HasExplicitThis = True)]
	private void SetLocalKeyword(LocalKeyword keyword, bool value) { }

	private void SetLocalKeyword_Injected(ref LocalKeyword keyword, bool value) { }

	public void SetMatrix(int nameID, Matrix4x4 value) { }

	public void SetMatrix(string name, Matrix4x4 value) { }

	public void SetMatrixArray(string name, Matrix4x4[] values) { }

	public void SetMatrixArray(int nameID, List<Matrix4x4> values) { }

	public void SetMatrixArray(string name, List<Matrix4x4> values) { }

	public void SetMatrixArray(int nameID, Matrix4x4[] values) { }

	private void SetMatrixArray(int name, Matrix4x4[] values, int count) { }

	[FreeFunction(Name = "MaterialScripting::SetMatrixArray", HasExplicitThis = True)]
	private void SetMatrixArrayImpl(int name, Matrix4x4[] values, int count) { }

	[NativeName("SetMatrixFromScript")]
	private void SetMatrixImpl(int name, Matrix4x4 value) { }

	private void SetMatrixImpl_Injected(int name, ref Matrix4x4 value) { }

	public void SetOverrideTag(string tag, string val) { }

	[FreeFunction("MaterialScripting::SetPass", HasExplicitThis = True)]
	public bool SetPass(int pass) { }

	[NativeName("SetRenderTextureFromScript")]
	private void SetRenderTextureImpl(int name, RenderTexture value, RenderTextureSubElement element) { }

	[FreeFunction("MaterialScripting::SetShaderKeywords", HasExplicitThis = True)]
	private void SetShaderKeywords(String[] names) { }

	[FreeFunction("MaterialScripting::SetShaderPassEnabled", HasExplicitThis = True)]
	public void SetShaderPassEnabled(string passName, bool enabled) { }

	public void SetTexture(string name, Texture value) { }

	public void SetTexture(int nameID, Texture value) { }

	public void SetTexture(string name, RenderTexture value, RenderTextureSubElement element) { }

	public void SetTexture(int nameID, RenderTexture value, RenderTextureSubElement element) { }

	[NativeName("SetTextureFromScript")]
	private void SetTextureImpl(int name, Texture value) { }

	public void SetTextureOffset(string name, Vector2 value) { }

	public void SetTextureOffset(int nameID, Vector2 value) { }

	[NativeName("SetTextureOffsetFromScript")]
	private void SetTextureOffsetImpl(int name, Vector2 offset) { }

	private void SetTextureOffsetImpl_Injected(int name, ref Vector2 offset) { }

	public void SetTextureScale(string name, Vector2 value) { }

	public void SetTextureScale(int nameID, Vector2 value) { }

	[NativeName("SetTextureScaleFromScript")]
	private void SetTextureScaleImpl(int name, Vector2 scale) { }

	private void SetTextureScaleImpl_Injected(int name, ref Vector2 scale) { }

	public void SetVector(int nameID, Vector4 value) { }

	public void SetVector(string name, Vector4 value) { }

	private void SetVectorArray(int name, Vector4[] values, int count) { }

	public void SetVectorArray(int nameID, Vector4[] values) { }

	public void SetVectorArray(string name, List<Vector4> values) { }

	public void SetVectorArray(int nameID, List<Vector4> values) { }

	public void SetVectorArray(string name, Vector4[] values) { }

	[FreeFunction(Name = "MaterialScripting::SetVectorArray", HasExplicitThis = True)]
	private void SetVectorArrayImpl(int name, Vector4[] values, int count) { }

}

