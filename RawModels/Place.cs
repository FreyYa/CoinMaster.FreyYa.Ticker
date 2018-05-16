using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoinMasterViewer.Models
{
	public class Place
	{
		/// <summary>
		/// 거래 활성화 여부
		/// </summary>
		public bool IsEnable { get; set; }
		/// <summary>
		/// 그래프 표시 여부
		/// </summary>
		public bool IsVisible { get; set; }
		/// <summary>
		/// 그래프 색
		/// </summary>
		public Color Color { get; set; }
		/// <summary>
		/// 
		/// </summary>
		public string Name { get; set; }
		/// <summary>
		/// 거래량
		/// </summary>
		public double Percent { get; set; }
		/// <summary>
		/// 거래량
		/// </summary>
		public decimal Units { get; set; }
		/// <summary>
		/// 거래 형식. 구매: Bid, 판매 : Ask 
		/// </summary>
		public TradeType TradeType { get; set; }
		/// <summary>
		/// 거래 가격
		/// </summary>
		public double Price { get; set; }
		public override string ToString()
		{
			return Name;
		}
	}
}
