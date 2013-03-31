using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using Twilio;

namespace WebService
{
    /// <summary>
    /// Summary description for Service1
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class Service1 : System.Web.Services.WebService
    {
        private sms twilioSms = new sms();
        private dial twilioDial = new dial();
        
        
        [WebMethod(Description = "Tra ve Sid va Token")]
        public string HelloWorld(string id)
        {

           // return twilioSms.AccountSid;
            return id;
        }
        [WebMethod(Description = "Thuc hien khi bam Test button")]
        public string test(string to, string body)
        {
            return twilioSms.smsTest(to, body);
        }
        [WebMethod(Description = "Thuc hien khi phat hien smoke")]
        public string alarm(string to)
        {
            return twilioSms.smsAlarm(to);

        }
        [WebMethod(Description = "Thuc hien cuoc goi")]
        public string dial(string toNumber, string imeiSensor)
        {
            return twilioDial.dialphone(toNumber, imeiSensor);

        }
        [WebMethod(Description = "Test loi sms")]
        public string testsms(string toNumber)
        {
            // of the placeholders shown here.
            string accountSID = "AC3b08da20f68fc61030d52ab1e115150e";
            string authToken = "2f741ba8d077a89f81d21f16f1494ade";

            // Create an instance of the Twilio client.
            TwilioRestClient client;
            client = new TwilioRestClient(accountSID, authToken);

            // Retrieve the account, used later to create an instance
            // of the client.
            Twilio.Account account = client.GetAccount();

            // Send an SMS message.
            SMSMessage result = client.SendSmsMessage(
                "+14152266087", "+"+toNumber, "This is my SMS message.");

            if (result.RestException != null)
            {
                //an exception occurred making the REST call
                string message = result.RestException.Message;
                return message;
            }
            else{
                return "OK";
            }

        }

    }
}