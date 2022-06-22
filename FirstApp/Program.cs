using System;

class User
{
	private string login;
	private DateTime lastSeen;

	// Read-only
	public string Login
	{
		get
		{
			return login;
		}
	}

	// Write-only
	public DateTime LastSeen
	{
		set
		{
			lastSeen = value;
		}
	}
}