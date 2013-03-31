using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Twilio;
using System.Configuration;

/// <summary>
/// Summary description for sms
/// </summary>
public class sms
{
    public String AccountSid = System.Configuration.ConfigurationManager.ConnectionStrings["twilioSid"].ConnectionString;
    public String AuthToken = System.Configuration.ConfigurationManager.ConnectionStrings["twilioToken"].ConnectionString;
    public string smsTest(string toNumber, string bodySms)
	{
        //string AccountSid = "AC3b08da20f68fc61030d52ab1e115150e";
       // string AuthToken = "2f741ba8d077a89f81d21f16f1494ade";
        var twilio = new TwilioRestClient(AccountSid, AuthToken);


        var message = twilio.SendSmsMessage("+14152266087", "+" + toNumber, bodySms, "");

        return message.Sid.ToString();
		
	}
    public string smsAlarm(string toNumber)
	{
        var twilio = new TwilioRestClient(AccountSid, AuthToken);


        var message = twilio.SendSmsMessage("+14152266087", "+"+toNumber, "Smoke detected", "");

        return message.Sid.ToString();
	}
}