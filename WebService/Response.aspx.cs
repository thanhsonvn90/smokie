using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Response : System.Web.UI.Page
{

    string myXMLStringHead = "<?xml version='1.0' encoding='utf-8' ?><Response><Say>Thanks for the call. Configure your number's voice U R L to change this message.</Say><Pause length=\"1\"/><Say voice='woman'>Let us know if we can help you in any way during your development.</Say></Response>";
    //string myXMLStringHead = "<?xml version=\"1.0\" encoding=\"UTF-8\"?>\r\n<Response>\r\n<Say voice=\"woman\">Sensor with imei ";
    string myXMLStringEnd = "</Say>\r\n<Play>http://demo.twilio.com/docs/classic.mp3</Play>\r\n</Response>";
    protected void Page_Load(object sender, EventArgs e)
    {
        string id= Request["imei"];
        Response.Clear();
        Response.Write(myXMLStringHead);//+id+Time()+myXMLStringEnd);
    }
    public string Time()
    {

        DateTime time = new DateTime();
        time = DateTime.Now;



        return " alarm just went off at "+time.ToString();

    }
}