using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modle
{
    public class Cityinfo
    {
        /// <summary>
        /// 河南
        /// </summary>
        public string provinces { get; set; }
        /// <summary>
        /// 郑州
        /// </summary>
        public string city { get; set; }
        /// <summary>
        /// 郑州
        /// </summary>
        public string area { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string id { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string prov_py { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string city_py { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string qh { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string jb { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string yb { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string area_py { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string area_short_code { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string lng { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string lat { get; set; }
    }

    public class City
    {
        /// <summary>
        /// 
        /// </summary>
        public string night_air_temperature { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string day_air_temperature { get; set; }
        /// <summary>
        /// 南风
        /// </summary>
        public string wind_direction { get; set; }
        /// <summary>
        /// <3级
        /// </summary>
        public string wind_power { get; set; }
        /// <summary>
        /// 晴
        /// </summary>
        public string weather { get; set; }
    }

    public class Detail
    {
        /// <summary>
        /// 
        /// </summary>
        public string time { get; set; }
        /// <summary>
        /// 10月18日
        /// </summary>
        public string date { get; set; }
        /// <summary>
        /// 五
        /// </summary>
        public string week { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string temperature { get; set; }
        /// <summary>
        /// 西南风
        /// </summary>
        public string wind_direction { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string wind_direction_str { get; set; }
        /// <summary>
        /// 1级
        /// </summary>
        public string wind_power { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string wind_speed { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string humidity { get; set; }
        /// <summary>
        /// 晴
        /// </summary>
        public string weather { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string weather_english { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string qy { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string njd { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string rain { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string aqi { get; set; }
        /// <summary>
        /// 良
        /// </summary>
        public string quality { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string aqi_pm25 { get; set; }
        /// <summary>
        /// 九月二十
        /// </summary>
        public string nongli { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string sun_begin { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string sun_end { get; set; }
    }

    public class Now
    {
        /// <summary>
        /// 
        /// </summary>
        public string id { get; set; }
        /// <summary>
        /// 郑州
        /// </summary>
        public string area_name { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public City city { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Detail detail { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int update_time { get; set; }
    }

    public class Data
    {
        /// <summary>
        /// 
        /// </summary>
        public Cityinfo cityinfo { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Now now { get; set; }
    }

    public class Root
    {
        /// <summary>
        /// 
        /// </summary>
        public int ret { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Data data { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public double qt { get; set; }
    }
}
