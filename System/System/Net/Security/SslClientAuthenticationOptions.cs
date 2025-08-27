namespace System.Net.Security;

public class SslClientAuthenticationOptions
{
	private EncryptionPolicy _encryptionPolicy; //Field offset: 0x10
	private X509RevocationMode _checkCertificateRevocation; //Field offset: 0x14
	private SslProtocols _enabledSslProtocols; //Field offset: 0x18
	private bool _allowRenegotiation; //Field offset: 0x1C
	[CompilerGenerated]
	private LocalCertificateSelectionCallback <LocalCertificateSelectionCallback>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	private RemoteCertificateValidationCallback <RemoteCertificateValidationCallback>k__BackingField; //Field offset: 0x28
	[CompilerGenerated]
	private string <TargetHost>k__BackingField; //Field offset: 0x30
	[CompilerGenerated]
	private X509CertificateCollection <ClientCertificates>k__BackingField; //Field offset: 0x38

	public bool AllowRenegotiation
	{
		 get { } //Length: 5
	}

	public X509RevocationMode CertificateRevocationCheckMode
	{
		 set { } //Length: 156
	}

	public X509CertificateCollection ClientCertificates
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 5
	}

	public SslProtocols EnabledSslProtocols
	{
		 get { } //Length: 4
		 set { } //Length: 4
	}

	public EncryptionPolicy EncryptionPolicy
	{
		 set { } //Length: 156
	}

	public LocalCertificateSelectionCallback LocalCertificateSelectionCallback
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 5
	}

	public RemoteCertificateValidationCallback RemoteCertificateValidationCallback
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public string TargetHost
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 5
	}

	public SslClientAuthenticationOptions() { }

	public bool get_AllowRenegotiation() { }

	[CompilerGenerated]
	public X509CertificateCollection get_ClientCertificates() { }

	public SslProtocols get_EnabledSslProtocols() { }

	[CompilerGenerated]
	public LocalCertificateSelectionCallback get_LocalCertificateSelectionCallback() { }

	[CompilerGenerated]
	public RemoteCertificateValidationCallback get_RemoteCertificateValidationCallback() { }

	[CompilerGenerated]
	public string get_TargetHost() { }

	public void set_CertificateRevocationCheckMode(X509RevocationMode value) { }

	[CompilerGenerated]
	public void set_ClientCertificates(X509CertificateCollection value) { }

	public void set_EnabledSslProtocols(SslProtocols value) { }

	public void set_EncryptionPolicy(EncryptionPolicy value) { }

	[CompilerGenerated]
	public void set_LocalCertificateSelectionCallback(LocalCertificateSelectionCallback value) { }

	[CompilerGenerated]
	public void set_TargetHost(string value) { }

}

