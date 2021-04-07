using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using System.Xml.Serialization;

namespace WeatherService
{
	/// <summary>
	/// Логика взаимодействия для App.xaml
	/// </summary>
	// using System.Xml.Serialization;
	// XmlSerializer serializer = new XmlSerializer(typeof(XmlApiReply));
	// using (StringReader reader = new StringReader(xml))
	// {
	//    var test = (XmlApiReply)serializer.Deserialize(reader);
	// }

	[XmlRoot(ElementName = "city")]
	public class City
	{

		[XmlAttribute(AttributeName = "data")]
		public string Data { get; set; }
	}

	[XmlRoot(ElementName = "postal_code")]
	public class PostalCode
	{

		[XmlAttribute(AttributeName = "data")]
		public string Data { get; set; }
	}

	[XmlRoot(ElementName = "latitude_e6")]
	public class LatitudeE6
	{

		[XmlAttribute(AttributeName = "data")]
		public object Data { get; set; }
	}

	[XmlRoot(ElementName = "longitude_e6")]
	public class LongitudeE6
	{

		[XmlAttribute(AttributeName = "data")]
		public object Data { get; set; }
	}

	[XmlRoot(ElementName = "forecast_date")]
	public class ForecastDate
	{

		[XmlAttribute(AttributeName = "data")]
		public DateTime Data { get; set; }
	}

	[XmlRoot(ElementName = "current_date_time")]
	public class CurrentDateTime
	{

		[XmlAttribute(AttributeName = "data")]
		public DateTime Data { get; set; }
	}

	[XmlRoot(ElementName = "unit_system")]
	public class UnitSystem
	{

		[XmlAttribute(AttributeName = "data")]
		public string Data { get; set; }
	}

	[XmlRoot(ElementName = "forecast_information")]
	public class ForecastInformation
	{

		[XmlElement(ElementName = "city")]
		public City City { get; set; }

		[XmlElement(ElementName = "postal_code")]
		public PostalCode PostalCode { get; set; }

		[XmlElement(ElementName = "latitude_e6")]
		public LatitudeE6 LatitudeE6 { get; set; }

		[XmlElement(ElementName = "longitude_e6")]
		public LongitudeE6 LongitudeE6 { get; set; }

		[XmlElement(ElementName = "forecast_date")]
		public ForecastDate ForecastDate { get; set; }

		[XmlElement(ElementName = "current_date_time")]
		public CurrentDateTime CurrentDateTime { get; set; }

		[XmlElement(ElementName = "unit_system")]
		public UnitSystem UnitSystem { get; set; }
	}

	[XmlRoot(ElementName = "condition")]
	public class Condition
	{

		[XmlAttribute(AttributeName = "data")]
		public string Data { get; set; }
	}

	[XmlRoot(ElementName = "temp_f")]
	public class TempF
	{

		[XmlAttribute(AttributeName = "data")]
		public int Data { get; set; }
	}

	[XmlRoot(ElementName = "temp_c")]
	public class TempC
	{

		[XmlAttribute(AttributeName = "data")]
		public int Data { get; set; }
	}

	[XmlRoot(ElementName = "humidity")]
	public class Humidity
	{

		[XmlAttribute(AttributeName = "data")]
		public string Data { get; set; }
	}

	[XmlRoot(ElementName = "icon")]
	public class Icon
	{

		[XmlAttribute(AttributeName = "data")]
		public string Data { get; set; }
	}

	[XmlRoot(ElementName = "wind_condition")]
	public class WindCondition
	{

		[XmlAttribute(AttributeName = "data")]
		public string Data { get; set; }
	}

	[XmlRoot(ElementName = "current_conditions")]
	public class CurrentConditions
	{

		[XmlElement(ElementName = "condition")]
		public Condition Condition { get; set; }

		[XmlElement(ElementName = "temp_f")]
		public TempF TempF { get; set; }

		[XmlElement(ElementName = "temp_c")]
		public TempC TempC { get; set; }

		[XmlElement(ElementName = "humidity")]
		public Humidity Humidity { get; set; }

		[XmlElement(ElementName = "icon")]
		public Icon Icon { get; set; }

		[XmlElement(ElementName = "wind_condition")]
		public WindCondition WindCondition { get; set; }
	}

	[XmlRoot(ElementName = "day_of_week")]
	public class DayOfWeek
	{

		[XmlAttribute(AttributeName = "data")]
		public string Data { get; set; }
	}

	[XmlRoot(ElementName = "low")]
	public class Low
	{

		[XmlAttribute(AttributeName = "data")]
		public int Data { get; set; }
	}

	[XmlRoot(ElementName = "high")]
	public class High
	{

		[XmlAttribute(AttributeName = "data")]
		public int Data { get; set; }
	}

	[XmlRoot(ElementName = "forecast_conditions")]
	public class ForecastConditions
	{

		[XmlElement(ElementName = "day_of_week")]
		public DayOfWeek DayOfWeek { get; set; }

		[XmlElement(ElementName = "low")]
		public Low Low { get; set; }

		[XmlElement(ElementName = "high")]
		public High High { get; set; }

		[XmlElement(ElementName = "icon")]
		public Icon Icon { get; set; }

		[XmlElement(ElementName = "condition")]
		public Condition Condition { get; set; }
	}

	[XmlRoot(ElementName = "weather")]
	public class Weather
	{

		[XmlElement(ElementName = "forecast_information")]
		public ForecastInformation ForecastInformation { get; set; }

		[XmlElement(ElementName = "current_conditions")]
		public CurrentConditions CurrentConditions { get; set; }

		[XmlElement(ElementName = "forecast_conditions")]
		public List<ForecastConditions> ForecastConditions { get; set; }

		[XmlAttribute(AttributeName = "module_id")]
		public int ModuleId { get; set; }

		[XmlAttribute(AttributeName = "tab_id")]
		public int TabId { get; set; }

		[XmlAttribute(AttributeName = "mobile_row")]
		public int MobileRow { get; set; }

		[XmlAttribute(AttributeName = "mobile_zipped")]
		public int MobileZipped { get; set; }

		[XmlAttribute(AttributeName = "row")]
		public int Row { get; set; }

		[XmlAttribute(AttributeName = "section")]
		public int Section { get; set; }
	}

	[XmlRoot(ElementName = "xml_api_reply")]
	public class XmlApiReply
	{

		[XmlElement(ElementName = "weather")]
		public Weather Weather { get; set; }

		[XmlAttribute(AttributeName = "version")]
		public int Version { get; set; }
	}

}
