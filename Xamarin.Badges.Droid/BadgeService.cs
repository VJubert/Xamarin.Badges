using Android.Content;

namespace Xamarin.Badges.Droid;

public class BadgeService(Context context) : IBadgeService
{
	public void Clear()
	{
		Badger.ApplyBadgeCount(context, 0);
	}

	public void Set(int badgeCount)
	{
		Badger.ApplyBadgeCount(context, badgeCount);
	}
}