/**********************************************
By Saurabh Nishad
Mail :- saurabh.nishad@outlook.com      
**********************************************/

#include <LGSM.h>

String data;
String number = "";
boolean call = false;
String sms_text;
char charbuffer[20];

void setup()
{
  // Initialize serial port to recieve command from GUI
  Serial.begin(9600);
}

void loop()
{
  // Recieve incloming data from serial port
  while(Serial.available() > 0)
  {
    data = Serial.readString();
    data.trim();
    if(data.substring(0,1).equals("C"))
    {
      number = data.substring(1, data.length());
      call = true;
    }
    else if(data.substring(0,1).equals("M"))
    {
      for(int i = 0; i < data.length(); i++)
      {
        if(data.substring(i, i+1).equals("A"))
        {
          sms_text = data.substring(i+1, data.length());
          number = data.substring(1, i);
          break;
        }
      }
    }

    //********************************   SMS    *****************************

    else if(sms_text.length() > 0)
    {
      number.toCharArray(charbuffer, 20);
      LSMS.beginSMS(charbuffer);
      LSMS.print(sms_text);
      Serial.println("To: " + number);
      Serial.println("Text: " + sms_text);
      if(LSMS.endSMS())
      {        
        Serial.println("SMS is sent");
      }
      else
      {
        Serial.println("SMS is not sent");
        delay(5000);
      }
      sms_text = "";
    }
    
    //******************   CALL  ************************
    if (number.length() < 20 && call == true)
    {
      // let the user know you're calling:
      Serial.print("Calling to : ");
      Serial.println(number);
      Serial.println();

      // Call the remote number
      number.toCharArray(charbuffer, 20);
      
      // Check if the receiving end has picked up the call
      if(LVoiceCall.voiceCall(charbuffer))
      {
        Serial.println("Call Established. Enter line to end");
        // Wait for some input from the line
        while(Serial.read() !='\n');
        // And hang up
        LVoiceCall.hangCall();
      }
      Serial.println("Call Finished");
      number="";
      call = false;
      Serial.println("Enter phone number");
    }
    else
    {      
      Serial.println("That's too long for a phone number or you forgot to add C or M"); 
      number = "";
      call = false;    
    }
  }
}
