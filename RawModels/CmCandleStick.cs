using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoinMaster.FreyYa.Ticker.RawModels
{

	//13.1.3 버전
	/*
	 CREATE TABLE `bongtbl` (
	  `Id` int(11) NOT NULL AUTO_INCREMENT,
	  `Bun` varchar(45) COLLATE utf8_bin DEFAULT NULL,      //1분, 5분, 10분, 15분 ,30분 60분 
	  `DateTime` datetime DEFAULT NULL,                     //날짜시간 
	  `Open` double DEFAULT '0',                            //시가  
	  `High` double DEFAULT '0',                            //고가
	  `Low` double DEFAULT '0',                             //저가
	  `Close` double DEFAULT '0',                           //종가      
	  `Volume` double DEFAULT '0',                          //거래량
	  `Currency` varchar(45) COLLATE utf8_bin DEFAULT NULL,      //통화 종류
	  PRIMARY KEY (`Id`),
	  KEY `Idx_Bun` (`Bun`,`DateTime`)
	) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_bin;
	 */
	public class CmCandleStick
	{
		public CmCandleStick()
		{

		}
		public CmCandleStick(Sign item)
		{
			this.DateTime = item.transaction_date;
			this.Open = item.price;
			this.High = item.price;
			this.Low = item.price;
			this.Close = item.price;
			this.Bun = 0;
			this.Currency = Currency;
			this.Volume = 0;
		}
		/// <summary>
		/// Tick Data 전용. 모든 값(Open,High,Low,Close)이 한 값으로 통일된다. Bun Status는 0
		/// </summary>
		/// <param name="price"></param>
		/// <param name="currency"></param>
		/// <param name="js_time">자바 스크립트 기반 시간 정보</param>
		public CmCandleStick(double price, string currency, string js_time)
		{
			this.Bun = 0;
			this.Currency = currency;
			this.DateTime = ConvertFromUnixTimestamp(Convert.ToDouble(js_time));

			this.Open = price;
			this.High = price;
			this.Low = price;
			this.Close = price;
		}
		/// <summary>
		/// Default Candle Stick.
		/// </summary>
		/// <param name="Minute"></param>
		/// <param name="Open"></param>
		/// <param name="High"></param>
		/// <param name="Low"></param>
		/// <param name="Close"></param>
		/// <param name="Volume"></param>
		/// <param name="Currency"></param>
		public CmCandleStick(DateTime date, int minute, double open, double high, double low, double close, double volume, string currency)
		{
			this.Bun = minute;
			this.Currency = currency;
			this.DateTime = date;

			this.Open = open;
			this.High = high;
			this.Low = low;
			this.Close = close;
			this.Volume = volume;
		}
		static DateTime ConvertFromUnixTimestamp(double timestamp)
		{
			DateTime origin = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc);
			return origin.AddSeconds(timestamp / 1000).ToLocalTime();
		}
		/// <summary>
		/// AUTO_INCREMENT IDX. can't Insert
		/// </summary>
		public int Id { get; set; }
		/// <summary>
		/// 1분, 5분, 10분, 15분 ,30분 60분 
		/// </summary>
		public int Bun { get; set; }
		/// <summary>
		/// 날짜시간 
		/// </summary>
		public DateTime DateTime { get; set; }
		/// <summary>
		/// 시가
		/// </summary>
		public double Open { get; set; }
		/// <summary>
		/// 고가
		/// </summary>
		public double High { get; set; }
		/// <summary>
		/// 저가
		/// </summary>
		public double Low { get; set; }
		/// <summary>
		/// 종가 
		/// </summary>
		public double Close { get; set; }
		/// <summary>
		/// 거래량
		/// </summary>
		public double Volume { get; set; }
		/// <summary>
		/// 통화 종류. BTC, ETH, DASH, LTC, ETC, XRP, BCH, XMR, ZEC, QTUM, BTG, EOS
		/// </summary>
		public string Currency { get; set; }
		/// <summary>
		/// 해당 통화의 거래소 이름
		/// </summary>
		public string Exchange { get; set; }
	}
}
