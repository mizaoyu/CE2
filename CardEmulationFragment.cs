
using System;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Util;
using Android.Views;
using Android.Widget;
using Android.Text;

namespace CE2
{
	public class CardEmulationFragment : Fragment
	{
		public override void OnCreate (Bundle savedInstanceState)
		{
			base.OnCreate(savedInstanceState);

			// Create your fragment here
		}

		public override View OnCreateView(LayoutInflater inflater, ViewGroup container,
			Bundle savedInstanceState) {
			// Inflate the layout for this fragment
			View v = inflater.Inflate(Resource.Layout.Main, container, false);
			var account = (TextView) v.FindViewById(Resource.Id.card_account_field);
			string s = AccountStorage.GetAccount (Activity);
			account.Text = s;
			account.AddTextChangedListener(new AccountUpdater(Activity));

			return v;
		}

		private class AccountUpdater : Java.Lang.Object, ITextWatcher {
			public Context Act;

			public AccountUpdater(Context Act)
			{
				this.Act = Act;
			}

			public void BeforeTextChanged(Java.Lang.ICharSequence s, int start, int count, int after) {
				// Not implemented.
			}
				
			public void OnTextChanged(Java.Lang.ICharSequence s, int start, int before, int count) {
				// Not implemented.
			}

			public void AfterTextChanged(IEditable s) {
				string account = s.ToString();
				//CardEmulationFragment CEF = new CardEmulationFragment ();
				AccountStorage.SetAccount(Act, account);
			}
		}

	}


}

