using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace boostpanel.Utils
{
	public class TimeAligner
	{
		internal class TimeQuery
		{
			internal class TimeQueryResponse
			{
				[JsonProperty("server_time")]
				public long ServerTime
				{
					get;
					set;
				}
			}

			[JsonProperty("response")]
			internal TimeQueryResponse Response
			{
				get;
				set;
			}
		}

		private static bool _aligned;

		private static int _timeDifference;

		public static long GetSteamTime()
		{
			if (!_aligned)
			{
				AlignTime();
			}
			return Util.GetSystemUnixTime() + _timeDifference;
		}

		public static async Task<long> GetSteamTimeAsync()
		{
			if (!_aligned)
			{
				await AlignTimeAsync();
			}
			return Util.GetSystemUnixTime() + _timeDifference;
		}

		public static void AlignTime()
		{
			long systemUnixTime = Util.GetSystemUnixTime();
			
			try
			{
				using(WebClient webClient = new WebClient()){
					_timeDifference = (int)(JsonConvert.DeserializeObject<TimeQuery>(webClient.UploadString(APIEndpoints.TWO_FACTOR_TIME_QUERY, "steamid=0")).Response.ServerTime - systemUnixTime);
					_aligned = true;
				}
			}
			catch (WebException)
			{
			}
		}

		public static async Task AlignTimeAsync()
		{
			long currentTime = Util.GetSystemUnixTime();
			WebClient webClient = new WebClient();
			try
			{
				_timeDifference = (int)(JsonConvert.DeserializeObject<TimeQuery>(await webClient.UploadStringTaskAsync(new Uri(APIEndpoints.TWO_FACTOR_TIME_QUERY), "steamid=0")).Response.ServerTime - currentTime);
				_aligned = true;
			}
			catch (WebException)
			{
			}
		}
	}
}
