using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace boostpanel.Utils
{
	public static class APIEndpoints
	{
		public const string STEAMAPI_BASE = "https://api.steampowered.com";

		public const string COMMUNITY_BASE = "https://steamcommunity.com";

		public const string MOBILEAUTH_BASE = "https://api.steampowered.com/IMobileAuthService/%s/v0001";

		public static string MOBILEAUTH_GETWGTOKEN = "https://api.steampowered.com/IMobileAuthService/%s/v0001".Replace("%s", "GetWGToken");

		public const string TWO_FACTOR_BASE = "https://api.steampowered.com/ITwoFactorService/%s/v0001";

		public static string TWO_FACTOR_TIME_QUERY = "https://api.steampowered.com/ITwoFactorService/%s/v0001".Replace("%s", "QueryTime");
	}
}
