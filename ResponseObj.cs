using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace APIVerve
{
public class coordinates
{
    [JsonProperty("latitude")]
    public double latitude { get; set; }

    [JsonProperty("longitude")]
    public double longitude { get; set; }

}

public class sun
{
    [JsonProperty("altitude")]
    public double altitude { get; set; }

    [JsonProperty("azimuth")]
    public double azimuth { get; set; }

}

public class data
{
    [JsonProperty("coordinates")]
    public coordinates coordinates { get; set; }

    [JsonProperty("sun")]
    public sun sun { get; set; }

}

public class ResponseObj
{
    [JsonProperty("status")]
    public string status { get; set; }

    [JsonProperty("error")]
    public object error { get; set; }

    [JsonProperty("data")]
    public data data { get; set; }

    [JsonProperty("code")]
    public int code { get; set; }

}

}
