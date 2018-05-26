using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoinMaster.FreyYa.Ticker.RawModels
{
	public class Sign
	{
		public int cont_no;
		/// <summary>
		/// // 거래 채결 시간
		/// </summary>
		public DateTime transaction_date;
		/// <summary>
		/// 판/구매 (ask, bid)
		/// </summary>
		public string type;
		/// <summary>
		///  거래 Currency 수량
		/// </summary>
		public double units_traded;
		/// <summary>
		///  1Currency 거래 금액
		/// </summary>
		public double price;
		/// <summary>
		/// 총 거래금액
		/// </summary>
		public double total;
	}
}
