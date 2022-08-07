class Program
{
	static void GetPageForUser(User user)
	{
		if (!user.LoggedIn)
			return;

		Console.WriteLine("User logged in");

		if (!user.HasAccessToSection)
			return;

		Console.WriteLine("User has access to that section");

		if (user.HasUnseenNews)
			ShowNews();


		if (user.HasAdminRights)
			DecorateAdminTools();


	}
}