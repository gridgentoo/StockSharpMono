namespace SampleDdeCustomTable
{
	using System.ComponentModel;

	using Ecng.Serialization;
	using Ecng.Trading.Quik;

	[DdeCustomTable("��������")]
	[Ignore(FieldName = "IsDisposed")]
	public class CustomPortfolio : INotifyPropertyChanged
	{
		[DdeCustomColumn("��� �������", Order = 0)]
		[Identity]
		public string Client { get; set; }

		private double _shorts;

		[DdeCustomColumn("�����", Order = 1)]
		public double Shorts
		{
			get { return _shorts; }
			set
			{
				_shorts = value;
				NotifyPropertyChanged("Shorts");
			}
		}

		private double _longs;

		[DdeCustomColumn("�����", Order = 2)]
		public double Longs
		{
			get { return _longs; }
			set
			{
				_longs = value;
				NotifyPropertyChanged("Longs");
			}
		}

		private double _collateral;

		[DdeCustomColumn("���.�����", Order = 3)]
		public double Collateral
		{
			get { return _collateral; }
			set
			{
				_collateral = value;
				NotifyPropertyChanged("Collateral");
			}
		}

		private double _margin;

		[DdeCustomColumn("��.�����", Order = 4)]
		public double Margin
		{
			get { return _margin; }
			set
			{
				_margin = value;
				NotifyPropertyChanged("Margin");
			}
		}

		private double _money;

		[DdeCustomColumn("������������", Order = 5)]
		public double Money
		{
			get { return _money; }
			set
			{
				_money = value;
				NotifyPropertyChanged("Money");
			}
		}

		private double _pnL;

		[DdeCustomColumn("�������/������", Order = 6)]
		public double PnL
		{
			get { return _pnL; }
			set
			{
				_pnL = value;
				NotifyPropertyChanged("PnL");
			}
		}

		private PropertyChangedEventHandler _propertyChanged;

		event PropertyChangedEventHandler INotifyPropertyChanged.PropertyChanged
		{
			add { _propertyChanged += value; }
			remove { _propertyChanged -= value; }
		}

		private void NotifyPropertyChanged(string info)
		{
			if (_propertyChanged != null)
				_propertyChanged(this, new PropertyChangedEventArgs(info));
		}
	}
}