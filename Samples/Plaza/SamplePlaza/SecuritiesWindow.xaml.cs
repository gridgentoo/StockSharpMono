#region S# License
/******************************************************************************************
NOTICE!!!  This program and source code is owned and licensed by
StockSharp, LLC, www.stocksharp.com
Viewing or use of this code requires your acceptance of the license
agreement found at https://github.com/StockSharp/StockSharp/blob/master/LICENSE
Removal of this comment is a violation of the license agreement.

Project: SamplePlaza.SamplePlazaPublic
File: SecuritiesWindow.xaml.cs
Created: 2015, 11, 11, 2:32 PM

Copyright 2010 by StockSharp, LLC
*******************************************************************************************/
#endregion S# License
namespace SamplePlaza
{
	using System;
	using System.Windows;

	using Ecng.Collections;
	using Ecng.Xaml;

	using MoreLinq;

	using StockSharp.BusinessEntities;
	using StockSharp.Xaml;
	using StockSharp.Localization;

	public partial class SecuritiesWindow
	{
		private readonly SynchronizedDictionary<Security, QuotesWindow> _quotesWindows = new SynchronizedDictionary<Security, QuotesWindow>();
		private bool _initialized;

		public SecuritiesWindow()
		{
			InitializeComponent();
		}

		protected override void OnClosed(EventArgs e)
		{
			_quotesWindows.SyncDo(d => d.Values.ForEach(w =>
			{
				w.DeleteHideable();
				w.Close();
			}));

			var trader = MainWindow.Instance.Trader;
			if (trader != null)
			{
				if (_initialized)
					trader.MarketDepthChanged -= TraderOnMarketDepthChanged;
			}

			base.OnClosed(e);
		}

		private void NewOrderClick(object sender, RoutedEventArgs e)
		{
			var newOrder = new OrderWindow
			{
				Order = new Order { Security = SecurityPicker.SelectedSecurity },
				SecurityProvider = MainWindow.Instance.Trader,
				MarketDataProvider = MainWindow.Instance.Trader,
				Portfolios = new PortfolioDataSource(MainWindow.Instance.Trader),
			};

			if (newOrder.ShowModal(this))
				MainWindow.Instance.Trader.RegisterOrder(newOrder.Order);
		}

		private void SecurityPicker_OnSecuritySelected(Security security)
		{
			NewOrder.IsEnabled = Depth.IsEnabled = security != null;
		}

		private void DepthClick(object sender, RoutedEventArgs e)
		{
			var trader = MainWindow.Instance.Trader;

			foreach (var security in SecurityPicker.SelectedSecurities)
			{
				var window = _quotesWindows.SafeAdd(security, s =>
				{
					// начинаем получать котировки стакана
					trader.RegisterMarketDepth(security);

					// создаем окно со стаканом
					var wnd = new QuotesWindow
					{
						Title = security.Id + " " + LocalizedStrings.MarketDepth
					};
					wnd.MakeHideable();
					return wnd;
				});

				if (window.Visibility == Visibility.Visible)
					window.Hide();
				else
				{
					window.Show();
					window.DepthCtrl.UpdateDepth(trader.GetMarketDepth(security));
				}

				if (!_initialized)
				{
					trader.MarketDepthChanged += TraderOnMarketDepthChanged;
					_initialized = true;
				}
			}
		}

		private void TraderOnMarketDepthChanged(MarketDepth depth)
		{
			var wnd = _quotesWindows.TryGetValue(depth.Security);

			if (wnd != null)
				wnd.DepthCtrl.UpdateDepth(depth);
		}
	}
}