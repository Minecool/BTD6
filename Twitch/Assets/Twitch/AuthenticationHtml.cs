namespace Assets.Twitch;

internal static class AuthenticationHtml
{
	internal const string Close = "
<html>
	<head>
		<title>BTD6 Twitch Authentication</title>
	</head>
	<body>
		<p>
			You can close this now :)
		</p>

		<noscript>
			<h1>
				Please enable javascript: it's required to link Bloons TD 6 to your Twitch account.
			</h1>
		</noscript>
	
		<script lang="javascript">
			window.open('','_self').close()
		</script>
	</body>
</html>"; //Field offset: 0x0
	internal const string Redirect = "
<html>
	<head>
		<title>BTD6 Twitch Authentication</title>
	</head>
	<body>
		<p>
			All done, you can close this now :)
		</p>

		<noscript>
			<h1>
				Please enable javascript: it's required to link Bloons TD 6 to your Twitch account.
			</h1>
		</noscript>
	
		<script lang="javascript">
			let request = new XMLHttpRequest();
			request.open('POST', '/', false);
			request.setRequestHeader('Content-Type', 'text');
			request.send(document.location.hash);
			window.location.replace("https://twitch.tv");
		</script>

	</body>
</html>"; //Field offset: 0x0

}

