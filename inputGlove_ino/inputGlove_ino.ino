#include <SoftwareSerial.h>

#define rxPin 0
#define txPin 1

SoftwareSerial usb =  SoftwareSerial(rxPin, txPin);
long baud = 115200;

int m1 = 7;
int m2 = 6;
int mwup = 5;
int mwdown = 4;

int m1State = 0;
int m2State = 0;
int mwdownState = 0;
int mwupState = 0;

bool m1Down = false;
bool m2Down = false;


void setup()
{
  pinMode(testInputPin, INPUT_PULLUP);
  pinMode(testOutputPin, OUTPUT);
  pinMode(testFeedbackPin, OUTPUT);
  digitalWrite(testOutputPin, HIGH);
  usb.begin(baud);
}

void loop()
{
  getInput()
  sync();
}

void sync()
{
  if(m1Down)
  {
    if(m1State == LOW) //pullup-resistors -> LOW means HIGH
    {
      
    }
  }
  if(m2Down)
  {
    
  }
}

void getInput()
{
  m1State = digitalRead(m1);
  m2State = digitalRead(m2);
  mwdownState = digitalRead(mwdown);
  mwupState = digitalRead(mwup);
}
