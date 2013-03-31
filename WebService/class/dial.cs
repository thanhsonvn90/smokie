using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Twilio;

/// <summary>
/// Summary description for dial
/// </summary>
public class dial
{
    public String AccountSid = System.Configuration.ConfigurationManager.ConnectionStrings["twilioSid"].ConnectionString;
    public String AuthToken = System.Configuration.ConfigurationManager.ConnectionStrings["twilioToken"].ConnectionString;
    public String Host = System.Configuration.ConfigurationManager.ConnectionStrings["hostName"].ConnectionString;
    public string dialphone (string to, string imei)
	{
        //return "../Response.aspx?imei="+imei+to;
        var twilio = new TwilioRestClient(AccountSid, AuthToken);

        var options = new CallOptions();
        options.Url = "http://gpshaui.somee.com/twilio/service/Response.aspx";
        //Host+"Response.aspx?imei=" + imei;
        //options.Url = "http://demo.twilio.com/welcome/call/";
        options.To = to;
        options.From = "+14152266087";
        options.Timeout = 30;
        options.IfMachine = "Hangup";
        var call = twilio.InitiateOutboundCall(options);

        return call.Sid;
	}
}